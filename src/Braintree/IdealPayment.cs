using System;

// NEXT_MAJOR_VERSION Remove this class as legacy Ideal has been removed/disabled in the Braintree Gateway
// DEPRECATED If you're looking to accept iDEAL as a payment method contact accounts@braintreepayments.com for a solution.
namespace Braintree
{
    public class IdealPayment
    {
        public virtual string Id { get; protected set; }
        public virtual string IdealTransactionId { get; protected set; }
        public virtual string ImageUrl { get; protected set; }
        public virtual string Status { get; protected set; }
        public virtual string Currency { get; protected set; }
        public virtual decimal Amount { get; protected set; }
        public virtual string OrderId { get; protected set; }
        public virtual string Issuer { get; protected set; }
        public virtual string ApprovalUrl { get; protected set; }
        public virtual IbanBankAccount IbanBankAccount { get; protected set; }

        protected internal IdealPayment(NodeWrapper node)
        {
            Id = node.GetString("id");
            IdealTransactionId = node.GetString("ideal-transaction-id");
            ImageUrl = node.GetString("image-url");
            Currency = node.GetString("currency");
            Status = node.GetString("status");
            Amount = (decimal) node.GetDecimal("amount");
            OrderId = node.GetString("order-id");
            Issuer = node.GetString("issuer");
            ApprovalUrl = node.GetString("approval-url");

            if (node.GetNode("iban-bank-account") != null)
            {
                IbanBankAccount = new IbanBankAccount(node.GetNode("iban-bank-account"));
            }
        }

        [Obsolete("Mock Use Only")]
        protected internal IdealPayment() { }
    }
}
