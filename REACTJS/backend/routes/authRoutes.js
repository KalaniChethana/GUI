import express from 'express';
import db from '../config/db.js';
import bcrypt from 'bcryptjs';
import dotenv from 'dotenv';

dotenv.config();
const router = express.Router();

// get users
router.get('/', (req, res) => {
  db.query("SELECT * FROM users", (err, results) => {
    if (err) return res.status(500).json({ error: err });
    res.json(results);
  });
});

// Signup Route
router.post('/signup', async (req, res) => {
  const { name, email, password, role } = req.body;

  // Validate input
  if (!name || !email || !password || !role) {
    return res.status(400).json({ error: "Email, password, and role are required" });
  }

  try {
    // Check if the email already exists
    const checkEmailSql = "SELECT id FROM users WHERE email = ?";
    db.query(checkEmailSql, [email], async (err, results) => {
      if (err) {
        console.error("❌ DB Query Error:", err);
        return res.status(500).json({ error: "Database error" });
      }

      if (results.length > 0) {
        return res.status(409).json({ error: "Email already registered" });
      }

      // Hash the password
      const saltRounds = 10;
      const hashedPassword = await bcrypt.hash(password, saltRounds);
      console.log("🔹 Hashed Password:", hashedPassword);

      // Insert new user
      const insertUserSql = "INSERT INTO users (name, email, password, role) VALUES (?, ?, ?, ?)";
      db.query(insertUserSql, [name, email, hashedPassword, role], (err, result) => {
        if (err) {
          console.error("❌ DB Insert Error:", err);
          return res.status(500).json({ error: "Failed to register user" });
        }

        res.json({ message: "User registered successfully!" });
      });
    });
  } catch (error) {
    console.error("❌ Signup Error:", error);
    res.status(500).json({ error: "Internal server error" });
  }
});

router.post('/login', async (req, res) => {
  const { email, password } = req.body;

  if (!email || !password) {
    return res.status(400).json({ error: "Email and password are required" });
  }

  const sql = "SELECT * FROM users WHERE email = ?";
  db.query(sql, [email], async (err, results) => {
    if (err) {
      console.error("❌ DB Query Error:", err);
      return res.status(500).json({ error: "Database error" });
    }

    if (results.length === 0) {
      return res.status(401).json({ error: "Invalid email or password" });
    }

    const user = results[0];
    let storedHash = user.password;

    // Convert $2y$ to $2b$ (fix PHP bcrypt issue)
    if (storedHash.startsWith("$2y$")) {
      storedHash = "$2b$" + storedHash.substring(4);
    }

    console.log("🔹 Adjusted Hashed Password for Comparison:", storedHash);

    const isPasswordCorrect = await bcrypt.compare(password, storedHash);
    console.log("🔹 Password Match:", isPasswordCorrect);

    if (!isPasswordCorrect) {
      return res.status(401).json({ error: "Invalid email or password" });
    }

    res.json({ message: "Login successful", user: { id: user.id,name:user.name, email: user.email, role: user.role } });
  });
});

export default router;
