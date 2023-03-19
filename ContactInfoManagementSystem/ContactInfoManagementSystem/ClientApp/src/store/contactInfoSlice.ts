import { ContactInfoApi } from 'src/api';
import { createAsyncThunk, createSlice, type PayloadAction } from '@reduxjs/toolkit';

export type ContactInfo = Readonly<{
  id: number;
  emailaddresses: string;
  deliveryAddress: string;
  billingAddress: string;
  workPhone: string;
  homePhone: string;
  mobilePhone: string;
}>;

export type ContactInfoState = Readonly<{
  isLoading: boolean;
  startDateIndex: number;
  contactInfos: ContactInfo[];
}>;

export type ReceiveContactInfosPayload = Pick<ContactInfoState, "contactInfos" | "startDateIndex">;

const initialState: ContactInfoState = {
  contactInfos: [],
  isLoading: false,
  startDateIndex: 5
};

export const contactInfoSlice = createSlice({
  name: 'contactInfo',
  initialState,
  reducers: {
    requestContactInfos: (state, action: PayloadAction<number>) => {
      state.isLoading = true;
      state.startDateIndex = action.payload;
    },
      receiveContactInfos: (state, action: PayloadAction<ReceiveContactInfosPayload>) => {
          const { contactInfos, startDateIndex } = action.payload;
      if (startDateIndex === state.startDateIndex) {
        // Only accept the incoming data if it matches the most recent request.
        // This ensures we correctly handle out-of-order responses.
        state.isLoading = false;
        state.contactInfos = contactInfos;
        state.startDateIndex = startDateIndex;
      }
    }
  }
});

export const getContactInfosAsync = createAsyncThunk(
  'contactInfo/getContactInfosAsync',
  async (startDateIndex: number, { dispatch, getState }) => {
    // If param startDateIndex === state.startDateIndex, do not perform action
      const { startDateIndex: stateIdx } = (getState as () => ContactInfoState)();
    if (startDateIndex === stateIdx) {
      return;
    }

    // Dispatch request to intialize loading phase
      dispatch(requestContactInfos(startDateIndex));

    // Build http request and success handler in Promise<void> wrapper / complete processing
    try {
        const contactInfos = await ContactInfoApi.getContactInfosAsync(startDateIndex);
        const payload = { contactInfos, startDateIndex };
        dispatch(receiveContactInfos(payload));
    } catch (e) {
      console.error(e);
    }
  }
);

export const { requestContactInfos, receiveContactInfos } = contactInfoSlice.actions;

export default contactInfoSlice.reducer;