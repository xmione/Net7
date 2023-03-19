import React from 'react';
import { useQuery, gql } from '@apollo/client';
import DisplayGrid from '../components/grid/grid'
import convertExponentialToDecimal from './functions'

//type LoaderProps = {
//    message: string;
//};

//const GET_SUBGRAPHS = gql`
//{
//  contactInfo {
//    id
//    emailaddresses
//    deliveryAddress
//    billingAddress
//    workPhone
//    homePhone
//    mobilePhone
//  }
//}
//`;

//const InfoMessage = ({ message }: LoaderProps) => (<p>{message} </p>);

//const DisplaySubGraphs = () => {
//    const { loading, error, data } = useQuery(GET_SUBGRAPHS);

//    if (loading)
//    {
//        <InfoMessage message="Loading..."/>
//    }

//    if (error) {
//        <InfoMessage message="Error!" />
//    }

//    var contactInfo: { emailaddresses: any; deliveryAddress: any; billingAddress: any; workPhone: any; homePhone: any; mobilePhone: any; id: any; }[] = [];

//    data.contactInfo.forEach((i: { emailaddresses: any; deliveryAddress: any; billingAddress: any; workPhone: any; homePhone: any; mobilePhone: any; id: any; }) => {
//        var id = i.id;
//        var emailaddresses = i.emailaddresses;
//        var deliveryAddress = i.deliveryAddress;
//        var billingAddress = i.billingAddress;
//        var workPhone = i.workPhone;
//        var homePhone = i.homePhone;
//        var mobilePhone = i.mobilePhone;

//        contactInfo.push({
//            'id': id,
//            'emailaddresses': emailaddresses,
//            'deliveryAddress': deliveryAddress,
//            'billingAddress': billingAddress,
//            'workPhone': workPhone,
//            'homePhone': homePhone,
//            'mobilePhone': mobilePhone
//        });
//    });


//    return <DisplayGrid data={contactInfo}/>;


const GET_SUBGRAPHS = gql`
{
  epoches {
    id
    startBlock
	endBlock
    signalledTokens
    stakeDeposited
    totalQueryFees
    taxedQueryFees
    queryFeesCollected
    curatorQueryFees
    queryFeeRebates
    totalRewards
    totalIndexerRewards
    totalDelegatorRewards
  }
}
`;


function DisplaySubGraphs() {
    const { loading, error, data } = useQuery(GET_SUBGRAPHS);
    if (loading) return <p>Loading...</p>;
    if (error) return <p>Error :(</p>;
    const divisor = 10 ** 18;

    var epoches: {
        id: any; startBlock: any; endBlock: any; signalledTokens: string; stakeDeposited: string; totalQueryFees: string; taxedQueryFees: string; queryFeesCollected: string; curatorQueryFees: string; queryFeeRebates: string; totalRewards: string; totalIndexerRewards: string;

        totalDelegatorRewards: string //    emailaddresses
        ;
    }[] = []

    data.epoches.forEach((i: { signalledTokens: number; stakeDeposited: number; totalQueryFees: number; taxedQueryFees: number; queryFeesCollected: number; curatorQueryFees: number; queryFeeRebates: number; totalRewards: number; totalIndexerRewards: number; totalDelegatorRewards: number; id: any; startBlock: any; endBlock: any; }) => {
        var signalledTokens = (i.signalledTokens / divisor).toFixed(2)
        var stakeDeposited = (i.stakeDeposited / divisor).toFixed(2)
        var totalQueryFees = (i.totalQueryFees / divisor).toFixed(2)
        var taxedQueryFees = (i.taxedQueryFees / divisor).toFixed(2)
        var queryFeesCollected = (i.queryFeesCollected / divisor).toFixed(2)
        var curatorQueryFees = (i.curatorQueryFees / divisor).toFixed(2)
        var queryFeeRebates = (i.queryFeeRebates / divisor).toFixed(2)
        var totalRewards = (i.totalRewards / divisor).toFixed(2)
        var totalIndexerRewards = (i.totalIndexerRewards / divisor).toFixed(2)
        var totalDelegatorRewards = (i.totalDelegatorRewards / divisor).toFixed(2)

        epoches.push({
            'id': i.id,
            'startBlock': i.startBlock,
            'endBlock': i.endBlock,
            'signalledTokens': signalledTokens,
            'stakeDeposited': stakeDeposited,
            'totalQueryFees': totalQueryFees,
            'taxedQueryFees': taxedQueryFees,
            'queryFeesCollected': queryFeesCollected,
            'curatorQueryFees': curatorQueryFees,
            'queryFeeRebates': queryFeeRebates,
            'totalRewards': totalRewards,
            'totalIndexerRewards': totalIndexerRewards,
            'totalDelegatorRewards': totalDelegatorRewards
        });
    });

    return <DisplayGrid data={epoches} />;
}

export default DisplaySubGraphs;