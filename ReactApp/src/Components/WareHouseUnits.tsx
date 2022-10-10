import Axios from './AxiosConfig';
import React, { Component, useEffect, useState } from 'react'
import DataTable, { createTheme } from 'react-data-table-component';
import { IUnit } from '../Interface/IUnits';
import '../Stylesheets/UnitTable.css'
export default function WHMRoutes() {
    const [units, setUnits] = useState([]);
    const [value] = useState(0);
    const [isFetching, setIsFetching] = useState(false);
    useEffect(() => {
        setIsFetching(true);
        Axios
            .get("WareHouse/get")
            .then((res) => {
                setUnits(res.data);
                setIsFetching(false);
            }).catch(() => {
                setIsFetching(false);
            })
    }, [value]

    );

    createTheme('solarized', {
        text: {
            primary: '#268bd2',
            secondary: '#2aa198',
        },
        background: {
            default: '#002b36',
        },
        context: {
            background: '#cb4b16',
            text: '#FFFFFF',
        },
        divider: {
            default: '#073642',
        },
        action: {
            button: 'rgba(0,0,0,.54)',
            hover: 'rgba(0,0,0,.08)',
            disabled: 'rgba(0,0,0,.12)',
        },
    }, 'dark');

    function ViewMap(latitude : number,longitude : number){
        alert(latitude+" "+ longitude+" "+"Todo : display map");
    }
    const columns = [
        {
            name: 'Id',
            selector: (row: IUnit) => row.wareHouseId,
        },
        {
            name: 'Name',
            selector: (row: IUnit) => row.wareHouseName,
        },
        {
            name: 'City',
            selector: (row: IUnit) => row.city,
        },
        {
            name: 'State',
            selector: (row: IUnit) => row.state,
        },
        {
            name: 'Country',
            selector: (row: IUnit) => row.country,
        },
        {
            name: 'Latitude',
            selector: (row: IUnit) => row.latitude,
        },
        {
            name: 'Longitude',
            selector: (row: IUnit) => row.longitude,
        },
        {
            name : 'Location',
            button: true,
        }

    ];





    return (<div>
        <h1> Ware house data</h1>
        <DataTable className='table'
            columns={columns}
            data={units}
            progressPending={isFetching}
            responsive={true}
            pagination
            fixedHeader={true}
            highlightOnHover
            pointerOnHover
            theme="dark"
        />
    </div>);
}
