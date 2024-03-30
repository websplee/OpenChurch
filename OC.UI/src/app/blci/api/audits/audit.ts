export interface Audit {
    id: number;
    userId: number;
    type: string;
    tableName: string;
    dateTime: string;
    oldValues: string;
    newValues: string;
    affectedColumns: string;
    primaryKey: string;
}
