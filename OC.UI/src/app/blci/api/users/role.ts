import { UserRight } from "./user-right";

export interface Role {
    id: number;
    roleName: string;
    description: string;
    userRights: UserRight[];
}
