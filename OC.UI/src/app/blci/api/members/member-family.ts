import { Member } from "./member";
import { Family } from "./family";

export interface MemberFamily {
    id: number;
    memberId: number;
    familyId: number;
    member: Member;
    family: Family;
}
