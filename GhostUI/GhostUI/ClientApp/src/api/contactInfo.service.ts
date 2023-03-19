import { BaseService } from './base.service';
import type { ContactInfo } from '../store/contactInfoSlice';

/**
 * ContactInfo API abstraction layer communication via Axios (typescript singleton pattern)
 */
class ContactInfoService extends BaseService {
  private static _service: ContactInfoService;
  private static _controller: string = 'ContactInfoData';

  private constructor(name: string) {
    super(name);
  }

    public static get Instance(): ContactInfoService {
    return this._service || (this._service = new this(this._controller));
  }

  public async getContactInfosAsync(startDateIndex: number): Promise<ContactInfo[]> {
    const url = `ContactInfos?startDateIndex=${startDateIndex}`;
    const { data } = await this.$http.get<ContactInfo[]>(url);
    return data;
  }
}

export const ContactInfoApi = ContactInfoService.Instance;
