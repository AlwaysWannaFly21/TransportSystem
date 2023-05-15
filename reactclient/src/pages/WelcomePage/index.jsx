import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import { useNavigate } from "react-router-dom";


const WelcomePage = () => {
    // const handleClick = () => {
    //     window.location.replace(FrontConstants.API_URL_SIGN_IN);
    // };

    const navigate = useNavigate();
    return (
        <Box
        display="flex"
        justifyContent="center"
        alignItems="center"
        minHeight="100vh"
        backgroundColor="rgb(23, 141, 191)"
    >
        <Typography
            variant="h1"
            mb={20}
            noWrap
            sx={{
                fontWeight: 800,
                color: 'white',
            }}
        >
            Welcome traveller!
        </Typography>
        <Typography
            onClick={() => {
                navigate("/SignUp")
            }}
            component={'welcomeButton'}
            mt={15}
            variant="h6"
        >
            Getting started!
        </Typography>
    </Box>
    );
};
export default WelcomePage;
