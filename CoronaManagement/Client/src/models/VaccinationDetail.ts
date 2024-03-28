import { Users } from './Users'; 
import { VaccineManufacturer } from './VaccineManufacturer'; 

export class VaccinationDetail {
  constructor(
    public vaccinationId: number,
    public userId: number | null,
    public vaccineDate: Date | null,
    public vaccineManufacturerId: number | null,
    public user: Users | null,
    public vaccineManufacturer: VaccineManufacturer | null
  ) {}
}
