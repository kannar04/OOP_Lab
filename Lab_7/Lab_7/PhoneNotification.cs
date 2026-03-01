public class PhoneNotification
{
    public void SendSMS(object sender, TransactionEventArgs e)
    {
        BankAccount account = (BankAccount)sender;

        Console.WriteLine("-------------- THÔNG BÁO GIAO DỊCH --------------");

        Console.WriteLine($"Chủ tài khoản: {account.accountName}");
        Console.WriteLine($"Thời gian: {e.time}");
        Console.WriteLine($"Trạng thái: {e.message}");
        Console.WriteLine($"Sô tiền giao dịch: {e.amount}");
        Console.WriteLine($"Số dư hiện tại: {account.balance}");

        Console.WriteLine("--------------------------------------------------");
    }

    public void AlertSuspiciousActivity(object sender, TransactionEventArgs e)
    {
        Console.WriteLine("-------------- CẢNH BÁO --------------");
        Console.WriteLine("Tài khoản của bạn không đủ số dư để thực hiện giao dịch");

        Console.WriteLine($"Số tiền được yêu cầu: {e.amount}");
        Console.WriteLine("---------------------------------------");
    }
}