export interface AuditEntry {
    userId: number;
    tableName: string;
    keyValues: { [key: string]: any; };
    oldValues: { [key: string]: any; };
    newValues: { [key: string]: any; };
    auditType: AuditType;
    changedColumns: string[];
}

export enum AuditType {
    None = 0,
    Create = 1,
    Update = 2,
    Delete = 3,
    LogIn = 4
}
