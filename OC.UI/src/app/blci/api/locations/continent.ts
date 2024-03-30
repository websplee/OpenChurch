import { AuditableEntity } from "../auditable-entity";
import { Country } from "./country";

export interface Continent {
    id?: number;
    name?: string;
    countries?: Country[];
    makerId?: string;
    submissionDate?: string;
    checkerId?: string;
    approvalDate?: string;
    rejectionDate?: string;
    isActive?: boolean;
}
