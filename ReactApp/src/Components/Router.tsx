import ReactDOM from "react-dom";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import LandingPage from "./LandingPage";
import Navbar from "./Navbar";
import WareHouseUnits from "./WareHouseUnits";
import BasicTable from "./Table";
import AppBar from './AppBar'

export default function WHMRoutes() {
    return (
      <BrowserRouter>
         <AppBar />

        <Routes>
            <Route  path="/" element={<LandingPage />} />
            <Route  path="/Home" element={<LandingPage />} />
            <Route path="/Units" element={<BasicTable />} />
        </Routes>
      </BrowserRouter>
    );
  }
  
