import { Branch } from "../branches/branch";
import { ChurchProgramSession } from "../branches/church-program-session";
import { Member } from "../members/member";
import { ExpenseType } from "./expense-type";

export interface Expense {
    id?: number;
    branchId?: number;
    churchProgramSessionId?: number | null;
    memberId?: number | null;
    expenseTypeId?: number;
    trxDate?: string;
    amount?: number;
    reference?: string | null;
    description?: string | null;
    branch?: Branch;
    churchProgramSession?: ChurchProgramSession;
    member?: Member;
    expenseType?: ExpenseType;
}
