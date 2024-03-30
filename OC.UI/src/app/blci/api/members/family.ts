import { Member } from "./member";

export interface Family {
    id: number;
    name: string;
    familyAdminId: number | null;
    isActive: boolean;
    administrator: Member;
    members: Member[];
}
