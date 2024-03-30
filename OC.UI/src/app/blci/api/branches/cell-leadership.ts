import { LeadershipRole } from "../members/leadership-role";
import { Member } from "../members/member";
import { CellGroup } from "./cell-group";

export interface CellLeadership {
    id: number;
    cellGroupId: number;
    leadershipRoleId: number;
    memberId: number;
    isActive: boolean;
    cellGroup: CellGroup;
    leadershipRole: LeadershipRole;
    member: Member;
}
