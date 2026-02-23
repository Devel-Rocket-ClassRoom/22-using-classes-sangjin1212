using System;
BankAccount bankAccount = new BankAccount
{
    AccountNumber = "123-456-789",
    OwnerName = "홍길동",
};

Console.WriteLine($"[계좌 정보]({bankAccount.AccountNumber}) ({bankAccount.OwnerName} - 잔액 {bankAccount.Balance})");

class BankAccount
{
    int sum = 0;

    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public int Balance { get; set; }

    public static int Deposit()
    { 
        
    }
}