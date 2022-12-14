import { Navigate, Route, Routes } from "react-router-dom";
import Billing from "../pages/billing";
import CheckInOut from "../pages/checkInOut";
import DashBoard from "../pages/dashboard";
import Vehicles from "../pages/vehicles";
import CreateVehicle from "../pages/vehicles/create";
import UpdateVehicle from "../pages/vehicles/update";
import Welcome from "../pages/welcome";

const AppRoutes = () => (
  <Routes>
    <Route path="*" element={<Navigate to="/welcome" />} />
    <Route path="/welcome" element={<Welcome />} />
    <Route path="/dashboard" element={<DashBoard />} />
    <Route path="/billing" element={<Billing />} />
    <Route path="/vehicles" element={<Vehicles />} />
    <Route path="/vehicles/update" element={<UpdateVehicle />} />
    <Route path="/vehicles/create" element={<CreateVehicle />} />
    <Route path="/check" element={<CheckInOut />} />
  </Routes>
);

export default AppRoutes;
