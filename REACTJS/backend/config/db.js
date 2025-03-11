import mysql from 'mysql';
import dotenv from 'dotenv';

dotenv.config();  // ✅ Ensure this is at the top

const db = mysql.createConnection({
  host: process.env.DB_HOST,
  user: process.env.DB_USER || 'root',  // Default to 'root' if empty
  password: process.env.DB_PASS || '',  // Default to empty string if undefined
  database: process.env.DB_NAME || 'shop_management'
});

db.connect(err => {
  if (err) {
    console.error('❌ DB Connection Error:', err);
    return;
  }
  console.log('✅ Connected to MySQL!');
});

export default db;
