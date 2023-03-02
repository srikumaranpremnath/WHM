import * as React from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import Axios from './AxiosConfig';
import { Component, useEffect, useState } from 'react'
import LocationOnIcon from '@mui/icons-material/LocationOn'; 
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import Modal from '@mui/material/Modal';
import TextField from '@mui/material/TextField';
import IRowData from '../Interface/IRowData'

const style = {
    position: 'absolute' as 'absolute',
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    minwidth: 300,
    maxWidth : 700,
    bgcolor: 'background.paper',
    border: '2px solid #000',
    boxShadow: 24,
    p: 4,
  };
export default function BasicTable() {
    const [rows, setRows] = useState<IRowData[]>();
    const [value] = useState(0);
    const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);
    useEffect(() => {
        Axios
            .get("WareHouse/get")
            .then((res) => {
                setRows(res.data);
                console.log(res.status)
            }).catch((error) => {
                console.log(error.data.code)
            })
    }, [value]);

    return (
        <div>
        <TableContainer component={Paper}>
            <Table sx={{ minWidth: 650 }} aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell align='center'>Name</TableCell>
                        <TableCell align='center'>Code</TableCell>
                        <TableCell align='center'>City</TableCell>
                        <TableCell align='center'>State</TableCell>
                        <TableCell align='center'>Location</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {rows?.map((item) => <TableRow
                        key={item.wareHouseId}
                        sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
                    >
                        <TableCell  align='center' component="th" scope="row">{item.wareHouseName}</TableCell>
                        <TableCell  align='center' component="th" scope="row">{item.wareHouseCode}</TableCell>
                        <TableCell  align='center' component="th" scope="row">{item.city}</TableCell>
                        <TableCell  align='center' component="th" scope="row">{item.state}</TableCell>
                        <TableCell  align='center' component="th" scope="row"><LocationOnIcon /></TableCell>
                    </TableRow>)}
                </TableBody>
            </Table>
        </TableContainer>
        
        <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <Typography id="modal-modal-title" variant="h6" component="h2">
            Create a new WareHouse
          </Typography>
          <Typography id="modal-modal-description" sx={{ mt: 4 }}>
           ------------------------------------------------------
          </Typography>
          <Box
      component="form"
      sx={{
        '& > :not(style)': { m: 1, width: '25ch' },
      }}
      noValidate
      autoComplete="off"
    >
      <TextField id="Name" label="Name" variant="outlined" />
      <TextField id="Code" label="Code" variant="outlined" />

      <TextField id="City" label="City" variant="outlined" />

      <TextField id="State" label="State" variant="outlined" />
      <TextField id="Latitude" label="Latitude" variant="outlined" />
      <TextField id="Longitude" label="Longitude" variant="outlined" />

    </Box>
        </Box>
        
      </Modal>
      <Button onClick={handleOpen}>Add a new wareHouse</Button>
        </div>
    );

    
}