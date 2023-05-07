import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Navbar from './components/Navbar';
import RideHistory from './pages/RideHistory'
import StationTimetable from './pages/StationTimetable';
import WelcomePage from './pages/WelcomePage'
import UserTicketHistory from './pages/UserTicketHistory';


function App() {
  return (
    <>
     <Navbar/>
     <BrowserRouter>
            <Routes>
                <Route path="/WelcomePage" element={<WelcomePage />} /> 
                <Route path="/RideHistory" element={<RideHistory />} />
                <Route path="/StationTimetable" element={<StationTimetable />} /> 
                <Route path="/UserTicketHistory" element={<UserTicketHistory />} /> 
            </Routes>
        </BrowserRouter>
    </>
   
    
  );
}

export default App;
