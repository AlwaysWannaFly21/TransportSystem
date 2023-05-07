import { React, useCallback, useEffect, useState } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper } from '@mui/material';
import endpointService from '../../utilities/services/endpointService';

function createData(time, unitNumber, roadName) {
  return { time, unitNumber, roadName };
}

function RideHistory() {
  
    const [rideHistoryList, setRideHistoryList] = useState([]);

    
    const fetchHistory = useCallback( async () => {
        const history = await endpointService.rideRegisterGET(1);
        console.log(history)
        setRideHistoryList(history.data);
    },[])

    useEffect(() => {
        fetchHistory();
    }, []);

  return (
    rideHistoryList.length && 
    <TableContainer component={Paper}>
      <Table aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell align="center">Time</TableCell>
            <TableCell align="center">Unit Number</TableCell>
            <TableCell align="center">Road Name</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {rideHistoryList.map((row) => (
            <TableRow key={row.unitNumber}>
              <TableCell align="center">{row.time}</TableCell>
              <TableCell align="center">{row.unitNumber}</TableCell>
              <TableCell align="center">{row.roadName}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}

export default RideHistory;