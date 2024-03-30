import { Member } from "./member";
import { TransactionType } from "./transaction-type";

export interface MemberTransaction {
    id: number;
    memberId: number;
    transactionTypeId: number;
    amount: number;
    purpose: string;
    narration: string;
    transactionDateTime: string;
    member: Member;
    transactionType: TransactionType;
}
