import { LeadershipRole } from "../members/leadership-role";
import { Member } from "../members/member";
import { Region } from "./region";

export interface RegionLeadership {
    id?: number;
    regionId?: number;
    regionName?: string;
    leadershipRoleId?: number;
    leadershipRoleName?: string;
    memberId?: number;
    memberName?: string;
    memberPictureUrl?: string;
    isActive?: boolean;
    region?: Region;
    leadershipRole?: LeadershipRole;
    member?: Member;
}
