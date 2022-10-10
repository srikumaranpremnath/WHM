import ReactDOM from "react-dom";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import LandingPage from "./LandingPage";
import Navbar from "./Navbar";
import WareHouseUnits from "./WareHouseUnits";

export default function WHMRoutes() {
    return (
      <BrowserRouter>
        <Routes>
          {/* <Route path="/" element={<Navbar />}> */}
            <Route  path="/" element={<LandingPage />} />
            <Route path="Units" element={<WareHouseUnits />} />
          {/* </Route> */}
        </Routes>
      </BrowserRouter>
    );
  }
  
