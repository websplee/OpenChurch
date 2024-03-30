export interface AuditableEntity {
    makerId: string | null;
    submissionDate: string;
    checkerId: string | null;
    approvalDate: string | null;
    rejectionDate: string | null;
    isActive: boolean | null;
}
