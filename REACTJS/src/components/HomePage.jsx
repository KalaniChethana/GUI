// import React from 'react'
// import Header from './Header.jsx'
// import Footer from './Footer.jsx'
// import toyImage from '../assets/images/ca5.jpg'
// import toyImage1 from '../assets/images/ca1.png'
// import toyImage2 from '../assets/images/ca2.png'
// import toyImage3 from '../assets/images/ca3.png'
// import toyImage4 from '../assets/images/ca4.jpg'

// const HomePage = () => {
//     const wrapperStyle = {
//         display: 'flex',
//         flexDirection: 'column',
//         minHeight: '100vh',
//     };

//     const homeStyle = {
//         flex: '1', // Ensures the content expands to fill available space
//         textAlign: 'center',
//         padding: '10px',
//     };

//     const imageContainerStyle = {
//         position: 'relative',
//         width: '100%',
//         height: '120vh', // Makes the container as tall as the viewport
//         overflow: 'hidden', // Ensures no content overflows
//     };
    
//     const imageStyle = {
//         width: '100%',
//         height: '100%',
//         objectFit: 'cover', // Ensures the image covers the entire container
//     };
    
//     const overlayStyle = {
//         position: 'absolute',
//         top: '30%',
//         left: '60%',
//         transform: 'translate(-50%, -50%)', // Centers the overlay
//         color: 'white',
//         textAlign: 'center',
//         backgroundColor: '', // Adds contrast with a semi-transparent background
//         padding: '20px 30px',
//         borderRadius: '0px',
//     };

//     const welcomeMessageStyle = {
//         fontSize: '58px',
//         fontWeight: 'bold',
//         fontFamily: '"Dancing Script", cursive', // Handwriting style
//         fontStyle: 'italic',
//         color: 'white', // Golden color for a luxurious feel
//         textShadow: '2px 2px 4px rgba(0, 0, 0, 0.6)', // Shadow for better contrast
//         marginBottom: '20px',
//     };
    
//     const buttonStyle = {
//         marginTop: '50px',
//         padding: '10px 20px',
//         fontSize: '18px',
//         fontWeight: 'bold',
//         color: 'white',
//         backgroundColor: '#007BFF', // Professional blue color for the button
//         border: 'none',
//         borderRadius: '8px',
//         cursor: 'pointer',
//         transition: 'background-color 0.3s ease',
//     };

//     const cardContainerStyle = {
//         display: 'flex',
//         justifyContent: 'space-around', // Spaces the cards evenly
//         padding: '20px',
//         gap: '20px', // Adds spacing between cards
//         backgroundColor: '#f8f9fa',
//         flexWrap: 'wrap', // Ensures cards wrap on smaller screens
//     };
    
//     const cardStyle = {
//         width: '300px',
//         border: '1px solid #ddd',
//         borderRadius: '8px',
//         overflow: 'hidden',
//         boxShadow: '0 4px 8px rgba(0, 0, 0, 0.1)',
//         textAlign: 'center',
//         backgroundColor: 'white',
//     };
    
//     const cardImageStyle = {
//         width: '60%',
//         height: '200px',
//         objectFit: 'cover',
//     };
    
//     const cardContentStyle = {
//         padding: '15px',
//     };
    
//     const cardTitleStyle = {
//         fontSize: '20px',
//         fontWeight: 'bold',
//         color: '#333',
//         margin: '10px 0',
//     };
    
//     const cardDescriptionStyle = {
//         fontSize: '14px',
//         color: '#555',
//         marginBottom: '15px',
//     };
    
//     const cardButtonStyle = {
//         padding: '10px 20px',
//         fontSize: '16px',
//         fontWeight: 'bold',
//         color: 'white',
//         backgroundColor: '#007BFF',
//         border: 'none',
//         borderRadius: '5px',
//         cursor: 'pointer',
//         transition: 'background-color 0.3s ease',
//     };
    
//     const handleCardButtonHover = (e) => (e.target.style.backgroundColor = '#0056b3');
//     const handleCardButtonOut = (e) => (e.target.style.backgroundColor = '#007BFF');    
//     const handleButtonHover = (e) => (e.target.style.backgroundColor = '#0056b3'); // Darker blue on hover
//     const handleButtonOut = (e) => (e.target.style.backgroundColor = '#007BFF'); // Original blue on mouse out
    

//     return (
//         <div>
//             <Header />
       
//         <main style={homeStyle}>
//             <div style={imageContainerStyle}>
//                 <img
//                     src={toyImage}
//                     alt="Toys on display"
//                     style={imageStyle}
//                 />
//                 <div style={overlayStyle}>
//                     <h1 style={welcomeMessageStyle}>Welcome to Cuddly Corner!</h1>
//                     {/* <p>Discover the best toys for all ages!</p> */}
//                     <button
//                         onClick={() => setCurrentPage('a href="/shop"')}
//                         style={buttonStyle}
//                         onMouseOver={handleButtonHover}
//                         onMouseOut={handleButtonOut}
//                          // Navigate to Shop Page
//                     >
//                         Shop Now
//                     </button>
//                 </div>
//             </div>

//             {/* Card Section */}
//             <section style={cardContainerStyle}>
//                 {/* Card 1 */}
//                 <div style={cardStyle}>
//                     <img
//                         src={toyImage1}
//                         alt="Toy 1"
//                         style={cardImageStyle}
//                     />
//                     <div style={cardContentStyle}>
//                         <h3 style={cardTitleStyle}>Toy Car</h3>
//                         <p style={cardDescriptionStyle}>
//                             A stylish toy car for your little one.
//                         </p>
//                         <button
//                             style={cardButtonStyle}
//                             onMouseOver={handleCardButtonHover}
//                             onMouseOut={handleCardButtonOut}
//                         >
//                             More Details
//                         </button>
//                     </div>
//                 </div>

//                 {/* Card 2 */}
//                 <div style={cardStyle}>
//                     <img
//                         src={toyImage2}
//                         alt="Toy 2"
//                         style={cardImageStyle}
//                     />
//                     <div style={cardContentStyle}>
//                         <h3 style={cardTitleStyle}>Stuffed Animal</h3>
//                         <p style={cardDescriptionStyle}>
//                             A soft and cuddly stuffed animal toy.
//                         </p>
//                         <button
//                             style={cardButtonStyle}
//                             onMouseOver={handleCardButtonHover}
//                             onMouseOut={handleCardButtonOut}
//                         >
//                             More Details
//                         </button>
//                     </div>
//                 </div>

//                 {/* Card 3 */}
//                 <div style={cardStyle}>
//                     <img
//                         src={toyImage3}
//                         alt="Toy 3"
//                         style={cardImageStyle}
//                     />
//                     <div style={cardContentStyle}>
//                         <h3 style={cardTitleStyle}>Building Blocks</h3>
//                         <p style={cardDescriptionStyle}>
//                             Build and create with colorful blocks.
//                         </p>
//                         <button
//                             style={cardButtonStyle}
//                             onMouseOver={handleCardButtonHover}
//                             onMouseOut={handleCardButtonOut}
//                         >
//                             More Details
//                         </button>
//                     </div>
//                 </div>

//                 {/* Card 4 */}
//                 <div style={cardStyle}>
//                     <img
//                         src={toyImage4}
//                         alt="Toy 4"
//                         style={cardImageStyle}
//                     />
//                     <div style={cardContentStyle}>
//                         <h3 style={cardTitleStyle}>Bolls</h3>
//                         <p style={cardDescriptionStyle}>
//                             A stylish toy car for your little one.
//                         </p>
//                         <button
//                             style={cardButtonStyle}
//                             onMouseOver={handleCardButtonHover}
//                             onMouseOut={handleCardButtonOut}
//                         >
//                             More Details
//                         </button>
//                     </div>
//                 </div>
//             </section>
//         </main>
//         <Footer />
//         </div>

//     );
// };

// export default HomePage;


// import React from 'react';
// import Header from './Header.jsx';
// import Footer from './Footer.jsx';
// import '../style/HomePage.css'; // Import the CSS file
// import toyImage from '../assets/images/hero.jpg';
// import toyImage1 from '../assets/images/ca1.png';
// import toyImage2 from '../assets/images/ca2.png';
// import toyImage3 from '../assets/images/ca3.png';
// import toyImage4 from '../assets/images/ca4.jpg';

// const HomePage = () => {
//     return (
//         <div className="home-container">
//             <Header />

//             <main className="home-content">
//                 {/* Hero Section */}
//                 <section className="hero-section">
//                     <img src={toyImage} alt="Toys on display" className="hero-image" />
//                     <div className="hero-overlay">
//                         <h1 className="hero-title">Welcome to Cuddly Corner!</h1>
//                         {/* <p className="hero-subtitle">Discover the best toys for all ages!</p> */}
//                         <button className="shop-btn" onClick={() => window.location.href = "/shop"}>
//                             Shop Now
//                         </button>
//                     </div>
//                 </section>

//                 {/* Featured Toys Section */}
//                 <section className="featured-toys">
//                     <h2 className="section-title">Our Featured Toys</h2>
//                     <div className="card-container">
//                         {/* Card 1 */}
//                         <div className="home-card">
//                             <img src={toyImage1} alt="Toy 1" className="card-image" />
//                             <div className="card-content">
//                                 <h3 className="card-title">Toy Car</h3>
//                                 <p className="card-description">A stylish toy car for your little one.</p>
//                                 <button className="card-btn">More Details</button>
//                             </div>
//                         </div>

//                         {/* Card 2 */}
//                         <div className="home-card">
//                             <img src={toyImage2} alt="Toy 2" className="card-image" />
//                             <div className="card-content">
//                                 <h3 className="card-title">Stuffed Animal</h3>
//                                 <p className="card-description">A soft and cuddly stuffed animal toy.</p>
//                                 <button className="card-btn">More Details</button>
//                             </div>
//                         </div>

//                         {/* Card 3 */}
//                         <div className="home-card">
//                             <img src={toyImage3} alt="Toy 3" className="card-image" />
//                             <div className="card-content">
//                                 <h3 className="card-title">Building Blocks</h3>
//                                 <p className="card-description">Build and create with colorful blocks.</p>
//                                 <button className="card-btn">More Details</button>
//                             </div>
//                         </div>

//                         {/* Card 4 */}
//                         <div className="home-card">
//                             <img src={toyImage4} alt="Toy 4" className="card-image" />
//                             <div className="card-content">
//                                 <h3 className="card-title">Bolls</h3>
//                                 <p className="card-description">A fun and exciting ball for kids.</p>
//                                 <button className="card-btn">More Details</button>
//                             </div>
//                         </div>
//                     </div>
//                 </section>


//                 {/* Why Choose Us Section */}
//                 <section className="why-choose-us">
//                     <h2>Why Choose Cuddly Corner?</h2>
//                     <div className="why-grid">
//                         <div className="why-item">🌟 High-Quality & Safe Toys</div>
//                         <div className="why-item">🚚 Fast & Reliable Delivery</div>
//                         <div className="why-item">🎁 Unique & Exciting Collections</div>
//                         <div className="why-item">💰 Affordable Prices</div>
//                     </div>
//                 </section>

//                 {/* Customer Testimonials */}
//                 <section className="testimonials">
//                     <h2>What Our Customers Say</h2>
//                     <div className="testimonial-container">
//                         <div className="testimonial">
//                             <p>"The toys are amazing! My kids love them. Excellent quality!"</p>
//                             <h4>- Sarah J.</h4>
//                         </div>
//                         <div className="testimonial">
//                             <p>"Fast delivery and great customer service. Highly recommended!"</p>
//                             <h4>- James M.</h4>
//                         </div>
//                         <div className="testimonial">
//                             <p>"Cuddly Corner has the best stuffed toys ever. My daughter loves them!"</p>
//                             <h4>- Emily R.</h4>
//                         </div>
//                     </div>
//                 </section>

//                 {/* Newsletter Subscription */}
//                 <section className="newsletter">
//                     <h2>Subscribe for Special Offers</h2>
//                     <p>Stay updated with our latest toy collections and exclusive discounts.</p>
//                     <div className="newsletter-form">
//                         <input type="email" placeholder="Enter your email" />
//                         <button>Subscribe</button>
//                     </div>
//                 </section>
//             </main>

//             <Footer />
//         </div>
//     );
// };

// export default HomePage;


import React from 'react';
import Header from './Header.jsx';
import Footer from './Footer.jsx';
import '../style/HomePage.css';
import toyImage from '../assets/images/hero.jpg';
import toyImage1 from '../assets/images/ca1.png';
import toyImage2 from '../assets/images/ca2.png';
import toyImage3 from '../assets/images/ca3.png';
import toyImage4 from '../assets/images/ca4.jpg';

const HomePage = () => {
    return (
        <div className="home-container">
            <Header />

            <main className="home-content">
                {/* Hero Section */}
                <section className="hero-section">
                    <div className="hero-overlay">
                        <h1 className="hero-title">Welcome to Cuddly Corner</h1>
                        <p className="hero-subtitle">
                            Discover high-quality toys that bring joy, creativity, and learning to every child.
                        </p>
                        <button className="shop-btn" onClick={() => window.location.href = "/shop"}>
                           Oder Now
                        </button>
                    </div>
                    <img src={toyImage} alt="Toys on display" className="hero-image" />
                </section>

                {/* Featured Toys Section */}
                <section className="featured-toys">
                    <h2 className="section-title">Our Exclusive Collection</h2>
                    <div className="card-container">
                        {[ 
                            { image: toyImage1, title: "Luxury Toy Car", desc: "A premium toy car with realistic design." },
                            { image: toyImage2, title: "Deluxe Building Blocks", desc: "Create endless designs with our premium blocks." },
                            { image: toyImage3, title: "Elite Stuffed Animal", desc: "A luxurious soft and cuddly companion." },
                            { image: toyImage4, title: "Signature Ball Set", desc: "High-quality, colorful ball set for playtime." }
                        ].map((toy, index) => (
                            <div key={index} className="home-card">
                                <img src={toy.image} alt={toy.title} className="card-image" />
                                <div className="card-content">
                                    <h3 className="card-title">{toy.title}</h3>
                                    <p className="card-description">{toy.desc}</p>
                                    <button className="card-btn">View Details</button>
                                </div>
                            </div>
                        ))}
                    </div>
                </section>

                {/* Why Choose Us Section */}
                <section className="why-choose-us">
                    <h2 className="section-title2">Why Shop With Us?</h2>
                    <div className="why-container">
                        <div className="why-item">🚚 Fast & Secure Delivery</div>
                        <div className="why-item">💎 Premium Quality & Safety</div>
                        <div className="why-item">🎁 Unique & Exclusive Toys</div>
                        <div className="why-item">💰 Best Value for Money</div>
                    </div>
                </section>

                {/* Customer Testimonials */}
                <section className="testimonials">
                    <h2 className="section-title">Customer Experiences</h2>
                    <div className="testimonial-container">
                        {[
                            { text: "Cuddly Corner has the best toys! My kids love them.", name: "Sarah J." },
                            { text: "Exceptional quality and service. Highly recommend!", name: "James M." },
                            { text: "These toys bring so much joy to my little ones!", name: "Emily R." }
                        ].map((review, index) => (
                            <div key={index} className="testimonial">
                                <p>"{review.text}"</p>
                                <h4>- {review.name}</h4>
                            </div>
                        ))}
                    </div>
                </section>

                {/* Newsletter Subscription */}
                <section className="newsletter">
                    <h2 className="section-title">Stay Updated</h2>
                    <p>Sign up for exclusive discounts and new arrivals.</p>
                    <div className="newsletter-form">
                        <input type="email" placeholder="Enter your email" />
                        <button>Subscribe</button>
                    </div>
                </section>
            </main>

            <Footer />
        </div>
    );
};

export default HomePage;
