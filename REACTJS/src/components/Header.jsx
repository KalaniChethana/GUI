// import React from 'react';
// import Logo from '../assets/images/1.png'


// const Header = () => {
//     const headerStyle = {
//         display: 'flex',
//         justifyContent: 'space-between',
//         alignItems: 'center',
//         padding: '15px 20px',
//         backgroundColor: '#333', // Dark gray for a professional look
//         color: 'white',
//         boxShadow: '0 4px 8px rgba(0, 0, 0, 0.1)',
//         position: 'sticky',
//         top: '0',
//         zIndex: '1000',
//         transition: 'background-color 0.3s ease, color 0.3s ease',
//     };

//     const logoStyle = {
//         fontSize: '24px', // Reduced size for a more professional appearance
//         fontWeight: '600', // Slightly lighter boldness
//         margin: '0',
//         cursor: 'pointer',
//         display: 'flex',
//         alignItems: 'center',
//         color: 'white', // Ensures the text color matches the header text color
//         letterSpacing: '1px', // Adds slight letter spacing for a more refined look
//     };

//     const logoImageStyle = {
//         width: '50px', // Adjust logo size as needed
//         height: '50px', // Make sure height equals width for a perfect circle
//         borderRadius: '1000%', // This makes the logo round
//         marginRight: '20px',
//     };

//     const navStyle = {
//         display: 'flex',
//         alignItems: 'center',
//         gap: '50px',
//     };

//     const navLinkStyle = {
//         textDecoration: 'none',
//         color: 'white',
//         fontSize: '16px', // Adjusted to a more professional size
//         fontWeight: '400', // Lighter weight for a cleaner design
//         transition: 'color 0.3s ease',
//         textTransform: 'uppercase', // Makes links look more professional
//         letterSpacing: '1px', // Adds spacing for cleaner readability
//     };

//     const navLinkHover = (e) => (e.target.style.color = '#FFD700'); // Gold color for hover
//     const navLinkOut = (e) => (e.target.style.color = 'white');

//     return (
//         <header style={headerStyle}>
//             <div style={logoStyle}>
//                 <img src={Logo} alt="Logo" style={logoImageStyle} />
//                 Cuddly Corner
//             </div>
//             <nav style={navStyle}>
//                 <a href="/" style={navLinkStyle} onMouseOver={navLinkHover} onMouseOut={navLinkOut}>
//                     Home
//                 </a>
//                 <a href="/shop" style={navLinkStyle} onMouseOver={navLinkHover} onMouseOut={navLinkOut}>
//                 <span onClick={() => setCurrentPage('shop')}>
//                     Shop
//                 </span>
//                 </a>
//                 <a href="#about" style={navLinkStyle} onMouseOver={navLinkHover} onMouseOut={navLinkOut}>
//                     About
//                 </a>
//                 <a href="#contact" style={navLinkStyle} onMouseOver={navLinkHover} onMouseOut={navLinkOut}>
//                     Contact
//                 </a>
                
//             </nav>
//         </header>
//     );
// };

// export default Header;

// import React from "react";
// import "../style/header.css";
// import Logo from '../assets/images/1.png'

// const Header = () => {
//   return (
//     <header className="header">
//       <div className="header-container">
//         <div className="logo">
//           <a href="/">
//             <img src="../assets/images/1.png" alt="Logo" width="107" height="24" />
//           </a>
//         </div>
//         <nav>
//           <ul className="nav-links">
//             <li><a href="/home">Home</a></li>
//             <li><a href="/shop">Shop</a></li>
//             <li><a href="/blog">Blog</a></li>
//             <li><a href="/contact">Contact</a></li>
//           </ul>
//         </nav>
//       </div>
//     </header>
//   );
// };

// export default Header;

// import React, { useState } from "react";
// import { useNavigate } from "react-router-dom"; // Use for navigation
// import "../style/header.css";
// import Logo from "../assets/images/1.png";

// const Header = () => {
//   const [dropdownOpen, setDropdownOpen] = useState(false);
//   const navigate = useNavigate();

//   const handleLogout = () => {
//     navigate("/"); // Redirect to login page
//   };

//   return (
//     <header className="header">
//       <div className="header-container">
//         {/* Logo Section */}
//         <div className="logo">
//           <img src={Logo} alt="Logo" className="logo-img" />
//           <span className="logo-text">Cuddly Corner</span>
//         </div>

//         {/* Navigation Menu */}
//         <nav>
//           <ul className="nav-links">
//             <li><a href="/home">Home</a></li>
//             <li><a href="/shop">Shop</a></li>
//             <li><a href="/blog">Blog</a></li>
//             <li><a href="/contact">Contact</a></li>
//           </ul>
//         </nav>

//         {/* Cart & User Icons */}
//         <div className="header-icons">
//           {/* Shopping Cart */}
//           <div className="cart">
//             <span className="cart-icon">&#128722;</span>
//             <span className="cart-count">2</span> 
//           </div>

//           {/* User Dropdown */}
//           <div className="user" onClick={() => setDropdownOpen(!dropdownOpen)}>
//             <span className="user-icon">&#128100;</span> {/* User emoji */}
//             {dropdownOpen && (
//               <div className="dropdown-menu">
//                 <button onClick={handleLogout}>Logout</button>
//               </div>
//             )}
//           </div>
//         </div>
//       </div>
//     </header>
//   );
// };

// export default Header;


import React, { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import "../style/header.css";
import Logo from "../assets/images/1.png";

const Header = () => {
  const [dropdownOpen, setDropdownOpen] = useState(false);
  const navigate = useNavigate();

  const handleLogout = () => {
    navigate("/"); // Redirect to login page
  };

  return (
    <header className="heheader">
      <div className="heheader-container">
        {/* Logo Section - Left */}
        <div className="helogo">
          <Link to="/">
            <img src={Logo} alt="Cuddly Corner" className="helogo-img" />
          </Link>
        </div>

        {/* Navigation Menu - Center */}
        <nav className="henav-menu">
          <ul className="henav-links">
            <li><Link to="/home">Home</Link></li>
            <li><Link to="/shop">Shop</Link></li>
            <li><Link to="/blog">Blog</Link></li>
            <li><Link to="/contact">Contact</Link></li>
          </ul>
        </nav>

        {/* User & Cart - Right */}
        <div className="heheader-icons">
          {/* Shopping Cart */}
          <div className="hecart">
            <span className="hecart-icon">&#128722;</span>
            <span className="hecart-count">2</span>
          </div>

          {/* User Dropdown */}
          <div className="heuser" onClick={() => setDropdownOpen(!dropdownOpen)}>
            <span className="heuser-icon">&#128100;</span> {/* User icon */}
            {dropdownOpen && (
              <div className="hedropdown-menu">
                <button onClick={handleLogout}>Logout</button>
              </div>
            )}
          </div>
        </div>
      </div>
    </header>
  );
};

export default Header;

