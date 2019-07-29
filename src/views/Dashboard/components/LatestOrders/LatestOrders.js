import React, { useState } from 'react';
import clsx from 'clsx';
import PerfectScrollbar from 'react-perfect-scrollbar';
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/styles';
import {
  Card,
  CardActions,
  CardHeader,
  CardContent,
  Button,
  Divider,
  Table,
  TableBody,
  TableCell,
  TableHead,
  TableRow,
  Tooltip,
  TableSortLabel
} from '@material-ui/core';
import ArrowRightIcon from '@material-ui/icons/ArrowRight';

import mockData from './data';
import { StatusBullet } from 'components';

const useStyles = makeStyles(theme => ({
  root: {},
  content: {
    padding: 0
  },
  inner: {
    minWidth: 800
  },
  statusContainer: {
    display: 'flex',
    alignItems: 'center'
  },
  status: {
    marginRight: theme.spacing(1)
  },
  actions: {
    justifyContent: 'flex-end'
  }
}));

const statusColors = {
  Running: 'success',
  Starting: 'info',
  Stopping: 'danger',
  Stopped: 'danger'
};

const LatestOrders = props => {
  const { className, ...rest } = props;

  const classes = useStyles();

  const [server_data] = useState(mockData);

  return (
    <Card
      {...rest}
      className={clsx(classes.root, className)}
    >
      <CardHeader
        title="Server Performance Dashboard"
      />
      <Divider />
      <CardContent className={classes.content}>
        <PerfectScrollbar>
          <div className={classes.inner}>
            <Table>
              <TableHead>
                <TableRow>
                  <TableCell>Friendly Server Name</TableCell>
                  <TableCell>Server Type</TableCell>
                  <TableCell>Memory Usage</TableCell>
                  <TableCell>Disk Usage</TableCell>
                  <TableCell>CPU Usage</TableCell>
                  <TableCell>Network Usage</TableCell>
                  <TableCell>Auto-Restart</TableCell>
                  <TableCell>Status</TableCell>
                </TableRow>
              </TableHead>
              <TableBody>
                {server_data.map(server_data => (
                  <TableRow
                    hover
                    key={server_data.id}
                  >
                    <TableCell><a href="">{server_data.SERVER_name_friendly}</a></TableCell>
                    <TableCell>{server_data.SERVER_type}</TableCell>
                    <TableCell>{server_data.MEMORY_Usage}</TableCell>
                    <TableCell>{server_data.DISK_Usage}</TableCell>
                    <TableCell>{server_data.CPU_Usage}</TableCell>
                    <TableCell>{server_data.NETWORK_Usage}</TableCell>
                    <TableCell>{server_data.SERVER_auto_restart}</TableCell>
                    <TableCell>
                      <div className={classes.statusContainer}>
                        <StatusBullet
                          className={classes.status}
                          color={statusColors[server_data.status]}
                          size="sm"
                        />
                        {server_data.status}
                      </div>
                    </TableCell>
                  </TableRow>
                ))}
              </TableBody>
            </Table>
          </div>
        </PerfectScrollbar>
      </CardContent>
      <Divider />
      <CardActions className={classes.actions}>
        <Button
          color="primary"
          size="small"
          variant="text"
        >
          View all <ArrowRightIcon />
        </Button>
      </CardActions>
    </Card>
  );
};

LatestOrders.propTypes = {
  className: PropTypes.string
};

export default LatestOrders;
