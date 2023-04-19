import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Navbar from './components/Navbar';
import RideHistory from './pages/RideHistory'


function App() {
  return (
    <>
     <Navbar/>
     <BrowserRouter>
            <Routes>
                {/* <Route exact path="/WelcomePage" element={<WelcomePage />} /> */}
                <Route exact path="/RideHistory" element={<RideHistory />} />
            </Routes>
        </BrowserRouter>
    </>
   
    
  );
}

export default App;
