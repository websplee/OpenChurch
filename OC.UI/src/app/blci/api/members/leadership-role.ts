import { BranchMinistryLeadership } from "../branches/branch-ministry-leadership";
import { CellLeadership } from "../branches/cell-leadership";

export interface LeadershipRole {
    id?: number;
    name?: string;
    shortName?: string;
    description?: string;
    isActive?: boolean;
    branchMinistryLeaderships?: BranchMinistryLeadership[];
    cellLeaderships?: CellLeadership[];
}
