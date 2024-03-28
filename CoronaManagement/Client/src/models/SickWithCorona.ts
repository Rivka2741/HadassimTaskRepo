import { Users } from './Users'; 

export class SickWithCorona {
  constructor(
    public sickId: number,
    public userId: number | null,
    public positiveResultDate: Date | null,
    public recoveryDate: Date | null,
    public user: Users | null
  ) {}
}
