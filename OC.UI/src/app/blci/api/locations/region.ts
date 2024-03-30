import { Branch } from "../branches/branch";

export interface Region {
    id?: number;
    countryId?: number;
    name?: string;
    officeLocation?: string | null;
    branches?: Branch[];
    isActive?: boolean;
}
