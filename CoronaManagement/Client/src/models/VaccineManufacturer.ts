 import { VaccinationDetail } from "./VaccinationDetail";
export class VaccineManufacturer {
  constructor(
    public manufacturerId: number,
    public manufacturerName: string,
    public vaccinationDetails: VaccinationDetail[] | null
  ) {}
}
