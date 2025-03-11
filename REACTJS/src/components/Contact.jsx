import React from "react";
import Header from "./Header.jsx";
import Footer from "./Footer.jsx";
import "../style/contact.css";

const Contact = () => {
  return (
    <div className="contact-container">
      <Header />

      {/* Hero Section */}
      <section className="contact-hero">
        <div className="contact-hero-overlay">
          <h1 className = "font" >Get in Touch</h1>
          <p>We’d love to hear from you! Contact us for any inquiries.</p>
        </div>
      </section>

      {/* Contact Details & Form */}
      <section className="contact-content">
        <div className="contact-info">
          <h2 >Contact Information</h2>
          <p>Feel free to reach out to us via the contact details below:</p>
          
          <div className="contact-details">
            <p>📍 Address: 123 Toy Street, Funland, USA</p>
            <p>📧 Email: support@cuddlycorner.com</p>
            <p>📞 Phone: +123 456 7890</p>
            <p>⏰ Hours: Mon - Fri, 9:00 AM - 6:00 PM</p>
          </div>
        </div>

        {/* Contact Form */}
        <div className="contact-form">
          <h2>Send Us a Message</h2>
          <form>
            <div className="input-group">
              <input type="text" placeholder="Your Name" required />
            </div>
            <div className="input-group">
              <input type="email" placeholder="Your Email" required />
            </div>
            <div className="input-group">
              <textarea placeholder="Your Message" rows="5" required></textarea>
            </div>
            <button type="submit" className="send-btn">Send Message</button>
          </form>
        </div>
      </section>

      {/* Google Map Section */}
      <section className="map-section">
        <h2>Find Us on the Map</h2>
        <div className="map-container">
          <iframe
            title="Google Map"
            src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d63306.09345024315!2d80.2003708!3d6.0329293!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3ae1736ff7841181%3A0x68f8c5f3e85d5d8d!2sGalle%2C%20Sri%20Lanka!5e0!3m2!1sen!2sus!4v1710000000000"
            width="100%"
            height="400"
            allowFullScreen=""
            loading="lazy"
          ></iframe>
        </div>
      </section>

      <Footer />
    </div>
  );
};

export default Contact;
