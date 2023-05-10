import * as React from 'react';
import Link from '@mui/material/Link';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Title from '../Title';

// Generate Order Data
function preventDefault(event) {
  event.preventDefault();
}

export default function Registrations({humanList}) {

    function normalizeDateTime(dateTimeString) {
        const dateObj = new Date(dateTimeString);
        const day = dateObj.getDate().toString().padStart(2, '0');
        const month = (dateObj.getMonth() + 1).toString().padStart(2, '0');
        const year = dateObj.getFullYear().toString();
        const hours = dateObj.getHours().toString().padStart(2, '0');
        const minutes = dateObj.getMinutes().toString().padStart(2, '0');
        return `${day}.${month}.${year} ${hours}:${minutes}`;
      }

  return (
    <React.Fragment>
      <Title>User History</Title>
      <Table size="small">
        <TableHead>
          <TableRow>
            <TableCell>GUID</TableCell>
            <TableCell>Name</TableCell>
            <TableCell>Surname</TableCell>
            <TableCell>Registred At</TableCell>
            <TableCell>Expires At</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {humanList.map((row) => (
            <TableRow key={row.humanGuid}>
                {Object.values({...row, registredAt:normalizeDateTime(row.registredAt), expiredAt:normalizeDateTime(row.expiredAt)}).map((cell)=><TableCell>{cell}</TableCell>)}
            </TableRow>
          ))}
        </TableBody>
      </Table>
      <Link color="primary" href="#" onClick={preventDefault} sx={{ mt: 3 }}>
        See more orders
      </Link>
    </React.Fragment>
  );
}