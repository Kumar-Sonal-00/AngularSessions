namespace UserDefinedExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account(5000);
                account.Withdraw(3000);
                Console.WriteLine("Amount withdrawn, current balance:" + account.Balance);
                account.Deposit(-1000);
                Console.WriteLine("Amount deposited, current balance:" + account.Balance);
                account.Withdraw(6000);
                Console.WriteLine("Amount withdrawn, current balance:" + account.Balance);
            }
            catch (InsufficientFundsException ex) //3.Handle the exception
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidDepositAmountException ex) //3.Handle the exception
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using our Banking services");
            }
      }
    }

    class Account
    {
        public int Balance { get; set; }

        public Account(int balance)
        {
            this.Balance = balance;
        }
        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                //2.throw the exception
                InsufficientFundsException ex = new InsufficientFundsException("insufficient funds to withdraw!!!");
                throw ex;
            }
            else
            {
                Balance -= amount;
            }
        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                //throw the exception
                InvalidDepositAmountException ex = new InvalidDepositAmountException("Deposit amount must be more than Rs 0");
                throw ex;
            }
            else
            {
                Balance += amount;
            }
        }
    }
}