import React from "react";
import Header from "./Header.jsx";
import Footer from "./Footer.jsx";
import "../style/blog.css";

// Sample blog data
const blogPosts = [
  {
    id: 1,
    image: "../assets/images/ca4.jpg",
    title: "Top 10 Toys for Kids in 2025",
    description: "Explore the latest trending toys that kids love!",
    date: "March 5, 2025",
  },
  {
    id: 2,
    image: "../assets/images/ca4.jpg",
    title: "Educational Toys That Make Learning Fun",
    description: "Check out these toys that help in early childhood education.",
    date: "March 10, 2025",
  },
  {
    id: 3,
    image: "../assets/images/d1.jpg",
    title: "Soft Toys That Kids Can’t Resist",
    description: "Discover the cuddliest soft toys for your little one.",
    date: "March 15, 2025",
  },
  {
    id: 4,
    image: "../assets/images/d2.jpg",
    title: "How to Choose Safe Toys for Your Child",
    description: "Safety tips every parent should know before buying toys.",
    date: "March 20, 2025",
  },
];

const Blog = () => {
  return (
    <div className="blog-container">
      <Header />
      
      {/* Hero Section */}
      <section className="blog-hero">
        <div className="blog-hero-overlay">
          <h1>Welcome to Our Blog</h1>
          <p>Discover the latest toy trends, parenting tips, and more!</p>
        </div>
      </section>

      {/* Blog Posts Section */}
      <section className="blog-posts">
        <h2 className="section-title">Latest Blog Posts</h2>
        <div className="blog-grid">
          {blogPosts.map((post) => (
            <div key={post.id} className="blog-card">
              
              <div className="blog-content">
                <h3 className="blog-title">{post.title}</h3>
                <p className="blog-description">{post.description}</p>
                <span className="blog-date">{post.date}</span>
                <button className="read-more-btn">Read More</button>
              </div>
            </div>
          ))}
        </div>
      </section>

      <Footer />
    </div>
  );
};

export default Blog;
