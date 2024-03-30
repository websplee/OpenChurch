import { ChurchProgramSession } from "./church-program-session";

export interface ChurchProgramSessionVisitor {
    id?: number;
    churchProgramSessionId?: number;
    name?: string;
    mobileNumber?: string;
    email?: string;
    address?: string;
    dateVisited?: Date;
    dateToVisit?: Date;
    followedUp?: boolean;
    comments?: string;
    churchProgramSession?: ChurchProgramSession;
}
