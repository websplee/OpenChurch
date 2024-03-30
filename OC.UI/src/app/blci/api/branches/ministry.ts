import { Pledge } from "../accounting/pledge";
import { BranchMinistry } from "./branch-ministry";


export interface Ministry {
    id?: number;
    name?: string;
    shortName?: string | null;
    description?: string | null;
    isActive?: boolean;
    branchMinistries?: BranchMinistry[];
    pledges?: Pledge[];
}
