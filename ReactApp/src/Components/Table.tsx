export default class num {

}
// import React, { useMemo } from "react";
// import { IUnit } from "../Interface/IUnits";
// import { useTable } from "react-table";
// type Props = {
//     data: IUnit[];
// };

// const columns = [
//     {
//         Header: "WareHouse Id",
//         accessor: "wareHouseId"
//     },
//     {
//         Header: "Name",
//         accessor: "wareHouseName"
//     },
//     {
//         Header: "Code",
//         accessor: "wareHouseCode"
//     },
//     {
//         Header: "City",
//         accessor: "city"
//     },
//     {
//         Header: "State",
//         accessor: "country"
//     },
   
// ];

// function Table(props: Props) {
//     const data = useMemo(() => props.data, [props.data]);
//     const {
//         getTableProps,
//         getTableBodyProps,
//         headerGroups,
//         rows,
//         prepareRow
//     } = useTable({ columns, data });
// }