import Pagination from './Pagination';
import { Spinner } from '../../components';
import ContactInfoTable from './ContactInfoTable';
import { useParams } from 'react-router-dom';
import { useEffect, type FunctionComponent } from 'react';
import { useAppSelector, useAppDispatch } from '../../store';
import { getContactInfosAsync, type ContactInfo} from '../../store/contactInfoSlice';

const Contacts: FunctionComponent = () => {
  const dispatch = useAppDispatch();
  const { startDateIndex: startDateIndexDefault = '0' } = useParams();
  const intNextStartDateIndex = parseInt(startDateIndexDefault, 10);
  const isLoading = useAppSelector<boolean>((state) => state.contact.isLoading);
  const contactInfos = useAppSelector<ContactInfo[]>((state) => state.contact.contactInfos);
  const startDateIndex = useAppSelector<number>((state) => state.contact.startDateIndex);

  useEffect(() => {
    if (startDateIndex !== intNextStartDateIndex) {
      dispatch(getContactInfosAsync(intNextStartDateIndex));
    }
  }, [dispatch, startDateIndex, intNextStartDateIndex]);

  return (
    <div className="section">
      <div className="container">
        <h3 className="title is-3">
          Management System
        </h3>
        <div className="box container-box">
          <h3 className="title is-4">
            Contact Info
          </h3>
          <h5 className="subtitle is-5">
            
          </h5>
          <Spinner isLoading={isLoading} />
            <ContactInfoTable contactInfos={contactInfos} />
          <Pagination startDateIndex={startDateIndex} />
        </div>
      </div>
    </div>
  );
};

export default Contacts;
