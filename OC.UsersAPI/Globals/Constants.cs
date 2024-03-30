namespace OC.UsersAPI.Globals
{
    public enum ApproverLevel
    {
        FirstApprover = 1,
        SecondApprover = 2,
        ThirdApprover = 3,
        FourthApprover = 4,
        FifthApprover = 5,
        SixthApprover = 6
    }

    public enum ApprovalStatusType
    {
        Approved = 1,
        Received = 2,
        InTransit = 3,
        Pending = 4,
        Rejected = 5,
        Submitted = 6
    }
    
    public enum DateGroupType
    {
        Daily = 1,
        Weekly = 2,
        Monthly = 3,
        Quarterly = 4,
        Yearly = 5
    }
}
