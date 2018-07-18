
/**
 *This class will control the creation of accounts utilizing the bank account class where each bank account created will be strored 
 *in an arraylist object and there are methods listAllAccounts and listAllOpenAccounts that list the accounts all the accounts
 *and those accounts that are open. There are methods to close and remove account
 *
 *This class also contains two public methods called bankInterface() and customerInterface() that acts as an interface for customer and
 *bank officials. These two methods contain various options to perform account operations, while the other methods are private.
 * 
 *
 * @author Shreyas Lokanath
 * @version 0.4 or 05/03/2018
 */

//imports this class for jopiton pane
import javax.swing.JOptionPane;
//imports this class to use all the methods of an arraylist
import java.util.ArrayList;
//MyBankController class

//import print writer class
import java.io.PrintWriter;
//import buffered reader class
import java.io.BufferedReader;
//import file reader class
import java.io.FileReader;

public class MyBankController
{
    //ArrayList of class type BankAccount
    private ArrayList<BankAccount> bankAccArrayList;
    //stores the index of the account number
    int foundIndex;
    //file path of where the details have to be written and read.
    String outputFile="F:/MS815-AdvancedApplicationProgramming/Assignment/Assignment5-02-3-18/output.txt";
    /**
     * Constructor of MyBankController creates an ArrayList object
     * @param none
     * 
     */
    public MyBankController()
    {
        bankAccArrayList = new ArrayList<BankAccount>();
    }

    /**
     * method that takes input from the customer and gives options to perform operations like
     * make lodgement, make withdrawl, display account and close account.
     * 
     * @param none
     * @return none
     */
    public void customerInterface()
    {
        String inputAccountNumber;
        try
        {
            boolean status=true;

            inputAccountNumber=JOptionPane.showInputDialog(null,"Please enter your account number","Account details",JOptionPane.INFORMATION_MESSAGE);

            if(inputAccountNumber !=null)
            {
                if(getIndex(inputAccountNumber)!=-1)
                {
                    while(status==true)
                    {

                        String testcustomerChoice=JOptionPane.showInputDialog(null,"Please select an option below: \n\n [1] Make a Lodgement: \n\n [2] Make a withdrawl: \n\n[3] Display Account details: \n\n[4] Close Account: \n\n[5] Exit \n\n","MyBank ATM",JOptionPane.INFORMATION_MESSAGE);
                        if(testcustomerChoice!=null)
                        { 
                            try
                            {
                                int customerChoice=Integer.parseInt(testcustomerChoice);
                                switch (customerChoice)
                                {
                                    case 1: String testlodgeAmount;

                                    testlodgeAmount=JOptionPane.showInputDialog(null,"Enter the amount you would like to lodge","MyBank ATM: Lodge Amount",JOptionPane.INFORMATION_MESSAGE);
                                    if(testlodgeAmount!=null)
                                    {
                                        try
                                        {
                                            double lodgeAmount=Double.parseDouble(testlodgeAmount);
                                            makeLodgement(inputAccountNumber,lodgeAmount);
                                        }
                                        catch(Exception Ex)
                                        {
                                            JOptionPane.showMessageDialog(null,"Enter the number in correct format!","Invalid input",JOptionPane.WARNING_MESSAGE);
                                        }
                                    }
                                    else
                                    {
                                        JOptionPane.showMessageDialog(null,"You have not entered anything","No Input",JOptionPane.INFORMATION_MESSAGE);
                                    }

                                    break;

                                    case 2: String testwithdrawAmount=JOptionPane.showInputDialog(null,"Enter the amount you would like to withdraw","MyBank ATM: withdraw Amount",JOptionPane.INFORMATION_MESSAGE);
                                    if(testwithdrawAmount!=null)
                                    {
                                        try
                                        {
                                            double withdrawAmount=Double.parseDouble(testwithdrawAmount);
                                            makeWithdrawl(inputAccountNumber,withdrawAmount);

                                        }
                                        catch(Exception Ex)
                                        {
                                            JOptionPane.showMessageDialog(null,"Enter the number in correct format!","Invalid input",JOptionPane.WARNING_MESSAGE);
                                        }
                                    }

                                    break;
                                    case 3: 
                                    if(inputAccountNumber !=null)
                                    {
                                        displayAccount(inputAccountNumber);
                                    }

                                    break;

                                    case 4: 
                                    if(inputAccountNumber !=null)
                                    {
                                        if(bankAccArrayList.get(foundIndex).getStatus()!=false)
                                        {

                                            int dialogResult = JOptionPane.showConfirmDialog (null, "Would You Like to close your account?","Warning",JOptionPane.YES_NO_OPTION);
                                            if(dialogResult == JOptionPane.YES_OPTION)
                                            {
                                                closeAccount(inputAccountNumber);
                                            }

                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else
                                        {

                                            JOptionPane.showMessageDialog(null,"Your account is already closed","In-active account status",JOptionPane.INFORMATION_MESSAGE);

                                        }
                                    }

                                    break;

                
                                    case 5: return;

                                    default: JOptionPane.showMessageDialog(null,"please enter a valid choice","Invalid choice",JOptionPane.INFORMATION_MESSAGE);
                                    break;

                                }
                            }
                            catch (Exception Ex)
                            {
                                JOptionPane.showMessageDialog(null,"Enter the number in correct format!","Invalid input",JOptionPane.WARNING_MESSAGE);
                            }
                        }

                        else
                        {
                            return;
                        }

                    }

                }
                else
                {
                    JOptionPane.showMessageDialog(null,"Invalid Account, please enter a different account number","Invalid Account",JOptionPane.INFORMATION_MESSAGE);
                }
            }
            else
            {
                JOptionPane.showMessageDialog(null,"You have not entered anything","No Input",JOptionPane.INFORMATION_MESSAGE);
            }
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(null,"Invalid Input","Invalid input",JOptionPane.INFORMATION_MESSAGE);
        }
    }

    /**
     * The bankInterface method is for the bank employees, where they will be able to manage different accounts. They can list different
     * types of accounts, close an account, create an account and exit from the application.
     * @param none
     * @return none
     */
    public void bankInterface()
    {
        try
        {
            boolean status=true;

            while(status==true)
            {

                String testcustomerChoice=JOptionPane.showInputDialog(null,"Please select an option below: \n\n [1] Display All Accounts: \n\n [2] Display All Active Accounts: \n\n[3] Open a New Account: \n\n[4] Close an existing Account: \n\n[5] Run start of the day  \n\n[6] Run End of Day: \n\n[7] Exit: \n\n","MyBank System",JOptionPane.INFORMATION_MESSAGE);
                if(testcustomerChoice!=null)
                { 
                    try
                    {
                        int customerChoice=Integer.parseInt(testcustomerChoice);
                        switch (customerChoice)
                        {

                            case 1: listAllAccounts(); 

                            break;     

                            case 2: listAllOpenAccounts();
                            break;

                            case 3: String inputcustName=JOptionPane.showInputDialog(null,"Enter the Account name you want to create","MyBank System: customer name",JOptionPane.INFORMATION_MESSAGE);

                            if(inputcustName!=null) 
                            {
                                String inputcustNumber=JOptionPane.showInputDialog(null,"Enter the Account number you want to create","MyBank System: customer number",JOptionPane.INFORMATION_MESSAGE);
                                if(inputcustNumber !=null)
                                {
                                    if(getIndex(inputcustNumber)!=-1)
                                    {

                                        JOptionPane.showMessageDialog(null,"The account with the following account number exists","account already exists",JOptionPane.INFORMATION_MESSAGE);
                                    }
                                    else
                                    {
                                        createAccount(inputcustName,inputcustNumber);
                                    }
                                }
                            }
                            break;

                            case 4: try
                            {
                                String inputAccNumToClose=JOptionPane.showInputDialog(null,"Enter the Account number of the account you want to close","MyBank System",JOptionPane.INFORMATION_MESSAGE);

                                if(inputAccNumToClose!=null)
                                {
                                    if(getIndex(inputAccNumToClose)!=-1)
                                    {

                                        if(bankAccArrayList.get(foundIndex).getStatus()==true)
                                        {

                                            if(JOptionPane.showConfirmDialog (null, "Would You Like to close your account?","Warning",JOptionPane.YES_NO_OPTION) == JOptionPane.YES_OPTION)

                                            {
                                                closeAccount(inputAccNumToClose);
                                            }

                                            else
                                            {
                                                break;
                                            }
                                        }
                                        else
                                        {

                                            JOptionPane.showMessageDialog(null,"The account is already closed","In-active account status",JOptionPane.INFORMATION_MESSAGE);

                                        }

                                    }
                                    else
                                    {
                                        JOptionPane.showMessageDialog(null,"Invalid account number","Invalid account",JOptionPane.WARNING_MESSAGE);
                                    }

                                }
                            }
                            catch(Exception ex)
                            {
                                JOptionPane.showMessageDialog(null,"File exception","Error",JOptionPane.WARNING_MESSAGE);
                            }

                            break;   

                            case 5:  try
                            {
                                BufferedReader bufferedReader = new BufferedReader(new FileReader(outputFile));
                                String temp = "";
                                String firstVariable="";
                                String secondVariable="";
                                String thirdVariable="";
                                String fourthVariable="";

                                while((temp = bufferedReader.readLine()) != null)
                                {

                                    String[] values = temp.split(",");    
                                    firstVariable = values[0];
                                    secondVariable = values[1];
                                    thirdVariable= values[2];
                                    fourthVariable = values[3];

                                    BankAccount bankAccount = new BankAccount(firstVariable,secondVariable,Double.parseDouble(thirdVariable),Boolean.parseBoolean(fourthVariable));
                                    bankAccArrayList.add(bankAccount);

                                }

                            }

                            catch(Exception ex)
                            {
                                JOptionPane.showMessageDialog(null,"File exception","Error",JOptionPane.WARNING_MESSAGE);

                            }
                            break;

                            case 6:   PrintWriter writer = new PrintWriter(outputFile); 
                            for(BankAccount tempbankAccountObj: bankAccArrayList)
                            {
                                writer.print(tempbankAccountObj.getCustomerName()+",");
                                writer.print(tempbankAccountObj.getAccountNumber()+",");
                                writer.print(tempbankAccountObj.getCurrentBalance()+",");
                                writer.print(tempbankAccountObj.getStatus());
                                writer.println();

                            }
                            JOptionPane.showMessageDialog(null,"File has been written","File write",JOptionPane.INFORMATION_MESSAGE);
                            writer.close();

                            break;

                            case 7: return;

                            default: JOptionPane.showMessageDialog(null,"please enter a valid choice","Invalid choice",JOptionPane.INFORMATION_MESSAGE);
                            break;

                        }
                    }
                    catch (Exception Ex)
                    {
                        JOptionPane.showMessageDialog(null,"Enter the number in correct format!","Invalid entry",JOptionPane.WARNING_MESSAGE);
                    }
                }

                else
                {
                    JOptionPane.showMessageDialog(null,"You haven't selected any choice","Invalid input",JOptionPane.WARNING_MESSAGE);
                    return;
                }

            }
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(null,"Invalid Input","Invalid input",JOptionPane.INFORMATION_MESSAGE);
        }
    }

    /**
     * method that creates an account by accepting parameters from the user 
     * like customer name and customer number and stores it in the array list
     * 
     * @param custName,
     * @param custNumber passed as parameter to createAccount method
     *                  
     * @return none
     */
    private void createAccount (String custName, String custNumber)
    {   
        BankAccount tempbankAccountObj=new BankAccount(custName,custNumber); 
        bankAccArrayList.add(tempbankAccountObj);
        printAccountDetails(tempbankAccountObj);
    }

    /**
     * Print account details object displays the details of the object once the user enters the customer name and 
     * customer number, it is internally called in the create account method.
     * 
     * @param bankAccountObj
     * @return none
     */
    private void printAccountDetails(BankAccount bankAccountObj)
    {
        JOptionPane.showMessageDialog(null,bankAccountObj,"Account Details",JOptionPane.INFORMATION_MESSAGE); 
    }

    /**
     * This is a private method that returns the index number that the user enters else it returns -1
     * 
     * @param accNum
     * @return foundIndex
     */

    private int getIndex(String accNum)
    {

        for(int i=0;i<bankAccArrayList.size();i++)
        {
            if(accNum.equals(bankAccArrayList.get(i).getAccountNumber()))
            {
                foundIndex=bankAccArrayList.indexOf(bankAccArrayList.get(i));
                return foundIndex;

            }

        }
        return -1;
    }
    /**
     * This is a public method that passes the account number and amount to be withdrawn, the foundIndex method and the makeWithdraw
     * method from the BankAccount class is called, if the index is not found then a message is displayed saying the accountNumber
     * is not found
     * 
     * @param accountNumber,
     * @param withdrawAmount
     * @return none
     */

    private void makeWithdrawl(String accountNumber,double withdrawAmount)
    {

        if(getIndex(accountNumber)!=-1)
        {
            bankAccArrayList.get(foundIndex).makeWithdrawl(withdrawAmount); 
        }
        else
        {
            JOptionPane.showMessageDialog(null,"Account does not exist!!","No Accounts present",JOptionPane.INFORMATION_MESSAGE);
        }

    }

    /**
     * This is a public method that passes the account number and amount to be lodged, the foundIndex method and the makelodgement
     * method from the BankAccount class is called, if the index is not found then a message is displayed saying the accountNumber
     * is not found
     * 
     * @param accountNumber
     * @param lodgeAmount
     * @return none
     */
    private void makeLodgement(String accountNumber,double lodgeAmount)
    {

        if(getIndex(accountNumber)!=-1)
        {
            bankAccArrayList.get(foundIndex).makeLodgement(lodgeAmount);
        }
        else
        {
            JOptionPane.showMessageDialog(null,"Account does not exist!!","No Accounts present",JOptionPane.INFORMATION_MESSAGE);
        }

    }

    /**
     * This is a public method that passes the account number the foundIndex method and the closeaAccount
     * method from the BankAccount class is called, if the index is not found then a message is displayed saying the accountNumber
     * is not found
     * 
     * @param accountNumber
     * @return none
     */
    private void closeAccount(String accountNumber)
    {

        if(getIndex(accountNumber)!=-1)
        {
            bankAccArrayList.get(foundIndex).closeAccount();
        }
        else
        {
            JOptionPane.showMessageDialog(null,"Account does not exist!!","No Accounts present",JOptionPane.INFORMATION_MESSAGE);
        }

    }

    /**
     * This is a public method that passes the account number then the status of the account is checked, if the account is still active
     * it notifies the user saying the account is still active, and gives the option to close the account,then the account is closed and 
     * the account is removed.
     * 
     * @param accountNumber
     * @return none
     */
    private void removeAccount(String accountNumber)
    {

        if(getIndex(accountNumber)!=-1)
        {

            if((bankAccArrayList.get(foundIndex).getStatus()==false)&&(bankAccArrayList.get(foundIndex).getCurrentBalance()==0))
            {

                bankAccArrayList.remove(foundIndex);

            }
            else if((bankAccArrayList.get(foundIndex).getStatus()==false)&&(bankAccArrayList.get(foundIndex).getCurrentBalance()>0))
            {
                int dialogResult = JOptionPane.showConfirmDialog(null," This account has a balance,do you wish to withdraw this balance " + 
                        "so as to remove the account ?"," Balance in inactive account",JOptionPane.PLAIN_MESSAGE);
                if(dialogResult == JOptionPane.YES_OPTION)
                {
                    bankAccArrayList.get(foundIndex).setAccountStatus();
                    bankAccArrayList.get(foundIndex).makeWithdrawl(bankAccArrayList.get(foundIndex).getCurrentBalance());
                    bankAccArrayList.get(foundIndex).setAccountStatus();
                    bankAccArrayList.remove(foundIndex);
                    JOptionPane.showMessageDialog(null,"Account Removed","Confirmation",JOptionPane.PLAIN_MESSAGE);
                }
                bankAccArrayList.get(foundIndex).closeAccount();
                bankAccArrayList.remove(foundIndex);
                JOptionPane.showMessageDialog(null,"Account has been removed!!","Account removed",JOptionPane.INFORMATION_MESSAGE);

            }
            else if((bankAccArrayList.get(foundIndex).getStatus()==true)&&(bankAccArrayList.get(foundIndex).getCurrentBalance()==0))
            {
                int dialogResult = JOptionPane.showConfirmDialog(null," This account still has an active status, do you wish to change its status so as to remove account ?"  
                    ,"Account Active",JOptionPane.PLAIN_MESSAGE); 
                if(dialogResult == JOptionPane.YES_OPTION)
                {
                    bankAccArrayList.get(foundIndex).setAccountStatus();
                    bankAccArrayList.remove(foundIndex);
                    JOptionPane.showMessageDialog(null,"Account Removed","Confirmation",JOptionPane.PLAIN_MESSAGE);
                }
            }
            else
            {
                int dialogResult = JOptionPane.showConfirmDialog(null," This account still has an active status and a balance, do you wish to close the account so as remove it" 
                    ,"Account Active with Balance",JOptionPane.PLAIN_MESSAGE);
                if(dialogResult == JOptionPane.YES_OPTION)
                {
                    bankAccArrayList.get(foundIndex).closeAccount();
                    bankAccArrayList.remove(foundIndex);
                    JOptionPane.showMessageDialog(null,"Account Removed","Confirmation",JOptionPane.PLAIN_MESSAGE);

                }

            }
            
        }
        else
        {
            JOptionPane.showMessageDialog(null,"Account does not exist!!","No Accounts present",JOptionPane.INFORMATION_MESSAGE);
        }

    }

    /**
     * This is a public method that passes the account number, the account details of the object in the particular index is displayed
     * by overriding the tostring().
     * 
     * @param accountNumber
     * @return none
     */
    private void displayAccount(String accountNumber)
    {

        if(getIndex(accountNumber)!=-1)
        {
            JOptionPane.showMessageDialog(null,bankAccArrayList.get(foundIndex).toString(),"Account Details",JOptionPane.INFORMATION_MESSAGE);
        }
        else
        {
            JOptionPane.showMessageDialog(null,"Account does not exist!!","No Accounts present",JOptionPane.INFORMATION_MESSAGE);
        }

    }

    /**
     * This methods lists all accounts that have been entered with name, account number, status and balance
     * if there are no accounts then it displays a message showing that there are no accounts
     * and a try-catch block to handle any exceptions.
     * 
     * @param none
     * @return none
     */
    private void listAllAccounts()
    { 
        try
        {

            String accountDetails="";

            for(BankAccount bankAccount: bankAccArrayList)
            {
                accountDetails+=bankAccount+"\n\n";

            }
            if(accountDetails.isEmpty())
            {

                JOptionPane.showMessageDialog(null,"There are no accounts to display","No Accounts present",JOptionPane.INFORMATION_MESSAGE);

            } 
            else
            {
                JOptionPane.showMessageDialog(null,"All Account details: \n\n"+accountDetails,"Account details",JOptionPane.INFORMATION_MESSAGE); 
            }  
        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(null,"Array List Exception","Exception",JOptionPane.WARNING_MESSAGE); 
        }

    }
    /**
     * This method lists all accounts that are active(true) in a JOptionPane and a try catch block to handle any exception
     * 
     * @param none
     * @return none
     */
    private void listAllOpenAccounts()
    {
        try
        {
            String accountDetails="";

            for(BankAccount bankAccount: bankAccArrayList)
            {

                if(bankAccount.getStatus()==true)
                {

                    accountDetails+=bankAccount+"\n\n";

                }

            }    

            if(accountDetails.isEmpty())
            {

                JOptionPane.showMessageDialog(null,"There are no accounts to display","No Accounts present",JOptionPane.INFORMATION_MESSAGE);

            } 
            else
            {
                JOptionPane.showMessageDialog(null,"All Account details: \n\n"+accountDetails,"Account details",JOptionPane.INFORMATION_MESSAGE); 
            } 

        }
        catch(Exception ex)
        {
            JOptionPane.showMessageDialog(null,"Array Index out of Bound Exception","Exception",JOptionPane.WARNING_MESSAGE); 
        }
    }

}