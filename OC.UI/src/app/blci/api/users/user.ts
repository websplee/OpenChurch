import { UserRight } from "./user-right";

export interface User {
    id: number;
    username: string;
    fullname: string;
    email: string;
    description: string;
    passwordHash: string;
    passwordSalt: string;
    logInInfo: string | null;
    failedLoginCount: number;
    isLocked: boolean | null;
    userRights: UserRight[];
}
