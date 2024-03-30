import { Role } from "./role";
import { User } from "./user";
import { Module } from "./module";

export interface UserRight {
    id: number;
    userId: number;
    roleId: number;
    moduleId: number;
    role: Role | null;
    user: User | null;
    module: Module | null;
}
