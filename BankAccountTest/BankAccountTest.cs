namespace SampleApplicationTest;

public class BankAccountTests
{
    private BankAccount.Models.BankAccount? _bankAccount;

    [SetUp]
    public void Setup()
    {
        _bankAccount = new BankAccount.Models.BankAccount(120,"1203-102-12020");
    }

    [Test]
    public void TestDeposit()
    {
        _bankAccount?.Deposit(3002);
        if (_bankAccount != null) Assert.That(_bankAccount.Balance, Is.EqualTo(3122));
    }
}
