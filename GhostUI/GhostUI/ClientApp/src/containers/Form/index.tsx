import type { FunctionComponent } from 'react';
import SelectFormGroup from './SelectFormGroup';
import CounterFormGroup from './CounterFormGroup';
import CheckboxFormGroup from './CheckboxFormGroup';
import ContactsFormGroup from './ContactsFormGroup';

const Form: FunctionComponent = () => (
  <div className="section">
    <div className="container">
      <h3 className="title is-3">Form Controls</h3>
      <div className="box container-box">
        <div className="columns form-columns">
          <CounterFormGroup />
          <SelectFormGroup />
          <CheckboxFormGroup />
          <ContactsFormGroup />
        </div>
      </div>
    </div>
  </div>
);

export default Form;
