

import React, { useState, useEffect } from "react";
import axios from "axios";
import Header from "./Header.jsx";
import Footer from "./Footer.jsx";
import "../style/global.css";
import "../style/shop.css";

const ShopSection = () => {
  const [cart, setCart] = useState([]);
  const [products, setProducts] = useState([]);  // To store fetched products
  const [loading, setLoading] = useState(false);

  const PF = "http://localhost:5000/images/";  // Assuming the image URL

  // Fetch products from the backend
  useEffect(() => {
    const fetchProducts = async () => {
      setLoading(true);
      try {
        const response = await axios.get("http://127.0.0.1:5000/api/products");
        setProducts(response.data);  // Set fetched products in state
      } catch (error) {
        console.error("Failed to fetch products:", error);
      } finally {
        setLoading(false);
      }
    };

    fetchProducts();
  }, []);

  const handleAddToCart = (product) => {
    const existingProduct = cart.find(item => item.id === product.id);
    if (existingProduct) {
      setCart(cart.map(item =>
        item.id === product.id ? { ...item, quantity: item.quantity + 1 } : item
      ));
    } else {
      setCart([...cart, { ...product, quantity: 1 }]);
    }
  };

  const handleRemoveFromCart = (id) => {
    setCart(cart.filter(item => item.id !== id));
  };

  const handleCheckout = () => {
    alert("Proceeding to checkout...");
    // Add your checkout logic here (e.g., redirect to payment)
  };

  return (
    <section className="shop-container">
      <h2 className="shop-title">Shop</h2>

      {/* Loading state */}
      {loading && <p>Loading products...</p>}

      <div className="product-grid">
        {/* Displaying fetched products */}
        {products.map((product) => (
          <div key={product.id} className="product-card">
            <img
                  src={PF + product.Image}
                  className="img-fluid rounded"
                  style={{ height: "200px", width: "300px", marginLeft: "10px" }}
                  alt={product.Image}
                />
            <h3 className="product-name">{product.name}</h3>
            <p className="product-price">{product.price}</p>
            <button className="add-to-cart" onClick={() => handleAddToCart(product)}>
              Add to Cart
            </button>
          </div>
        ))}
      </div>

      {/* Cart Table */}
      {cart.length > 0 && (
          <div className="cart-section">
            <h3>Your Cart</h3>
            <table className="cart-table">
              <thead>
                <tr>
                  <th>Product</th>
                  <th>Price</th>
                  <th>Quantity</th>
                  <th>Total</th>
                  <th>Action</th>
                </tr>
              </thead>
              <tbody>
                {cart.map((item) => (
                  <tr key={item.id}>
                    <td>{item.name}</td>
                    <td>{item.price}</td>
                    <td>{item.quantity}</td>
                    <td>${(parseFloat(item.price.replace("$", "")) * item.quantity).toFixed(2)}</td>
                    <td>
                      <button className="remove-btn" onClick={() => handleRemoveFromCart(item.id)}>Remove</button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
            <div className="cart-total">
              <p>Total: ${cart.reduce((total, item) => total + (parseFloat(item.price.replace("$", "")) * item.quantity), 0).toFixed(2)}</p>
              <button className="checkout-btn" onClick={handleCheckout}>Checkout</button>
            </div>
          </div>
        )}
    </section>
  );
};

const App = () => {
  return (
    <div>
      <Header />
      <ShopSection />
      <Footer />
    </div>
  );
};

export default App;

