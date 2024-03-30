import { Branch } from "./branch";

export interface BranchStaff {
    id: number;
    employeeNumber: string;
    branchId: number;
    firstname: string;
    lastname: string;
    dateOfBirth: string;
    address: string;
    position: string;
    branch: Branch;
}
