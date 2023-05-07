import { React, useEffect, useState } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper } from '@mui/material';
import endpointService from '../../utilities/services/endpointService';

function StationTimetable() {
  
    const [stationTimeTable, setstationTimeTable] = useState([]);

    const fetchStationTimetables = async () => {
        const resp = await endpointService.stationTimetableGET(1);
        console.log(resp)
        setstationTimeTable(resp.data);
    }

    useEffect(() => {
        fetchStationTimetables();
    }, []);

  return (
    stationTimeTable && 
    <TableContainer component={Paper}>
      <Table aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell align="center">Unit</TableCell>
            <TableCell align="center">Time</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {stationTimeTable.map((row) => (
            <TableRow key={row.unitNumber}>
              <TableCell align="center">{row.transportUnitId}</TableCell>
              <TableCell align="center">{row.arrivalTime}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}

export default StationTimetable;