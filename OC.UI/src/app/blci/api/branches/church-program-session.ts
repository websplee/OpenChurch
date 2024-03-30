import { Expense } from "../accounting/expense";
import { Income } from "../accounting/income";
import { Pledge } from "../accounting/pledge";
import { ChurchProgramSessionAttendance } from "./church-program-session-attendance";
import { ChurchProgramSessionVisitor } from "./church-program-session-visitor";

export interface ChurchProgramSession {
    id?: number;
    branchId?: number;
    name?: string;
    startTime?: string;
    endTime?: string;
    churchProgramSessionAttendances?: ChurchProgramSessionAttendance;
    churchProgramSessionVisitors?: ChurchProgramSessionVisitor;
    expenses?: Expense;
    incomes?: Income;
    pledges?: Pledge;
}
