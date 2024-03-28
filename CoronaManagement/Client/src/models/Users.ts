
import { SickWithCorona } from './SickWithCorona'; 
import { VaccinationDetail } from './VaccinationDetail'; 
export class Users{

    constructor(
        public userId?: number,
        public firstName?: string,
        public lastName?: string,
        public identityCard?: string,
        public city?: string,
        public street?: string,
        public number?: string,
        public dateOfBirth?: Date,
        public phone?: string ,
        public cellPhone?: string,
        public photo?: Uint8Array | null,
        public sickWithCoronas?: SickWithCorona[] | null,
        public vaccinationDetails?: VaccinationDetail[] | null
      ) {}


}