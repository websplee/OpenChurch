import { Member } from "../members/member";
import { Branch } from "./branch";
import { CellLeadership } from "./cell-leadership";

export interface CellGroup {
    id: number;
    branchId: number;
    name: string;
    branch: Branch;
    members: Member[];
    cellLeaderships: CellLeadership[];
}
