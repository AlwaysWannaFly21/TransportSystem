import React from 'react';
import { useSearchParams } from 'react-router-dom'
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import style from './style.css'
import endpointService from '../../utilities/services/endpointService';

function RideRegisterPage() {
    const handleClick = () => {
        endpointService.rideRegisterPOST(searchParams.get('unitId'));
        window.location.href = `http://localhost:3000/Analytics?unitId=${searchParams.get('unitId')}`;
    };
    const [searchParams, setSearchParams] = useSearchParams()

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
                LMS
            </Typography>
            <Typography
                onClick={handleClick}
                component={'welcomeButton'}
                mt={15}
                variant="h6"
            >
                Register
            </Typography>
        </Box>
    );
}

export default RideRegisterPage;