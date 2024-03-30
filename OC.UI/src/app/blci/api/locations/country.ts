import { Region } from "./region";

export interface Country {
    id?: number;
    continentId?: number;
    continentName?: string;
    code?: string;
    name?: string;
    regions?: Region[];
}
