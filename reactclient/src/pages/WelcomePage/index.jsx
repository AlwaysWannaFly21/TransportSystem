import React from 'react';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';


const WelcomePage = () => {
    // const handleClick = () => {
    //     window.location.replace(FrontConstants.API_URL_SIGN_IN);
    // };

    return (
        <Box
            display="flex"
            justifyContent="center"
            alignItems="center"
            minHeight="100vh"
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
                LMS
            </Typography>
            <Typography
                //onClick={handleClick}
                component={'welcomeButton'}
                mt={15}
                variant="h6"
            >
                Start your learning
            </Typography>
        </Box>
    );
};
export default WelcomePage;
