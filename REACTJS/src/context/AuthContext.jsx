import { createContext, useContext, useState } from "react";
import axios from "axios";

const AuthContext = createContext();
export const useAuth = () => useContext(AuthContext);

export const AuthProvider = ({ children }) => {
  const [user, setUser] = useState(null);

  const login = async (email, password) => {
    try {
      const res = await axios.post("http://localhost:5000/api/auth/login", { email, password });
      localStorage.setItem("token", res.data.token);
      setUser({ email, role: res.data.role });
      return res.data.role;
    } catch {
      return null;
    }
  };

  return <AuthContext.Provider value={{ user, login }}>{children}</AuthContext.Provider>;
};
