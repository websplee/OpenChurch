import { Expense } from "../accounting/expense";
import { Income } from "../accounting/income";
import { Region } from "../locations/region";
import { Member } from "../members/member";
import { BranchMinistry } from "./branch-ministry";
import { CellGroup } from "./cell-group";
import { ChurchProgramSession } from "./church-program-session";

export interface Branch {
    id?: number;
    regionId?: number;
    name?: string;
    physicalAddress?: string;
    phone1?: string;
    phone2?: string;
    email?: string;
    latitude?: number;
    longitude?: number;
    ownBuilding?: boolean;
    isActive?: boolean;
    region?: Region;
    expenses?: Expense[];
    incomes?: Income[];
    cellGroups?: CellGroup[];
    branchMinistries?: BranchMinistry[];
    members?: Member[];
    churchProgramSessions?: ChurchProgramSession;
}
