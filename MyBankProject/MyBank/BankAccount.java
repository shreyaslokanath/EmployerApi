
/**
 * This class contains methods make lodgement to add an amount to balance
 * and makeWithdrawl to withdraw money and closeAccount method to close an 
 * account and a tostring method to return the value.
 *
 * @author Shreyas Lokanath 
 * @version 0.1 or 09/02/2018
 */

// importing to use JOptionPane
import javax.swing.JOptionPane;

public class BankAccount
{
    
   //customer name
   private String customerName;
   //account number of the customer
   private String accountNumber;
   //current balance of the account
   private double currentBalance;
   //status of the account
   private boolean status;
   
   

    /**
     *create BankAccount object by prompting the user to enter
     *customer name and account number with default opening balance
     *of zero and account status of active.
     *
     *@param customer name and account number passed as parameters to bank account
     */
    
    public BankAccount(String customerName, String accountNumber)
    {
        this.customerName=customerName;
        this.accountNumber=accountNumber;
        currentBalance=0.00;
        status=true;
    }
    
     public BankAccount(String customerName, String accountNumber, double currentBalance, boolean status)
    {
       
        this.customerName = customerName;
        this.accountNumber = accountNumber;
        this.currentBalance = currentBalance;
        this.status = status;
        
    }
    
    /**
     * Make a deposit into the account, the amount has to be greater than zero and
     * the status of the account has to be active.
     * 
     * @param amountLodged is passed as paramter to makeLodgement
     * @return none 
     */
    
    public void makeLodgement(double amountLodged)
    {
        //amount to be deposited
        double amount=amountLodged;
        
        if((amount>0) && (status==true))
        {
            currentBalance+=amount;
        }
        else if((amount<=0) && (status==true))
        {
           JOptionPane.showMessageDialog(null,"Enter Amount greater than 0","Invalid Amount",JOptionPane.ERROR_MESSAGE); 
        }
        else
        {
            JOptionPane.showMessageDialog(null,"check the status of your account,it is In-active","Error Message",JOptionPane.ERROR_MESSAGE);
            
        }
        
    }
    
    /**
     * withdraw money from the account, there has to be sufficient amount in the account and the status of the account has to be
     * active. If a withdrawl cannot be made then appropriate message with balance and shortfall.
     * 
     * @param amountToWithdraw is passed as parameter to this method
     * @return none
     */
    public void makeWithdrawl(double amountToWithdraw)
    {
        //amount to be withdrawn
        double withdrawAmount=amountToWithdraw;
        //remaining balance in the account
        double balance;
       
        if(withdrawAmount>0 && withdrawAmount<currentBalance && status==true)
        {
            currentBalance-=withdrawAmount;
            JOptionPane.showMessageDialog(null,"The amount withdrawn is €"+String.format("%.2f",withdrawAmount ) +" the remaining balance is €"+String.format("%.2f",currentBalance),"Information Message",JOptionPane.INFORMATION_MESSAGE);
        }
        else if(withdrawAmount<=0 && status==true)
        {
            JOptionPane.showMessageDialog(null,"Enter Amount greater than 0","Invalid Amount",JOptionPane.ERROR_MESSAGE); 
        }
        else if(withdrawAmount>currentBalance && status==true)
        {
            balance=withdrawAmount-currentBalance;
            JOptionPane.showMessageDialog(null,"You have insufficient money in your account,You have €"+String.format("%.2f",currentBalance)+" Euros in your account, You requested €"+String.format("%.2f",withdrawAmount )+" You are short by €"+String.format("%.2f",balance),"Information Message",JOptionPane.INFORMATION_MESSAGE);
        }
        else if(currentBalance>0 && status==true)
        {
           
                JOptionPane.showMessageDialog(null,"Your account "+accountNumber+" in the name of "+customerName.toUpperCase()+" has been closed and the remainig amount in the account "+String.format("%.2f",currentBalance )+" Euros is available to be witdrawn.","Information Message",JOptionPane.INFORMATION_MESSAGE);
                currentBalance-=withdrawAmount;
           
        }
        else
        {
                JOptionPane.showMessageDialog(null,"check the status of your account, it is In-active","Error Message",JOptionPane.ERROR_MESSAGE);
        }
        
        
        
        
    }
    
    /**
     * close the account and call the makeWithdraw methods which withdraws all the remaining 
     * amount in the account and changes the status.
     * 
     * @param none
     * @return none
     */
    
    public void closeAccount()
    {
       
        if(currentBalance==0.0)
        {
              
                JOptionPane.showMessageDialog(null,"Your account "+accountNumber+" in the name of "+customerName.toUpperCase()+" has a balance of € 0.0  and the account has been closed","Information Message",JOptionPane.INFORMATION_MESSAGE);
                setAccountStatus();
        }
        else
        {
            if(getStatus()==true)
            {
                makeWithdrawl(currentBalance);
                setAccountStatus();
            }
            else
            {
                JOptionPane.showMessageDialog(null,"Your account status is inactive!!","Information message",JOptionPane.INFORMATION_MESSAGE);
            }
                
          
        }
        
      
           
    }
    
    /*
     * returns a string with the account details in a particular format 
     * @param none
     * @return returns a string with name, account Number and current balance
     */
    @Override
    public String toString()
   {
       return "Customer Name:"+customerName.toUpperCase()+", "+" Account Number: "+accountNumber+" ,"+" Balance=€"+String.format("%.2f",currentBalance)+", "+"Account status="+status; 
   }
    
    /**
     * method to set the account status to true or false
     * 
     * @param none
     * @return none
     */
    public void setAccountStatus()
    {
        if(status)
        {
            status=false;
        }
        else
        status=true;
        
    }
    
    /**
     * accessor to return the customer name
     * @param  none
     * @return customer name
     */
    public String getCustomerName()
    {
        return customerName;
    }
    
    /**
     * accessor to return account number
     * @param none
     * @return accountNumber
     */
    public String getAccountNumber()
    {
        return accountNumber;
    }
    
    /**
     * accessor to return account status
     * @param none
     * @return status
     */
    public boolean getStatus()
    {
        return status;
    }
    
    /**
     * accessor to return current balance
     * @param none
     * @return currentBalance
     */
    public double getCurrentBalance()
    {
        return currentBalance;
    }

    
    
    
    
       
}
