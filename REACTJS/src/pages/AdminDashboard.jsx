import { useState, useEffect } from "react";
import axios from "axios";
import "../css/admin-dashboard.css";
import ProductTable from "./ProductTable";
import AddProductModal from "../components/AddProductModal";
import Sidebar from "./Sidebar";
import AdminLogin from "./AdminLogin";
import AdminHeader from "./adminHeader";

const AdminDashboard = () => {
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(false); // API request loader
  const [file, setFile] = useState(null); // To hold the selected file

  // Fetch products from the database on component mount
  useEffect(() => {
    fetchProducts();
  }, []);

  const fetchProducts = async () => {
    setLoading(true);
    try {
      const response = await axios.get("http://127.0.0.1:5000/api/products");
      setProducts(response.data);
    } catch (error) {
      console.error("Failed to fetch products:", error);
    } finally {
      setLoading(false);
    }
  };

  // Function to add a new product and instantly update UI
  const handleAddProduct = async (newProduct) => {
    setLoading(true);
    try {
      if (file) {
        const data = new FormData();
        const filename = Date.now() + file.name;
        data.append("name", filename); // This will add the filename to the request
        data.append("image", file); // Ensure the field name matches the backend
  
        try {
          // Upload the file first
          await axios.post("http://localhost:5000/api/upload", data, {
            headers: {
              "Content-Type": "multipart/form-data", // Ensure the correct header is set
            },
          });
        } catch (err) {
          alert("Error uploading the image: " + err);
          return;
        }
  
        // Add the filename (image name) to the product data
        newProduct.image = filename;
      }
  
      const response = await axios.post("http://127.0.0.1:5000/api/products/add", newProduct);
      if (response.status === 200) {
        const addedProduct = response.data; // Get the new product from response
  
        // Instantly update state with the new product (without waiting for fetch)
        setProducts((prevProducts) => [...prevProducts, addedProduct]);
  
        setIsModalOpen(false); // Close modal only after updating the UI
      }
    } catch (error) {
      console.error("Error adding product:", error);
    } finally {
      setLoading(false);
    }
  };
  

  // Handle file input change
  const handleFileChange = (e) => {
    setFile(e.target.files[0]); // Get the selected file
  };

  return (
    <div className="admin-container">
      
      <AdminHeader />
     
      <main className="admin-main">
        <div className="dashboard-header">
          
          <button className="button button-add" onClick={() => setIsModalOpen(true)}>
            + Add Product
          </button>
        </div>
        {loading && <p className="loading-message">Loading...</p>}
        <ProductTable products={products} />
        
        {/* Add Product Modal */}
        {/* <AddProductModal
          isOpen={isModalOpen}
          onClose={() => setIsModalOpen(false)}
          onSave={handleAddProduct}
        /> */}

        {/* Modal Content */}
        {isModalOpen && (
          <div className="modal-overlay">
            <div className="modal-content">
              <h2>Add New Product</h2>
              <form
                onSubmit={(e) => {
                  e.preventDefault();
                  handleAddProduct({
                    name: e.target.name.value,
                    price: e.target.price.value,
                    description: e.target.description.value,
                  });
                }}
              >
                <label>
                  Product Name:
                  <input type="text" name="name" required />
                </label>
                <label>
                  Price:
                  <input type="number" name="price" required />
                </label>
                <label>
                  Description:
                  <textarea name="description" required />
                </label>

                {/* File Input for Image */}
                <label>
                  Product Image:
                  <input type="file" name="image" onChange={handleFileChange} />
                  </label>

                <button type="submit">Add Product</button>
              </form>
            </div>
          </div>
        )}
      </main>
    </div>
  );
};

export default AdminDashboard;
