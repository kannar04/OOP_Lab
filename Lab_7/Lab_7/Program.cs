/*Lab 7: slide trang 39
Yêu cầu phải có delegate và event (chi tiết nhất có thể về việc thay đổi số dư, lỗi hay gì đó, có gì phải nói ra hết)
*/

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;

        BankAccount myAccount = new BankAccount("Nguyễn Văn A", 500000);
        BankAccount otherAccount = new BankAccount("Trần Thị B", 0);
        PhoneNotification myPhone = new PhoneNotification();

        myAccount.OnTransactionSuccess += new BankAccount.TransactionHandler(myPhone.SendSMS);
        myAccount.OnTransactionFail += new BankAccount.TransactionHandler(myPhone.SendSMS);
        myAccount.OnTransactionFail += new BankAccount.TransactionHandler(myPhone.AlertSuspiciousActivity);

        Console.WriteLine("Test 1: Rút 100k");
        myAccount.Withdraw(100000);

        Console.WriteLine("Test 2: Chuyển 50k");
        myAccount.Transfer(50000, otherAccount);

        Console.WriteLine("Test 3: Rút 1 triệu");
        myAccount.Withdraw(1000000);
    }
}