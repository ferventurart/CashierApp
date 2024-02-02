namespace Cashier.Tests;

public class BankAccountTests
{
    [Fact]
    public void BankAccount_WhenDebitAmountGreaterThanBalance_ThrowArgumentOutOfRangeException()
    {   
        //Arrange
        var amount = 20;
        var balance = 12;
        var bankAccountMock = new BankAccount("John Doe", balance);
        //Assert
        var act = () => bankAccountMock.Debit(amount);
        //Act
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Fact]
    public void BankAccount_WhenDebitNegativeAmount_ThrowArgumentOutOfRangeException()
    {   
        //Arrange
        var amount = -10;
        var balance = 12;
        var bankAccountMock = new BankAccount("John Doe", balance);
        //Assert
        var act = () => bankAccountMock.Debit(amount);
        //Act
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Fact]
    public void BankAccount_WhenCreditNegativeAmount_ThrowArgumentOutOfRangeException()
    {   
        //Arrange
        var amount = -10;
        var balance = 100;
        var bankAccountMock = new BankAccount("John Doe", balance);
        //Assert
        var act = () => bankAccountMock.Credit(amount);
        //Act
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void BankAccount_WhenDebitAmount_TheBalanceDecrease()
    {
        //Arrange
        var amount = 20;
        var balance = 100;
        var bankAccountMock = new BankAccount("John Doe", balance);
        //Assert
        bankAccountMock.Debit(amount);
        //Act
        bankAccountMock.Balance.Should().Be(80);
    }
    
    [Fact]
    public void BankAccount_WhenDebitAmount_TheBalanceIncrease()
    {
        //Arrange
        var amount = 20;
        var balance = 100;
        var bankAccountMock = new BankAccount("John Doe", balance);
        //Assert
        bankAccountMock.Credit(amount);
        //Act
        bankAccountMock.Balance.Should().Be(120);
    }
}