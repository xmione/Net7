import React from 'react';
import { useQuery, gql } from '@apollo/client';
import DisplayGrid from '../components/grid/grid'
import convertExponentialToDecimal from './functions'

type LoaderProps = {
    message: string;
};

const GET_SUBGRAPHS = gql`
{
  contactInfo {
    id
    emailaddresses
    deliveryAddress
    billingAddress
    workPhone
    homePhone
    mobilePhone
  }
}
`;

const InfoMessage = ({ message }: LoaderProps) => (<p>{message} </p>);

const DisplaySubGraphs = () => {
    const { loading, error, data } = useQuery(GET_SUBGRAPHS);
    
    if (loading)
    {
        <InfoMessage message="Loading..."/>
    } 

    if (error) {
        <InfoMessage message="Error!" />
    } 
    
    var contactInfo: { emailaddresses: any; deliveryAddress: any; billingAddress: any; workPhone: any; homePhone: any; mobilePhone: any; id: any; }[] = [];

    data.contactInfo.forEach((i: { emailaddresses: any; deliveryAddress: any; billingAddress: any; workPhone: any; homePhone: any; mobilePhone: any; id: any; }) => {
        var id = i.id;
        var emailaddresses = i.emailaddresses;
        var deliveryAddress = i.deliveryAddress; 
        var billingAddress = i.billingAddress;
        var workPhone = i.workPhone;
        var homePhone = i.homePhone;
        var mobilePhone = i.mobilePhone;

        contactInfo.push({
            'id': id,
            'emailaddresses': emailaddresses,
            'deliveryAddress': deliveryAddress,
            'billingAddress': billingAddress,
            'workPhone': workPhone,
            'homePhone': homePhone,
            'mobilePhone': mobilePhone
        });
    });


    return <DisplayGrid data={contactInfo}/>;
}

export default DisplaySubGraphs;