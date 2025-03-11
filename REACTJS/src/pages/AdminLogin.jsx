import { useState } from "react";
import { useAuth } from "../context/AuthContext";
import { useNavigate } from "react-router-dom";
import axios from "axios";
import "../css/login.css"; // Use same CSS

const AdminLogin = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const navigate = useNavigate();
  const { login } = useAuth();

  const handleAdminLogin = async (e) => {
    e.preventDefault();
    setError("");
  
    try {
      const response = await axios.post("http://127.0.0.1:5000/api/auth/login", { email, password });
  
      console.log("Server Response:", response.data); // ✅ Log response
  
      localStorage.setItem("token", response.data.token);
  
      if (response.data.role === "admin") {
        navigate("/admin/dashboard");
      } else {
        setError("Access denied! This is an admin-only login.");
      }
    } catch (err) {
      console.error("Login Error:", err.response?.data || err.message); // ✅ Log errors
      setError("Invalid admin credentials.");
    }
  };
  

  return (
    <div className="login-container">
      <h2>Admin Login</h2>
      {error && <p className="error-message">{error}</p>}
      <form onSubmit={handleAdminLogin}>
        <input type="email" placeholder="Admin Email" value={email} onChange={(e) => setEmail(e.target.value)} required />
        <input type="password" placeholder="Password" value={password} onChange={(e) => setPassword(e.target.value)} required />
        <button type="submit">Login</button>
      </form>
    </div>
  );
};

export default AdminLogin;
