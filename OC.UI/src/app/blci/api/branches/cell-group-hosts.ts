import { Member } from "../members/member";
import { CellGroup } from "./cell-group";


export interface CellGroupHosts {
    id: number;
    cellGroupId: number;
    memberId: number;
    cellGroup: CellGroup;
    host: Member;
}
