import express from 'express';
import cors from 'cors';
import bodyParser from 'body-parser';
import authRoutes from './routes/authRoutes.js';
import productRoutes from './routes/productRoutes.js';
import multer from 'multer';
import path from 'path';
import { fileURLToPath } from 'url';
import dotenv from 'dotenv';

dotenv.config();

const corsOptions ={
  origin:'*', 
  credentials:true,
  optionSuccessStatus:200,
}

const app = express();
app.use(cors()) 
app.use(express.json());
app.use(bodyParser.json());
app.use(cors(corsOptions)) 


// Get the current directory
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// Multer storage configuration
const storage = multer.diskStorage({
  destination: (req, file, cb) => {
    console.log(req);
    cb(null, "images");
  },
  filename: (req, file, cb) => {
    cb(null, req.body.name);
  },
});

const upload = multer({ storage: storage });
app.post("/api/upload", upload.single("image"), (req, res) => {
  console.log(req.file); // Check the file object
  res.status(200).json("File has been uploaded");
});

// Use 'image' instead of 'file' in the PUT request as well
const update = multer({ storage: storage });
app.put("/api/update", update.single("image"), (req, res) => {
  res.status(200).json("File has been updated");
});

// Serve images directory
app.use("/images", express.static(path.join(__dirname, "/images")));

// Routes
app.use('/api/auth', authRoutes);
app.use('/api/products', productRoutes);

app.listen(5000, () => console.log("Server running on http://127.0.0.1:5000"));
