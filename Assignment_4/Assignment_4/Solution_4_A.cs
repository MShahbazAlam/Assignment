//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment_4
//{


//    class Accounts
//    {

//        private int account_no;
//        private string customer_name;
//        private string account_type;
//        private string transaction_type;
//        private int amount;
//        private int balance;

//        public Accounts(int account_no, string customer_name, string account_type, string transaction_type, int amount, int balance)
//        {
//            this.account_no = account_no;
//            this.customer_name = customer_name;
//            this.account_type = account_type;
//            this.transaction_type = transaction_type;
//            this.amount = amount;
//            this.balance = balance;
//        }

//        public void update_balance()
//        {
//            if (this.transaction_type == "d")
//            {
//                this.balance += this.amount;
//            }
//            else if (this.transaction_type == "w")
//            {
//                this.balance -= this.amount;
//            }
//        }

//        public void credit(int amount)
//        {
//            this.amount = amount;
//            this.update_balance();
//        }

//        public void debit(int amount)
//        {
//            this.amount = amount;
//            this.update_balance();
//        }

//        public void show_data()
//        {
//            Console.WriteLine("Account number: " + this.account_no);
//            Console.WriteLine("Customer name: " + this.customer_name);
//            Console.WriteLine("Account type: " + this.account_type);
//            Console.WriteLine("Transaction type: " + this.transaction_type);
//            Console.WriteLine("Amount: " + this.amount);
//            Console.WriteLine("Balance: " + this.balance);
//        }
//    }


//    class Solution_4_A
//    {
//        static void Main()
//        {

//            Console.WriteLine("Enter account number: ");
//            int account_no = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter customer name: ");
//            string customer_name = Console.ReadLine();
//            Console.WriteLine("Enter account type: (\"Saving, Current\")");
//            string account_type = Console.ReadLine();
//            Console.WriteLine("Enter transaction type (d/w): ");
//            Console.WriteLine("d for \"Deposit\" and w for \"Withdrawal\" :");
//            string transaction_type = Console.ReadLine();
//            Console.WriteLine("Enter amount: ");
//            int amount = Convert.ToInt32(Console.ReadLine());

//            // object of Accounts
//            Accounts accounts = new Accounts(account_no, customer_name, account_type, transaction_type, amount, 0);

//            // Calling method based on input either d or w
//            if (transaction_type == "d")
//            {
//                accounts.credit(amount);
//            }
//            else if (transaction_type == "w")
//            {
//                accounts.debit(amount);
//            }

//            // account details
//            accounts.show_data();

//            Console.ReadLine();
//        }


//    }
//}