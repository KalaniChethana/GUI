

import { useState } from "react";
import { useNavigate, Link } from "react-router-dom";
import axios from "axios";
import "../css/login.css";
import toyStoreBackground from "../assets/images/toystore.jpg"; // Ensure correct path

const Login = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();

  const handleLogin = async (e) => {
    e.preventDefault();
    setError("");
    setLoading(true);

    try {
      const response = await axios.post("http://127.0.0.1:5000/api/auth/login", { email, password });

      if (response.data.message === "Login successful") {
        const { token, user } = response.data;
        
        localStorage.setItem("token", token);
        navigate(user.role === "admin" ? "/admin/dashboard" : "/home");
      } else {
        setError("Invalid login attempt.");
      }
    } catch (err) {
      setError("Invalid email or password. Try again.");
    }
    setLoading(false);
  };

  return (
    <div className="login-page">
      <div className="background">
        <img src={toyStoreBackground} alt="Toy Store" className="background-image" />
      </div>

      <div className="login-container">
        <h2 className="login-title">User Login</h2>

        {error && <p className="error-message">{error}</p>}

        <form onSubmit={handleLogin}>
          <input
            type="email"
            placeholder="Enter your email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />
          <input
            type="password"
            placeholder="Enter your password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
          />

          <button type="submit" className="login-btn" disabled={loading}>
            {loading ? "Logging in..." : "Login"}
          </button>
        </form>

        <p className="new-user-text">New User?</p>
        <Link to="/signup" className="signup-btn">Sign Up</Link>
      </div>
    </div>
  );
};

export default Login;