import { Ministry } from "../branches/ministry";
import { Member } from "../members/member";


export interface Pledge {
    id: number;
    memberId: number | null;
    ministryId: number | null;
    description: string | null;
    amount: number;
    paidAmount: number;
    paymentDate: string | null;
    paidDate: string | null;
    member: Member;
    ministry: Ministry;
}
