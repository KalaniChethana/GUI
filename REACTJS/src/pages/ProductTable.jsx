import { useState } from "react";
import axios from "axios";

const ProductTable = ({ products, fetchProducts }) => {
  const [searchQuery, setSearchQuery] = useState("");

  const PF = "http://localhost:5000/images/";

  const handleDelete = async (id) => {
    if (window.confirm("Are you sure you want to delete this product?")) {
      await axios.delete(`http://127.0.0.1:5000/api/products/delete/${id}`);
      fetchProducts();
    }
  };

  const filteredProducts = products.filter((product) =>
    product.name.toLowerCase().includes(searchQuery.toLowerCase())
  );

  return (
    <div className="card">
      <div className="search-bar">
        <input
          type="text"
          placeholder="Search products..."
          value={searchQuery}
          onChange={(e) => setSearchQuery(e.target.value)}
        />
      </div>

      <table className="admin-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price ($)</th>
            <th>Description</th>
            <th>Image</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {filteredProducts.map((product) => (
            <tr key={product.id}>
              <td>{product.id}</td>
              <td>{product.name}</td>
              <td>{product.price}</td>
              <td>{product.description}</td>
              <td>
                {/* Display image from the server */}
                <img
                  src={PF + product.Image}
                  className="img-fluid rounded"
                  style={{ height: "200px", width: "300px", marginLeft: "10px" }}
                  alt={product.Image}
                />
              </td>
              <td>
                <button className="button button-update">Update</button>
                <button className="button button-delete" onClick={() => handleDelete(product.id)}>
                  Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default ProductTable;
