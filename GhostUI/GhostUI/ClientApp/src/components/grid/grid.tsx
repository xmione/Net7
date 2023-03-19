import * as React from 'react';
import { DataGrid, type GridRowsProp, type GridColDef } from '@mui/x-data-grid';


const DisplayGrid = (props: any) => {
    /*
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

    */

    const rows: GridRowsProp = props.data;
    const columns: GridColDef[] = [
        { field: 'id', headerName: 'ID', width: 25 },
        { field: 'startBlock', headerName: 'Start Block', width: 150 },
        { field: 'endBlock', headerName: 'End Block', width: 150 },
        { field: 'signalledTokens', headerName: 'Signalled Tokens', width: 150 },
        { field: 'stakeDeposited', headerName: 'Stake Deposited', width: 150 },
        { field: 'totalQueryFees', headerName: 'Total Query Fees', width: 150 },
        { field: 'taxedQueryFees', headerName: 'Taxed Query Fees', width: 150 },
        { field: 'queryFeesCollected', headerName: 'Query Fees Collected', width: 150 },
        { field: 'curatorQueryFees', headerName: 'Curator Query Fees', width: 150 },
        { field: 'queryFeeRebates', headerName: 'Query Fee Rebates', width: 150 },
        { field: 'totalRewards', headerName: 'Total Rewards', width: 150 },
        { field: 'totalIndexerRewards', headerName: 'Total Indexer Rewards', width: 150 },
        { field: 'totalDelegatorRewards', headerName: 'Total Delegator Rewards', width: 150 },
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