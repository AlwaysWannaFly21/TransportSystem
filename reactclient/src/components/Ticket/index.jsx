import * as React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea } from '@mui/material';

export default function Ticket({number , roadName, date }) {
  return (
    <Card  sx={{ maxWidth: 200 }}>
      <CardActionArea>
        <CardMedia
          component="img"
          height="140"
          image="https://w0.peakpx.com/wallpaper/359/315/HD-wallpaper-mercedes-benz-ecitaro-2020-city-bus-exterior-electric-bus-german-buses-passenger-transport-passenger-transportation-mercedes-benz-buses-for-with-resolution-high-quality.jpg"
          alt="bus"
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            {number}
          </Typography>
          <Typography gutterBottom variant="h6" component="div">
            {roadName}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            {date}
          </Typography>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}