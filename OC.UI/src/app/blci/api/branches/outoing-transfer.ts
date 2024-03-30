import { Member } from "../members/member";
import { Branch } from "./branch";

export interface OutgoingTransfer {
    id: number;
    branchId: number;
    oldBranchName: string;
    memberId: number;
    notes: string;
    isAccepted: boolean;
    member: Member;
    branch: Branch;
}
