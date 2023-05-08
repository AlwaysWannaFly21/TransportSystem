import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Navbar from './components/Navbar';
import RideHistory from './pages/RideHistory'
import StationTimetable from './pages/StationTimetable';
import WelcomePage from './pages/WelcomePage'
import UserTicketHistory from './pages/UserTicketHistory';
import SignIn from './pages/SignIn';
import SignUp from './pages/SignUp';


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
                <Route path="/SignIn" element={<SignIn />} /> 
                <Route path="/SignUp" element={<SignUp />} /> 
            </Routes>
        </BrowserRouter>
    </>
   
    
  );
}

export default App;
