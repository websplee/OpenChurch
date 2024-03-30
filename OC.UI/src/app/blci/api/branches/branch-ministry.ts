import { Branch } from "./branch";
import { BranchMinistryLeadership } from "./branch-ministry-leadership";
import { Ministry } from "./ministry";

export interface BranchMinistry {
    id: number;
    ministryId: number;
    branchId: number;
    isActive: boolean;
    branch: Branch;
    ministry: Ministry;
    branchMinistryLeaderships: BranchMinistryLeadership[];
}
