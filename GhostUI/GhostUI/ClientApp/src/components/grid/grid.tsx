//import * as React from 'react';
//import { DataGrid, type GridRowsProp, type GridColDef } from '@mui/x-data-grid';

import * as React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import AddIcon from '@mui/icons-material/Add';
import EditIcon from '@mui/icons-material/Edit';
import DeleteIcon from '@mui/icons-material/DeleteOutlined';
import SaveIcon from '@mui/icons-material/Save';
import CancelIcon from '@mui/icons-material/Close';
import {
    type GridRowsProp,
    type GridRowModesModel,
    GridRowModes,
    DataGridPro,
    type GridColDef,
    type GridRowParams,
    type MuiEvent,
    GridToolbarContainer,
    GridActionsCellItem,
    type GridEventListener,
    type GridRowId,
    type GridRowModel,
} from '@mui/x-data-grid-pro';
import {
    randomCreatedDate,
    randomTraderName,
    randomUpdatedDate,
    randomId,
} from '@mui/x-data-grid-generator';



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

    const initialRows: GridRowsProp = props.data;
    

    interface EditToolbarProps {
        setRows: (newRows: (oldRows: GridRowsProp) => GridRowsProp) => void;
        setRowModesModel: (
            newModel: (oldModel: GridRowModesModel) => GridRowModesModel,
        ) => void;
    }

    function EditToolbar(props: EditToolbarProps) {
        const { setRows, setRowModesModel } = props;

        const handleClick = () => {
            const id = randomId();
            setRows((oldRows) => [...oldRows, { id, isNew: true }]);
            setRowModesModel((oldModel) => ({
                ...oldModel,
                [id]: { mode: GridRowModes.Edit, fieldToFocus: 'startBlock' },
            }));
        };

        return (
            <GridToolbarContainer>
                <Button color="primary" startIcon={<AddIcon />} onClick={handleClick}>
                    Add record
                </Button>
            </GridToolbarContainer>
        );
    }

    function FullFeaturedCrudGrid() {
        const [rows, setRows] = React.useState(initialRows);
        const [rowModesModel, setRowModesModel] = React.useState<GridRowModesModel>({});

        const handleRowEditStart = (
            params: GridRowParams,
            event: MuiEvent<React.SyntheticEvent>,
        ) => {
            event.defaultMuiPrevented = true;
        };

        const handleRowEditStop: GridEventListener<'rowEditStop'> = (params, event) => {
            event.defaultMuiPrevented = true;
        };

        const handleEditClick = (id: GridRowId) => () => {
            setRowModesModel({ ...rowModesModel, [id]: { mode: GridRowModes.Edit } });
        };

        const handleSaveClick = (id: GridRowId) => () => {
            setRowModesModel({ ...rowModesModel, [id]: { mode: GridRowModes.View } });
        };

        const handleDeleteClick = (id: GridRowId) => () => {
            setRows(rows.filter((row) => row.id !== id));
        };

        const handleCancelClick = (id: GridRowId) => () => {
            setRowModesModel({
                ...rowModesModel,
                [id]: { mode: GridRowModes.View, ignoreModifications: true },
            });

            const editedRow = rows.find((row) => row.id === id);
            if (editedRow!.isNew) {
                setRows(rows.filter((row) => row.id !== id));
            }
        };

        const processRowUpdate = (newRow: GridRowModel) => {
            const updatedRow = { ...newRow, isNew: false };
            setRows(rows.map((row) => (row.id === newRow.id ? updatedRow : row)));
            return updatedRow;
        };

        const handleRowModesModelChange = (newRowModesModel: GridRowModesModel) => {
            setRowModesModel(newRowModesModel);
        };

        const columns: GridColDef[] = [
            {
                field: 'actions',
                type: 'actions',
                headerName: 'Actions',
                width: 100,
                cellClassName: 'actions',
                getActions: ({ id }) => {
                    const isInEditMode = rowModesModel[id]?.mode === GridRowModes.Edit;

                    if (isInEditMode) {
                        return [
                            <GridActionsCellItem
                                icon={<SaveIcon />}
                                label="Save"
                                onClick={handleSaveClick(id)}
                            />,
                            <GridActionsCellItem
                                icon={<CancelIcon />}
                                label="Cancel"
                                className="textPrimary"
                                onClick={handleCancelClick(id)}
                                color="inherit"
                            />,
                        ];
                    }

                    return [
                        <GridActionsCellItem
                            icon={<EditIcon />}
                            label="Edit"
                            className="textPrimary"
                            onClick={handleEditClick(id)}
                            color="inherit"
                        />,
                        <GridActionsCellItem
                            icon={<DeleteIcon />}
                            label="Delete"
                            onClick={handleDeleteClick(id)}
                            color="inherit"
                        />,
                    ];
                },
            },
            
            { field: 'startBlock', headerName: 'Start Block', width: 150, editable: true },
            { field: 'endBlock', headerName: 'End Block', width: 150, editable: true },
            { field: 'signalledTokens', headerName: 'Signalled Tokens', width: 150, editable: true },
            { field: 'stakeDeposited', headerName: 'Stake Deposited', width: 150, editable: true },
            { field: 'totalQueryFees', headerName: 'Total Query Fees', width: 150, editable: true },
            { field: 'taxedQueryFees', headerName: 'Taxed Query Fees', width: 150, editable: true },
            { field: 'queryFeesCollected', headerName: 'Query Fees Collected', width: 150, editable: true },
            { field: 'curatorQueryFees', headerName: 'Curator Query Fees', width: 150, editable: true },
            { field: 'queryFeeRebates', headerName: 'Query Fee Rebates', width: 150, editable: true },
            { field: 'totalRewards', headerName: 'Total Rewards', width: 150, editable: true },
            { field: 'totalIndexerRewards', headerName: 'Total Indexer Rewards', width: 150 },
            { field: 'totalDelegatorRewards', headerName: 'Total Delegator Rewards', width: 150 },
            
        ];

        return (
            <Box
                sx={{
                    height: 500,
                    width: '100%',
                    '& .actions': {
                        color: 'text.secondary',
                    },
                    '& .textPrimary': {
                        color: 'text.primary',
                    },
                }}
            >
                <DataGridPro
                    rows={rows}
                    columns={columns}
                    editMode="row"
                    rowModesModel={rowModesModel}
                    onRowModesModelChange={handleRowModesModelChange}
                    onRowEditStart={handleRowEditStart}
                    onRowEditStop={handleRowEditStop}
                    processRowUpdate={processRowUpdate}
                    slots={{
                        toolbar: EditToolbar,
                    }}
                    slotProps={{
                        toolbar: { setRows, setRowModesModel },
                    }}
                />
            </Box>
        );
    }

    return (
        <div style={{ height: 800, width: '100%' }}>
            <FullFeaturedCrudGrid />
        </div>
    );
  }



//    //Note: Editing is not part of the specs so I'll not include these lines of codes for now.
//    //experimentalFeatures={{ newEditingApi: true }}
//    //editMode = "row"

//    return (
//        <div style={{ height: 800, width: '100%' }}>
//            <DataGrid
//                editMode="row"
//                rows={rows}
//                columns={[...columns, { field: 'id', filterable: false }]}
//                initialState={{
//                    columns: {
//                        columnVisibilityModel: {
//                            // Hide column id, the other columns will remain visible
//                            id: false,
//                        },
//                    },
//                }}
//                sx={{
//                    backgroundColor: 'white',
//                    boxShadow: 2,
//                    border: 2,
//                    borderColor: 'primary.light',
//                    '& .MuiDataGrid-cell:hover': {
//                        color: 'primary.main',
//                    },
//                }}
                
//            />
//        </div>
//    );
//  }

export default DisplayGrid;