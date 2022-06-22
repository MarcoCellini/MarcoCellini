import './App.css';

import Home from './pages/Home.js';
import Login from './pages/login.js';
import Logout from './pages/Logout.js';
import Myaccount from './pages/Myaccount.js';
import Profile from './pages/Profile.js';
import Register from './pages/Register.js';
import Header from './components/Header.js';
import Anagrafica from './pages/anagrafica';
import Altro from './pages/Altro';

import {BrowserRouter as Router, Route, Routes} from "react-router-dom";

function App() {
  return (
    <div className="App">
      <Router>
        <Header />
        <Routes>
          <Route path="/" element={<Login />} />
          <Route path="/home" element={<Home />} />
          <Route path="/anagrafica/altro" element={<Altro />} />
          <Route path="/login" element={<Login />} />
          <Route path="/logout" element={<Logout />} />
          <Route path="/myaccount" element={<Myaccount />} />
          <Route path="/profile" element={<Profile />} />
          <Route path="/register" element={<Register />} />
          <Route path="/anagrafica" element={<Anagrafica />} />
          
        </Routes>
      </Router>
    </div>
  );
}

export default App;