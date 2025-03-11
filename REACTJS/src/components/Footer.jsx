// import React from 'react'

// const Footer = () => {
//     const footerStyle = {
//         textAlign: 'center',
//         padding: '10px',
//         backgroundColor: '#333',
//         color: 'white',
//         position: 'relative',
//         bottom: '0',
//         width: '100%',
//     };

//     return (
//         <footer style={footerStyle}>
//             <p>&copy; 2025 Toy Shop. All rights reserved.</p>
//         </footer>
//     );
// };

// export default Footer;


// import React from "react";
// import "../style/footer.css";

// const Footer = () => {
//   return (
//     <footer className="footer">
//       <div className="footer-container">
//         <div className="footer-section">
//           <h3>Contact Us</h3>
//           <p>📍 123 Toy Street, Funland, USA</p>
//           <p>📧 support@toyshop.com</p>
//           <p>📞 +123 456 7890</p>
//         </div>

//         <div className="footer-section">
//           <h3>Recent News</h3>
//           <p>📰 Exciting new toys just arrived!</p>
//           <p>📅 March 2025</p>
//         </div>

//         <div className="footer-section">
//           <h3>Follow Us</h3>
//           <p>📘 Facebook | 🐦 Twitter | 📷 Instagram | 📺 YouTube</p>
//         </div>
//       </div>

//       <div className="copy-right">
//         <p>&copy; 2025 Toy Shop. All rights reserved.</p>
//       </div>
//     </footer>
//   );
// };

// export default Footer;

import React from "react";
import "../style/footer.css";

const Footer = () => {
  return (
    <footer className="footer">
      <div className="footer-container">
        {/* Contact Section */}
        <div className="footer-section">
          <h3>Contact Us</h3>
          <ul className="footer-list">
            <li>123 Toy Street, Funland, USA</li>
            <li>Email: <a href="mailto:support@toyshop.com">support@toyshop.com</a></li>
            <li>Phone: +123 456 7890</li>
          </ul>
        </div>

        {/* Company Info */}
        <div className="footer-section">
          <h3>About Us</h3>
          <p>
            We provide the best quality toys for kids, ensuring fun, safety, and learning.
            Explore our latest collections for exciting gifts!
          </p>
        </div>

        {/* Quick Links */}
        <div className="footer-section">
          <h3>Quick Links</h3>
          <ul className="footer-list">
            <li><a href="/shop">Shop</a></li>
            <li><a href="/blog">Blog</a></li>
            <li><a href="/contact">Contact</a></li>
            <li><a href="/about">About Us</a></li>
          </ul>
        </div>

        {/* Social Links */}
        <div className="footer-section">
          <h3>Follow Us</h3>
          <ul className="social-links">
            <li><a href="#">Facebook</a></li>
            <li><a href="#">Twitter</a></li>
            <li><a href="#">Instagram</a></li>
            <li><a href="#">YouTube</a></li>
          </ul>
        </div>
      </div>

      {/* Copyright Section */}
      <div className="copy-right">
        <p>&copy; 2025 Cuddly Corner. All rights reserved.</p>
      </div>
    </footer>
  );
};

export default Footer;

