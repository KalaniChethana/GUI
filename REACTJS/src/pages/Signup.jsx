// import { useState } from "react";
// import { useNavigate } from "react-router-dom";
// import axios from "axios";
// import "../css/signup.css"; // Ensure this file exists for styling

// const Signup = () => {
//   const [name, setName] = useState("");
//   const [email, setEmail] = useState("");
//   const [password, setPassword] = useState("");
//   const [role, setRole] = useState("user"); // Default role
//   const [error, setError] = useState("");
//   const [success, setSuccess] = useState("");
//   const navigate = useNavigate();

//   const handleSignup = async (e) => {
//     e.preventDefault();
//     setError("");
//     setSuccess("");

//     try {
//       const response = await axios.post("http://127.0.0.1:5000/api/auth/signup", {
//         name,
//         email,
//         password,
//         role,
//       });

//       setSuccess("User registered successfully! Redirecting to login...");
//       setTimeout(() => navigate("/"), 2000); // Redirect after success
//     } catch (err) {
//       setError(err.response?.data?.error || "Failed to register. Try again.");
//     }
//   };

//   return (
//     <div className="signup-container">
//       <h2>Create an Account</h2>
//       {error && <p className="error-message">{error}</p>}
//       {success && <p className="success-message">{success}</p>}

//       <form onSubmit={handleSignup}>
//         <input
//           type="text"
//           placeholder="Full Name"
//           value={name}
//           onChange={(e) => setName(e.target.value)}
//           required
//         />
//         <input
//           type="email"
//           placeholder="Email"
//           value={email}
//           onChange={(e) => setEmail(e.target.value)}
//           required
//         />
//         <input
//           type="password"
//           placeholder="Password"
//           value={password}
//           onChange={(e) => setPassword(e.target.value)}
//           required
//         />
//         <select value={role} onChange={(e) => setRole(e.target.value)}>
//           <option value="user">User</option>
//           <option value="admin">Admin</option>
//         </select>
//         <button type="submit">Sign Up</button>
//       </form>

//       <p>
//         Already have an account? <button onClick={() => navigate("/")}>Login</button>
//       </p>
//     </div>
//   );
// };

// export default Signup;

import { useState } from "react";
import { useNavigate, Link } from "react-router-dom";
import axios from "axios";
import "../css/signup.css"; // Ensure this file exists for styling
import toyStoreBackground from "../assets/images/toystore.jpg"; // Change path if needed

const Signup = () => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [role, setRole] = useState("user");
  const [error, setError] = useState("");
  const [success, setSuccess] = useState("");
  const navigate = useNavigate();

  const handleSignup = async (e) => {
    e.preventDefault();
    setError("");
    setSuccess("");

    try {
      await axios.post("http://127.0.0.1:5000/api/auth/signup", {
        name,
        email,
        password,
        role,
      });

      setSuccess("User registered successfully! Redirecting...");
      setTimeout(() => navigate("/"), 2000);
    } catch (err) {
      setError(err.response?.data?.error || "Failed to register. Try again.");
    }
  };

  return (
    <div className="signup-page">
      <div className="background">
        <img src={toyStoreBackground} alt="Toy Store" className="background-image" />
      </div>

      <div className="signup-container">
        <h2 className="signup-title">Create an Account</h2>
        <p className="signup-subtitle">Join us for exciting toy collections!</p>

        {error && <p className="error-message">{error}</p>}
        {success && <p className="success-message">{success}</p>}

        <form onSubmit={handleSignup} className="signup-form">
          <input
            type="text"
            placeholder="Full Name"
            value={name}
            onChange={(e) => setName(e.target.value)}
            required
          />

          <input
            type="email"
            placeholder="Email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />

          <input
            type="password"
            placeholder="Password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
          />

          <select value={role} onChange={(e) => setRole(e.target.value)}>
            <option value="user">User</option>
            <option value="admin">Admin</option>
          </select>

          <button type="submit" className="signup-btn">Sign Up</button>
        </form>

        <p className="login-text">Already have an account?</p>
        <Link to="/" className="login-btn">Login</Link>
      </div>
    </div>
  );
};

export default Signup;