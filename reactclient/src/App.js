import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Navbar from './pages/Navbar';


function App() {
  return (
    <>
     <Navbar/>
     <BrowserRouter>
            <Routes>
                {/* <Route exact path="/WelcomePage" element={<WelcomePage />} /> */}
            </Routes>
        </BrowserRouter>
    </>
   
    
  );
}

export default App;
