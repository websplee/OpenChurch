import { LeadershipRole } from "../members/leadership-role";
import { Member } from "../members/member";
import { Branch } from "./branch";

export interface BranchLeadership {
    id: number;
    branchId: number;
    leadershipRoleId: number;
    memberId: number;
    isActive: boolean;
    branch: Branch;
    leadershipRole: LeadershipRole;
    member: Member;
}
