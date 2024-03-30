import { ChurchProgramSession } from "./church-program-session";

export interface ChurchProgramSessionAttendance {
    id?: number;
    churchProgramSessionId?: number;
    totalMen?: number;
    totalWomen?: number;
    totalYouthMen?: number;
    totalYouthWomen?: number;
    totalBoys?: number;
    totalGirls?: number;
    churchProgramSession?: ChurchProgramSession;
}
