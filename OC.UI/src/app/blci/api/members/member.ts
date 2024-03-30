import { Pledge } from "../accounting/pledge";
import { Branch } from "../branches/branch";
import { BranchMinistryLeadership } from "../branches/branch-ministry-leadership";
import { CellGroup } from "../branches/cell-group";
import { Family } from "./family";


export interface Member {
    id?: number;
    branchId?: number | null;
    cellGroupId?: number | null;
    spouseId?: number | null;
    familyId?: number | null;
    code?: string | null;
    title?: string | null;
    name?: string | null;
    email?: string | null;
    gender?: string;
    dateOfBirth?: Date;
    dateBornAgain?: string | null;
    dateBaptised?: string | null;
    dateJoined?: string | null;
    occupation?: string | null;
    educationLevel?: string;
    pictureUrl?: string | null;
    maritalStatus?: string;
    address?: string;
    city?: string;
    latitude?: number;
    longitude?: number;
    mobileNumber?: string;
    isActive?: boolean;
    branch?: Branch;
    spouse?: Member;
    family?: Family;
    cellGroup?: CellGroup;
    branchMinistryLeaderships?: BranchMinistryLeadership[];
    pledges?: Pledge[];
}
