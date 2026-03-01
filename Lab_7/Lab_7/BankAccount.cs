public class BankAccount
{
    public string accountName { get; set; }
    public int balance { get; set; }

    public delegate void TransactionHandler(object sender, TransactionEventArgs e);

    public event TransactionHandler OnTransactionSuccess; // giao dịch thành công (Rút + chuyển tiền thành công)
    public event TransactionHandler OnTransactionFail; // giao dịch thất bại (do không đủ số dư)

    public BankAccount(string accountName, int balance)
    {
        this.accountName = accountName;
        this.balance = balance;
    }

    public void Withdraw(int amount)
    {
        if (amount > this.balance)
        {
            if (OnTransactionFail != null)
            {
                string msg = "Giao dịch thất bại, số dư không đủ";
                OnTransactionFail(this, new TransactionEventArgs(amount, msg));
            }
        }
        else
        {
            this.balance = this.balance - amount;
            if (OnTransactionSuccess != null)
            {
                string msg = "Rút tiền thành công";
                OnTransactionSuccess(this, new TransactionEventArgs(amount, msg));
            }
        }
    }

    public void Transfer(int amount, BankAccount receiver)
    {
        if (amount > this.balance)
        {
            if (OnTransactionFail != null)
            {
                string msg = "Chuyển tiền thất bại: Số dư không đủ";
                OnTransactionFail(this, new TransactionEventArgs(amount, msg));
            }
        }
        else
        {
            // Trừ tiền người gửi
            this.balance = this.balance - amount;
                
            // Cộng tiền người nhận + Báo sự kiện thành công
            if (OnTransactionSuccess != null)
            {
                string msg = "Chuyển tiền thành công cho " + receiver.accountName;
                OnTransactionSuccess(this, new TransactionEventArgs(amount, msg));
            }
        }
    }
}