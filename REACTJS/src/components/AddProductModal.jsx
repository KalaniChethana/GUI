import { useState } from "react";
import axios from "axios";

const AddProductModal = ({ isOpen, onClose, onSave }) => {
  const [productName, setProductName] = useState("");
  const [productPrice, setProductPrice] = useState("");
  const [productDescription, setProductDescription] = useState("");
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState("");

  if (!isOpen) return null; // Hide modal when not open

  const handleSave = async () => {
    setLoading(true);
    setError("");

    const newProduct = {
      name: productName,
      price: parseFloat(productPrice), // Convert price to a number
      description: productDescription,
    };

    try {
      // Send POST request to save product in database
      const response = await axios.post("http://127.0.0.1:5000/api/products/add", newProduct);
      
      if (response.status === 200) {
        onSave(response.data); // Add the new product to the UI
        setProductName("");
        setProductPrice("");
        setProductDescription("");
        onClose(); // Close modal after saving
      } else {
        setError("Failed to save product. Try again.");
      }
    } catch (err) {
      setError("Error: " + (err.response?.data?.error || "Something went wrong"));
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="modal-overlay">
      <div className="modal-content">
        <h2>Add New Product</h2>

        {error && <p className="error-message">{error}</p>}

        <input
          type="text"
          placeholder="Product Name"
          value={productName}
          onChange={(e) => setProductName(e.target.value)}
        />
        <input
          type="number"
          placeholder="Price"
          value={productPrice}
          onChange={(e) => setProductPrice(e.target.value)}
        />
        <textarea
          placeholder="Description"
          value={productDescription}
          onChange={(e) => setProductDescription(e.target.value)}
        />

        <div className="modal-buttons">
          <button className="button-save" onClick={handleSave} disabled={loading}>
            {loading ? "Saving..." : "Save"}
          </button>
          <button className="button-cancel" onClick={onClose}>Cancel</button>
        </div>
      </div>
    </div>
  );
};

export default AddProductModal;
