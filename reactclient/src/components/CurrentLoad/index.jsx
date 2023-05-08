import * as React from 'react';
import Link from '@mui/material/Link';
import Typography from '@mui/material/Typography';
import Title from '../Title';
import CurrentTime from '../CurrentTime';

function preventDefault(event) {
  event.preventDefault();
}

export default function CurrentLoad({count}) {
    
  return (
    <React.Fragment>
      <Title>Current Load</Title>
      <Typography component="p" variant="h4">
        {count}
      </Typography>
      <Typography variant="h5" color="text.secondary" sx={{ flex: 1 }}>
        <CurrentTime/>
      </Typography>
      <div>
        <Link color="primary" href="#" onClick={preventDefault}>
          View balance
        </Link>
      </div>
    </React.Fragment>
  );
}