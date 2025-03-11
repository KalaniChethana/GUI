const DashboardHome = () => {
    return (
      <div className="dashboard-home">
        <h2>Admin Dashboard</h2>
        <div className="dashboard-cards">
          <div className="dashboard-card">
            <h3>Total Products</h3>
            <p>120</p>
          </div>
          <div className="dashboard-card">
            <h3>Total Users</h3>
            <p>350</p>
          </div>
          <div className="dashboard-card">
            <h3>Sales This Month</h3>
            <p>$25,000</p>
          </div>
        </div>
      </div>
    );
  };
  
  export default DashboardHome;
  