import * as React from 'react';
import { DataGrid, type GridRowsProp, type GridColDef } from '@mui/x-data-grid';


const DisplayGrid = (props:any) =>{
    //id
    //emailaddresses
    //deliveryAddress
    //billingAddress
    //workPhone
    //homePhone
    //mobilePhone
    const rows: GridRowsProp = props.data;
    const columns: GridColDef[] = [
        { field: 'id', headerName: 'ID', width: 25 },
        { field: 'emailaddresses', headerName: 'Email Addresses', width: 150 },
        { field: 'deliveryAddress', headerName: 'Delivery Address', width: 150 },
        { field: 'billingAddress', headerName: 'Billing Address', width: 150 },
        { field: 'workPhone', headerName: 'Work Phone', width: 150 },
        { field: 'homePhone', headerName: 'Home Phone', width: 150 },
        { field: 'mobilePhone', headerName: 'Mobile Phone', width: 150 },
    ];

    //Note: Editing is not part of the specs so I'll not include these lines of codes for now.
    //experimentalFeatures={{ newEditingApi: true }}
    //editMode = "row"

    return (
        <div style={{ height: 800, width: '100%' }}>
            <DataGrid
                rows={rows}
                columns={[...columns, { field: 'id', filterable: false }]}
                initialState={{
                    columns: {
                        columnVisibilityModel: {
                            // Hide column id, the other columns will remain visible
                            id: false,
                        },
                    },
                }}
                sx={{
                    backgroundColor: 'white',
                    boxShadow: 2,
                    border: 2,
                    borderColor: 'primary.light',
                    '& .MuiDataGrid-cell:hover': {
                        color: 'primary.main',
                    },
                }}
                
            />
        </div>
    );
}


export default DisplayGrid;