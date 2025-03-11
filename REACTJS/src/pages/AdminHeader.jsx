import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "../css/adminHeader.css"; // Custom styles
import AdminLogo from "../assets/images/1.png"; // Change path if needed

const AdminHeader = () => {
  const [dropdownOpen, setDropdownOpen] = useState(false);
  const navigate = useNavigate();

  const handleLogout = () => {
    navigate("/"); // Redirect to admin login page
  };

  return (
    <header className="admin-header">
      
      <div className="admin-header-container">
        
        {/* Logo Section - Left */}
        <div className="admin-logo">
          <Link to="/admin/dashboard">
            <img src={AdminLogo} alt="Admin Logo" className="admin-logo-img" />
          </Link>
          
        </div>
        <h1 class = "admin-text">Admin Dashbord</h1>

        {/* User Icon - Right */}
        <div className="admin-user">
          <div className="admin-user-icon" onClick={() => setDropdownOpen(!dropdownOpen)}>
            &#128100; {/* User Icon */}
          </div>
          {dropdownOpen && (
            <div className="admin-dropdown-menu">
              <button onClick={handleLogout}>Logout</button>
            </div>
          )}
        </div>
      </div>
    </header>
  );
};

export default AdminHeader;
