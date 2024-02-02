namespace Cashier.Tests;

public class BankAccountTests
{
    [Fact]
    public void BankAccount_WhenDebitAmountGreaterThanBalance_ThrowArgumentOutOfRangeException()
    {   
        //Arrange
        double beginningBalance = 11.99;
        double debitAmount = 54.55;
        var bankAccountMock = new BankAccount("John Doe", beginningBalance);
        //Assert
        var act = () => bankAccountMock.Debit(debitAmount);
        //Act
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Fact]
    public void BankAccount_WhenDebitNegativeAmount_ThrowArgumentOutOfRangeException()
    {   
        //Arrange
        double beginningBalance = 11.99;
        double debitAmount = -4.55;
        var bankAccountMock = new BankAccount("John Doe", beginningBalance);
        //Assert
        var act = () => bankAccountMock.Debit(debitAmount);
        //Act
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
    
    [Fact]
    public void BankAccount_WhenCreditNegativeAmount_ThrowArgumentOutOfRangeException()
    {   
        //Arrange
        double beginningBalance = 11.99;
        double creditAmount = -4.55;
        var bankAccountMock = new BankAccount("John Doe", beginningBalance);
        //Assert
        var act = () => bankAccountMock.Credit(creditAmount);
        //Act
        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void BankAccount_WhenDebitAmount_TheBalanceDecrease()
    {
        //Arrange
        double beginningBalance = 11.99;
        double debitAmount = 4.55;
        double expected = 7.44;
        var bankAccountMock = new BankAccount("John Doe", beginningBalance);
        //Assert
        bankAccountMock.Debit(debitAmount);
        //Act
        bankAccountMock.Balance.Should().Be(expected);
    }
    
    [Fact]
    public void BankAccount_WhenCreditAmount_TheBalanceIncrease()
    {
        //Arrange
        double beginningBalance = 11.99;
        double creditAmount = 4.55;
        double expected = 16.54;
        var bankAccountMock = new BankAccount("John Doe", beginningBalance);
        //Assert
        bankAccountMock.Credit(creditAmount);
        //Act
        bankAccountMock.Balance.Should().Be(expected);
    }
}