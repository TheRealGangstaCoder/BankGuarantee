namespace BankGuarantee.Core.Actions
{
    public interface IBQBankGuaranteeIssuanceAndBookingTask
    {
        string ExchangeBankGuaranteeIssuanceAndBookingTask(string bankGuaranteeId, string bankGuaranteeIssuanceAndBookingTaskId);
        string ExecuteBankGuaranteeIssuanceAndBookingTask(string bankGuaranteeId, string bankGuaranteeIssuanceAndBookingTaskId);
        string InitiateBankGuaranteeIssuanceAndBookingTask(string bankGuaranteeId);
        string NotifyBankGuaranteeIssuanceAndBookingTask(string bankGuaranteeId, string bankGuaranteeIssuanceAndBookingTaskId);
        string RequestBankGuaranteeIssuanceAndBookingTask(string bankGuaranteeId, string bankGuaranteeIssuanceAndBookingTaskId);
        string RetrieveBankGuaranteeIssuanceAndBookingTask(string bankGuaranteeId, string bankGuaranteeIssuanceAndBookingTaskId);
        string UpdateBankGuaranteeIssuanceAndBookingTask(string bankGuaranteeId, string bankGuaranteeIssuanceAndBookingTaskId);
    }
}