// Base class for all users of the bank
abstract class User {
    private String name;
    private String address;
    private String phoneNumber;

}

// Class representing a bank account
class Account {
    private User accountHolder;
    private double balance;
    private String accountNumber;


    // Method to check the balance
    public double checkBalance() {
        return balance;
    }
}

// Class representing a transaction
class Transaction {
    private Account fromAccount;
    private Account toAccount;
    private double amount;
    private Date transactionDate;


    // Method to execute the transaction
    public void execute() {

    }
}