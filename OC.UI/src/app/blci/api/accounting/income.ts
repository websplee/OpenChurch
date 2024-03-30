import { Branch } from "../branches/branch";
import { ChurchProgramSession } from "../branches/church-program-session";
import { Member } from "../members/member";
import { IncomeType } from "./income-type";

export interface Income {
    id?: number;
    branchId?: number;
    churchProgramSessionId?: number | null;
    memberId?: number | null;
    incomeTypeId?: number;
    trxDate?: string;
    amount?: number;
    reference?: string | null;
    description?: string | null;
    trxSource?: string | null;
    branch?: Branch;
    churchProgramSession?: ChurchProgramSession;
    member?: Member;
    incomeType?: IncomeType;
}
