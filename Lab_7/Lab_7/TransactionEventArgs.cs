public class TransactionEventArgs : EventArgs
{
    public int amount { get; set; }
    public string message { get; set; }
    public DateTime time { get; set; }

    public TransactionEventArgs(int amount, string message)
    {
        this.amount = amount;
        this.message = message;
        this.time = DateTime.Now;
    }
}