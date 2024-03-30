import { UserRight } from "./user-right";

export interface Module {
    id: number;
    moduleName: string;
    description: string;
    userRights: UserRight[];
}
