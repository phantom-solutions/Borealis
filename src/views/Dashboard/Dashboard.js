import React from 'react';
import { makeStyles } from '@material-ui/styles';
import { Grid, Typography } from '@material-ui/core';
import { CircularProgressbar } from 'react-circular-progressbar';
import 'react-circular-progressbar/dist/styles.css';
import './custom.css';

import {
  Budget,
  TotalUsers,
  TasksProgress,
  TotalProfit,
  LatestSales,
  UsersByDevice,
  LatestOrders
} from './components';

const useStyles = makeStyles(theme => ({
  root: {
    padding: theme.spacing(2)
  }
}));

const MEMORYCircle = 40;
const DISKCircle = 50;
const CPUCircle = 34;
const NETWORKCircle = 20;

const Dashboard = () => {
  const classes = useStyles();

  return (
    <div className={classes.root}>

<Grid
  container
  direction="row"
  justify="space-evenly"
  alignItems="center"
>
			    <Grid
          item
          lg={1}
          sm={1}
          xl={1}
          xs={1}
        >
<CircularProgressbar
            value={MEMORYCircle}
            text={`${MEMORYCircle}%`}
            circleRatio={0.75}  /* Make the circle only 0.75 of the full diameter */
            styles={{
              trail: {
                strokeLinecap: 'butt',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              path: {
                strokeLinecap: 'butt',
                stroke: '#49B580',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              text: {
                fill: '#49B580',
              }
            }} />
  <Typography variant="subtitle2" component="" align="center" variant="body1">
    Memory Usage
  </Typography>
        </Grid>
        <Grid
          item
          lg={1}
          sm={1}
          xl={1}
          xs={1}
        >
<CircularProgressbar
            value={DISKCircle}
            text={`${DISKCircle}%`}
            circleRatio={0.75}  /* Make the circle only 0.75 of the full diameter */
            styles={{
              trail: {
                strokeLinecap: 'butt',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              path: {
                strokeLinecap: 'butt',
                stroke: '#49B580',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              text: {
                fill: '#49B580',
              }
            }} />
  <Typography variant="subtitle2" component="" align="center" variant="body1">
    Disk Usage
  </Typography>
        </Grid>
        <Grid
          item
          lg={1}
          sm={1}
          xl={1}
          xs={1}
        >
<CircularProgressbar
            value={CPUCircle}
            text={`${CPUCircle}%`}
            circleRatio={0.75}  /* Make the circle only 0.75 of the full diameter */
            styles={{
              trail: {
                strokeLinecap: 'butt',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              path: {
                strokeLinecap: 'butt',
                stroke: '#49B580',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              text: {
                fill: '#49B580',
              }
            }} />
  <Typography variant="subtitle2" component="" align="center" variant="body1">
    CPU Usage
  </Typography>
        </Grid>
        <Grid
          item
          lg={1}
          sm={1}
          xl={1}
          xs={1}
        >
<CircularProgressbar
            value={NETWORKCircle}
            text={`${NETWORKCircle}%`}
            circleRatio={0.75}  /* Make the circle only 0.75 of the full diameter */
            styles={{
              trail: {
                strokeLinecap: 'butt',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              path: {
                strokeLinecap: 'butt',
                stroke: '#49B580',
                transform: 'rotate(-135deg)',
                transformOrigin: 'center center',
              },
              text: {
                fill: '#49B580',
              }
            }} />
  <Typography variant="subtitle2" component="" align="center" variant="body1">
    Network Usage
  </Typography>
</Grid>
</Grid>
<br></br>
          <grid
            container
            spacing={4}
            >  
			    <Grid
          item
          lg={12}
          md={12}
          xl={9}
          xs={12}
        >
          <LatestOrders />
        </Grid><br></br>
        <Grid
          item
          lg={4}
          md={6}
          xl={3}
          xs={12}
        >
          <UsersByDevice />
        </Grid>
      </grid>
      <Grid
        container
        spacing={4}
      >
        <Grid
          item
          lg={3}
          sm={6}
          xl={3}
          xs={12}
        >
          <Budget />
        </Grid>
        <Grid
          item
          lg={3}
          sm={6}
          xl={3}
          xs={12}
        >
          <TotalUsers />
        </Grid>
        <Grid
          item
          lg={3}
          sm={6}
          xl={3}
          xs={12}
        >
          <TasksProgress />
        </Grid>
        <Grid
          item
          lg={3}
          sm={6}
          xl={3}
          xs={12}
        >
          <TotalProfit />
        </Grid>
        <Grid
          item
          lg={8}
          md={12}
          xl={9}
          xs={12}
        >
          <LatestSales />
        </Grid>
      </Grid>
    </div>
  );
};

export default Dashboard;
