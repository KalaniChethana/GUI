# ShopHub - Shop Management System

A full-stack e-commerce application built with React and Node.js for managing products, users, and orders with admin dashboard functionality.

## 📋 Table of Contents

- [Project Description](#project-description)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Installation](#installation)
- [Setup Instructions](#setup-instructions)
- [How to Run](#how-to-run)
- [Project Structure](#project-structure)
- [API Documentation](#api-documentation)

## 🎯 Project Description

ShopHub is a modern e-commerce platform that allows users to:
- Browse and shop products
- Create user accounts and manage profiles
- Admins can manage products and orders from a dedicated dashboard
- Secure authentication with JWT tokens
- Product image upload and management

## ✨ Features

### User Features
- User registration and login
- Browse products and shop
- View product details
- Responsive user dashboard
- Blog and contact pages
- Secure logout

### Admin Features
- Admin login and authentication
- Complete product management (Create, Read, Update, Delete)
- Product image uploads
- Admin dashboard with statistics
- User and order management

### General Features
- Responsive design (mobile, tablet, desktop)
- JWT-based authentication
- Role-based access control
- MySQL database integration
- RESTful API backend
- Modern UI with React Router

## 🛠 Tech Stack

### Frontend
- **React 18.3** - UI library
- **Vite 6.0** - Build tool
- **React Router DOM 7.3** - Client-side routing
- **Axios** - HTTP client
- **CSS3** - Styling

### Backend
- **Node.js & Express 4.21** - Server framework
- **MySQL 2.18** - Database
- **JWT** - Authentication
- **Bcryptjs** - Password encryption
- **Multer** - File upload handling
- **CORS** - Cross-origin requests

## 📦 Installation

### Prerequisites
- Node.js (v14 or higher)
- MySQL server
- npm or yarn

### Step 1: Clone the Project
```bash
cd d:\REACTJS
```

### Step 2: Install Dependencies
```bash
npm install
```

### Step 3: Setup Database
1. Open MySQL
2. Import the database:
   ```bash
   mysql -u root -p < shop_management.sql
   ```
3. Update database credentials in `backend/config/db.js`

### Step 4: Configure Environment Variables
Create a `.env` file in the root directory:
```
MYSQL_USER=root
MYSQL_PASSWORD=your_password
MYSQL_DATABASE=shop_management
MYSQL_HOST=localhost
JWT_SECRET=your_secret_key
PORT=5000
```

## 🚀 How to Run

### Option 1: Run Both Frontend & Backend (Recommended)

**Terminal 1 - Start Backend:**
```bash
node backend/server.js
```

**Terminal 2 - Start Frontend:**
```bash
npm run dev
```

The frontend will be available at `http://localhost:5173`
The backend runs on `http://localhost:5000`

### Option 2: Development Scripts
```bash
npm run dev      # Start Vite dev server (frontend)
npm run build    # Build for production
npm run lint     # Run ESLint
npm run preview  # Preview production build
```

## 📁 Project Structure

```
REACTJS/
├── backend/                    # Node.js backend server
│   ├── config/
│   │   └── db.js              # MySQL database configuration
│   ├── images/                # Uploaded product images
│   ├── routes/
│   │   ├── authRoutes.js      # Authentication endpoints
│   │   └── productRoutes.js   # Product management endpoints
│   └── server.js              # Express server entry point
│
├── src/                        # React frontend source
│   ├── components/            # Reusable React components
│   │   ├── AddProductModal.jsx
│   │   ├── Blog.jsx
│   │   ├── Contact.jsx
│   │   ├── Footer.jsx
│   │   ├── Header.jsx
│   │   ├── HomePage.jsx
│   │   ├── ShopPage.jsx
│   │   └── Navigation.jsx
│   │
│   ├── pages/                 # Page components
│   │   ├── AdminDashboard.jsx
│   │   ├── AdminHeader.jsx
│   │   ├── AdminLogin.jsx
│   │   ├── DashboardHome.jsx
│   │   ├── Login.jsx
│   │   ├── ProductTable.jsx
│   │   ├── Sidebar.jsx
│   │   ├── Signup.jsx
│   │   └── UserDashboard.jsx
│   │
│   ├── context/               # React Context API
│   │   └── AuthContext.jsx
│   │
│   ├── css/                   # CSS stylesheets
│   │   ├── admin-dashboard.css
│   │   ├── adminHeader.css
│   │   ├── login.css
│   │   └── signup.css
│   │
│   ├── style/                 # Global styles
│   │   ├── blog.css
│   │   ├── contact.css
│   │   ├── footer.css
│   │   ├── global.css
│   │   ├── header.css
│   │   ├── HomePage.css
│   │   ├── navigation.css
│   │   └── shop.css
│   │
│   ├── assets/                # Images and static assets
│   ├── App.jsx                # Main App component
│   ├── main.jsx               # React entry point
│   └── index.css              # Global CSS
│
├── public/                    # Static files
├── package.json              # Project dependencies
├── vite.config.js            # Vite configuration
├── eslint.config.js          # ESLint configuration
└── shop_management.sql       # Database schema

```

## 🔌 API Documentation

### Base URL
`http://localhost:5000/api`

### Authentication Endpoints

#### Register User
```
POST /auth/register
Content-Type: application/json

{
  "name": "John Doe",
  "email": "john@example.com",
  "password": "password123"
}

Response: { success: true, token: "jwt_token", user: {...} }
```

#### Login User
```
POST /auth/login
Content-Type: application/json

{
  "email": "john@example.com",
  "password": "password123"
}

Response: { success: true, token: "jwt_token", user: {...} }
```

#### Admin Login
```
POST /auth/admin-login
Content-Type: application/json

{
  "email": "admin@example.com",
  "password": "admin123"
}

Response: { success: true, token: "jwt_token", admin: {...} }
```

### Product Endpoints

#### Get All Products
```
GET /products
Response: { success: true, products: [...] }
```

#### Get Product by ID
```
GET /products/:id
Response: { success: true, product: {...} }
```

#### Create Product (Admin)
```
POST /products
Authorization: Bearer {token}
Content-Type: multipart/form-data

{
  "name": "Product Name",
  "price": 99.99,
  "description": "Product description",
  "image": <file>
}

Response: { success: true, product: {...} }
```

#### Update Product (Admin)
```
PUT /products/:id
Authorization: Bearer {token}
Content-Type: multipart/form-data

{
  "name": "Updated Name",
  "price": 129.99,
  "description": "Updated description",
  "image": <file> (optional)
}

Response: { success: true, message: "Product updated" }
```

#### Delete Product (Admin)
```
DELETE /products/:id
Authorization: Bearer {token}

Response: { success: true, message: "Product deleted" }
```

## 🔐 Authentication

- Uses JWT (JSON Web Tokens) for authentication
- Tokens are stored in localStorage on the client
- Include token in Authorization header: `Authorization: Bearer {token}`
- Passwords are encrypted using bcryptjs

## 🎨 Frontend Routes

| Path                   | Component        | Description               |
|------------------------|------------------|---------------------------|
| `/`                    | Login            | User login page           |
| `/signup`              | Signup           | User registration page    |
| `/admin-login`         | AdminLogin       | Admin login page          |
| `/home`                | HomePage         | Home page with navigation |
| `/shop`                | ShopPage         | Product catalog           |
| `/blog`                | Blog             | Blog page                 |
| `/contact`             | Contact          | Contact page              |
| `/user-dash`           | UserDashboard    | User dashboard            |
| `/admin/dashboard`     | AdminDashboard   | Admin dashboard           |
| `/admin/dashboardhome` | DashboardHome    | Admin home                |

## 📝 Environment Setup

Update `backend/config/db.js` with your MySQL credentials:
```javascript
const connection = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: 'your_password',
  database: 'shop_management'
});
```

## 🐛 Troubleshooting

**Database connection error:**
- Ensure MySQL is running
- Check database credentials in `backend/config/db.js`
- Make sure `shop_management` database exists

**Frontend won't load:**
- Check if backend is running on port 5000
- Clear browser cache and localStorage
- Ensure Node.js version is v14+

**CORS errors:**
- Backend CORS is configured to accept all origins
- Check if both frontend and backend are running

## 📄 License

This project is created for educational purposes.

---

**Happy coding!** 🚀
