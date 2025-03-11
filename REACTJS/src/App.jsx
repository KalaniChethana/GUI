// import { useState } from 'react'
// import reactLogo from './assets/react.svg'
// import viteLogo from '/vite.svg'
// import './App.css'

// function App() {
//   const [count, setCount] = useState(0)

//   return (
//     <>
//       <div>
//         <a href="https://vite.dev" target="_blank">
//           <img src={viteLogo} className="logo" alt="Vite logo" />
//         </a>
//         <a href="https://react.dev" target="_blank">
//           <img src={reactLogo} className="logo react" alt="React logo" />
//         </a>
//       </div>
//       <h1>Vite + React</h1>
//       <div className="card">
//         <button onClick={() => setCount((count) => count + 1)}>
//           count is {count}
//         </button>
//         <p>
//           Edit <code>src/App.jsx</code> and save to test HMR
//         </p>
//       </div>
//       <p className="read-the-docs">
//         Click on the Vite and React logos to learn more
//       </p>
//     </>
//   )
// }

// export default App

// import { useState } from 'react'
// import HomePage from './components/HomePage.jsx'

// function App() {
//   const [count, setCount] = useState(0)
//     return <HomePage />;
// }

// export default App;

import { BrowserRouter as Router, Routes, Route, BrowserRouter } from "react-router-dom";
import Login from "./pages/Login";
import AdminLogin from "./pages/AdminLogin";
import AdminDashboard from "./pages/AdminDashboard";
import UserDashboard from "./pages/UserDashboard";
import { AuthProvider } from "./context/AuthContext";
import HomePage from "./components/HomePage";
import Signup from "./pages/Signup";
import Shop from "./components/ShopPage";
import DashboardHome from "./pages/DashboardHome";
import Blog from "./components/Blog";
import Contact from "./components/Contact";

function App() {
  return (
    <AuthProvider>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Login />} />
          <Route path="/admin-login" element={<AdminLogin />} />
          <Route path="/user-dash" element={<UserDashboard />} />
          <Route path="/home" element={<HomePage />} />
          <Route path="/signup" element={<Signup />} />
          <Route path="/admin/dashboard" element={<AdminDashboard />} />
          <Route path="/admin/dashboardhome" element={<DashboardHome />} />
          <Route path="/shop" element={<Shop />} />
          <Route path="/blog" element={<Blog />} />
          <Route path="/contact" element={<Contact />} />
          
        </Routes>
      </BrowserRouter>
    </AuthProvider>
  );
}

export default App;



