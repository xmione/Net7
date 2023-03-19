import { memo } from 'react';
import type { ContactInfoState } from '../../store/contactInfoSlice';
import DisplaySubGraphs from '../../apollo/queries'

type ContactInfoTableProps = Pick<ContactInfoState, 'contactInfos'>;

const ContactInfoTable = memo<ContactInfoTableProps>(({ contactInfos }) => (
    <>
        <DisplaySubGraphs />
    </>
  
));

ContactInfoTable.displayName = 'ContactInfoTable';

export default ContactInfoTable;
