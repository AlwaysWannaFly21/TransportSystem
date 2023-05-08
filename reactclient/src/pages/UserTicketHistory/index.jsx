import { React, useCallback, useEffect, useState } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper } from '@mui/material';
import endpointService from '../../utilities/services/endpointService';
import Ticket from '../../components/Ticket';
import { Box } from '@mui/material';

function UserTicketHistory() {
  
    const [ticketHistoryList, setTicketHistoryList] = useState([]);

    
    const fetchHistory = async () => {
        const historyList = await endpointService.userTicketHistoryGET();
        console.log("From UserTicketHistory: ", historyList)
        setTicketHistoryList(historyList.data);
    }

    function normalizeDateTime(dateTimeString) {
        const dateObj = new Date(dateTimeString);
        const day = dateObj.getDate().toString().padStart(2, '0');
        const month = (dateObj.getMonth() + 1).toString().padStart(2, '0');
        const year = dateObj.getFullYear().toString();
        const hours = dateObj.getHours().toString().padStart(2, '0');
        const minutes = dateObj.getMinutes().toString().padStart(2, '0');
        return `${day}.${month}.${year} ${hours}:${minutes}`;
      }

    useEffect(() => {
        fetchHistory();
    }, []);

    return (
        <Box sx={{ display: 'grid', gap: '20px', gridTemplateColumns: {lg: 'repeat(5, auto)', md: 'repeat(4, auto)', sm: 'repeat(3, auto)', xs: 'repeat(2, auto)'}, justifyItems: 'center', width:'fit-content', margin: '25px auto'}}>
          {ticketHistoryList.map((list) => (
            <Ticket 
              roadName={list.routeName}
              number={list.transportUnitId}
              date={ normalizeDateTime(list.readingTime)}
            />
          ))}
        </Box>
      );
}

export default UserTicketHistory;