import express from "express";
import db from "../config/db.js";
const router = express.Router();

// Get all products
router.get("/", (req, res) => {
  db.query("SELECT * FROM products", (err, results) => {
    if (err) return res.status(500).json({ error: err });
    res.json(results);
  });
});

// Add Product
router.post("/add", (req, res) => {
  const { name, price, description, image } = req.body;
  db.query(
    "INSERT INTO products (name, price, description, image) VALUES (?, ?, ?, ?)",
    [name, price, description, image],
    (err, result) => {
      if (err) return res.status(500).json({ error: err });
      res.json({ id: result.insertId, name, price, description, image });
    }
  );
});

// Update Product
router.put("/update/:id", (req, res) => {
  const { name, price, description, image } = req.body;
  db.query(
    "UPDATE products SET name = ?, price = ?, description = ?, image = ? WHERE id = ?",
    [name, price, description, image, req.params.id],
    (err, result) => {
      if (err) return res.status(500).json({ error: err });
      res.json({ message: "Product updated successfully!" });
    }
  );
});

// Delete Product
router.delete("/delete/:id", (req, res) => {
  db.query("DELETE FROM products WHERE id = ?", [req.params.id], (err, result) => {
    if (err) return res.status(500).json({ error: err });
    res.json({ message: "Product deleted successfully!" });
  });
});

export default router;
