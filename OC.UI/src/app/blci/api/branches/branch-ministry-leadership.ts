import { LeadershipRole } from "../members/leadership-role";
import { Member } from "../members/member";
import { BranchMinistry } from "./branch-ministry";


export interface BranchMinistryLeadership  {
    id: number;
    branchMinistryId: number;
    leadershipRoleId: number;
    memberId: number;
    isActive: boolean;
    branchMinistry: BranchMinistry;
    leadershipRole: LeadershipRole;
    member: Member;
}
