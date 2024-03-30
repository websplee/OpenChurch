import { ChurchProgramSession } from "./church-program-session";

export interface ChurchProgram {
    id?: number;
    name?: string;
    description?: string;
    churchProgramSessions?: ChurchProgramSession;
}
