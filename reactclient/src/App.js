import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Navbar from './components/Navbar';
import RideHistory from './pages/RideHistory'
import StationTimetable from './pages/StationTimetable';
import WelcomePage from './pages/WelcomePage'


function App() {
  return (
    <>
     <Navbar/>
     <BrowserRouter>
            <Routes>
                <Route path="/WelcomePage" element={<WelcomePage />} /> 
                <Route path="/RideHistory" element={<RideHistory />} />
                {/* <Route path="/StationTimetable" element={<StationTimetable />} /> */}
            </Routes>
        </BrowserRouter>
    </>
   
    
  );
}

export default App;
