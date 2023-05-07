import { React, useCallback, useEffect, useState } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper } from '@mui/material';
import endpointService from '../../utilities/services/endpointService';

function UserTicketHistory() {
  
    const [ticketHistoryList, setTicketHistoryList] = useState([]);

    
    const fetchHistory = useCallback( async () => {
        const historyList = await endpointService.userTicketHistoryGET();
        console.log(historyList)
        setTicketHistoryList(historyList.data);
    },[])

    useEffect(() => {
        fetchHistory();
    }, []);

  return (
    ticketHistoryList.length && 
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
          {ticketHistoryList.map((row) => (
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

export default UserTicketHistory;