

/* Student Name: Shreyas Lokanath
 * Student ID: 17231972
 * Date:9/11/2017
 * Assignment: 4
 * Task: create an application for My investment bank corp
 * for InvestQ product
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        //variables declared to use them for the proceed function
        double amount;
        double interestRate;
        double investmentDuration;
        double amountCalculated;
        double interestEarned;
        //variables that contain the value after calculating the interest
        double oneMonthAmount;
        double threeMonthsAmount;
        double sixMonthsAmount;
        double twelveMonthsAmount;
        double sixMonthwithBonus;
        double twelveMonthwithBonus;

        //series of constants declared, which have the output file path, inerest rates for different slabs
        const string outPutFilePath = @"F:\MS806-BusinessApplicationProgramming\Assignments\Assignment4-3-11-2017\Assignment4\transactionDetails.txt";
        const string emailidAddressPattern = (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        const string numberPattern = ("^[0-9]{12}");
        const double lowerInterestRate1 = 0.50000;
        const double lowerInterestRate2 = 0.62500;
        const double lowerInterestRate3 = 0.71250;
        const double lowerInterestRate4 = 1.12500;

        const double higherInterestRate1 = 0.60000;
        const double higherinterestRate2 = 0.72500; 
        const double higherInterestrate3 = 0.81250; 
        const double higherInterestrate4 = 1.22500;
        //constant that contain teh terms available for investment
        const double firstTerm = 1;
        const double secondTerm = 3;
        const double thirdTerm = 6;
        const double fourthTerm = 12;
        // constant to declare the lower investment slab
        const double lowerInvestmentSlab = 100000;
        //consant to declare the higher investment slab
        const double higherInvestmentSlab = 1000000;

        //This method calculates the compound interest and returns the value as a double and the data is received as 
        //an argument
        private double CalculateCompoundInterest(double principal, double interestRate, double duration)
        {
            double totalValue;
            const double compoundingsAYear=12;
            const double monthsInAYear = 12;
            totalValue = (principal * Math.Pow(1 +((interestRate / 100/compoundingsAYear)),(compoundingsAYear*duration/monthsInAYear)));
           

            return totalValue;
        }

      
        //event handler for display button clcik
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //bonus for customer investment more than 5000
            const double bonus = 5000;

            try
            {


                amount = double.Parse(amountTextBox.Text);
                //if amount is greater than 0, then enters the loop
                if (amount > 0)
                {

                    //checks the investment category
                    if (amount <= lowerInvestmentSlab)
                    {
                        //calculates the amount for each category with its corresponding terms and rate of interest
                        oneMonthAmount = CalculateCompoundInterest(amount, lowerInterestRate1, firstTerm);
                        threeMonthsAmount = CalculateCompoundInterest(amount, lowerInterestRate2, secondTerm);
                        sixMonthsAmount = CalculateCompoundInterest(amount, lowerInterestRate3, thirdTerm);
                        twelveMonthsAmount = CalculateCompoundInterest(amount, lowerInterestRate4, fourthTerm);

                        
                        //displayed as a text to the radio button
                        termRadioButton1.Text = ("Duration: " + firstTerm + " Rate of Interest: " + lowerInterestRate1 +
                       " Amount on Maturity: " +oneMonthAmount.ToString("n3"));

                        termRadioButton2.Text = ("Duration: " + secondTerm + " Rate of Interest: " + lowerInterestRate2 +
                       " Amount on Maturity: " +threeMonthsAmount.ToString("n3"));

                        termRadioButton3.Text = ("Duration: " + thirdTerm + " Rate of Interest: " + lowerInterestRate3 +
                       " Amount on Maturity: " + sixMonthsAmount.ToString("n3"));

                        termRadioButton4.Text = ("Duration: " + fourthTerm + " Rate of Interest: " + lowerInterestRate4 +
                       " Amount on Maturity: " + twelveMonthsAmount.ToString("n3"));

                    }
                    else
                    {
                        //the interest rates and terms of the higher investment slab are calculated
                        oneMonthAmount = CalculateCompoundInterest(amount, higherInterestRate1, firstTerm);
                        threeMonthsAmount = CalculateCompoundInterest(amount, higherinterestRate2, secondTerm);
                        sixMonthsAmount = CalculateCompoundInterest(amount, higherInterestrate3, thirdTerm);
                        twelveMonthsAmount = CalculateCompoundInterest(amount, higherInterestrate4, fourthTerm);
                        //calculated for investements more than 1,000,000
                        sixMonthwithBonus = CalculateCompoundInterest(amount, higherInterestrate3, thirdTerm) + bonus;
                        twelveMonthwithBonus = CalculateCompoundInterest(amount, higherInterestrate4, fourthTerm) + bonus;
                        //displayed as a text to the radio button and checks for those with investment rate more than 
                        //1,000,000 for which bonus is added
                        termRadioButton1.Text = ("Duration: " + firstTerm + " Rate of Interest: " + higherInterestRate1 +
                       " Amount on Maturity: " + oneMonthAmount.ToString("n3"));

                        termRadioButton2.Text = ("Duration: " + secondTerm + " Rate of Interest: " + higherinterestRate2 +
                       " Amount on Maturity: " +threeMonthsAmount.ToString("n3"));

                        if (amount >= higherInvestmentSlab)
                        {
                            termRadioButton3.Text = ("Duration: " + thirdTerm + " Rate of Interest: " + higherInterestrate3 +
                           " Amount on Maturity: " +  sixMonthwithBonus.ToString("n3"));

                            termRadioButton4.Text = ("Duration: " + fourthTerm + " Rate of Interest: " + higherInterestrate4 +
                           " Amount on Maturity: " + twelveMonthwithBonus.ToString("n3"));
                        }
                        //the bonus is not added and the values of higher investment category are allocated
                        else
                        {
                            termRadioButton3.Text = ("Duration: " + thirdTerm + " Rate of Interest: " + higherInterestrate3 +
                          " Amount on Maturity: " + sixMonthsAmount.ToString("n3"));

                            termRadioButton4.Text = ("Duration: " + fourthTerm + " Rate of Interest: " + higherInterestrate4 +
                           " Amount on Maturity: " + twelveMonthsAmount.ToString("n3"));
                        }

                    }

                    //set of controls that are enabled/disabled,visible/invisible
                    radioButtonGroupBox.Visible = true;
                    proceedButton.Visible = true;
                    radioButtonGroupBox.Enabled = true;
                    resetButton.Visible = true;
                    exitButton.Visible = true;
                    bankPictureBox.Visible = false;
                    productPictureBox.Visible = false;
                    descriptionLabel.Visible = false;


                }
                //exception to handle if there are no investements
                else
                {
                    MessageBox.Show("Your Investment should be more than 0");
                    amountTextBox.Clear();
                    amountTextBox.Focus();
                }
            }
            //invaid number format exception handling
            catch
            {
                MessageBox.Show("Enter the number in the correct format!","Incorrect Number format alert!");
                amountTextBox.Clear();
                amountTextBox.Focus();
            }
        }
        //afer the investement is chosen then this button is clicked
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            
            //checks if none of the radio buttons are checked and throws an exception
            if(defaultRadioButton.Checked==true)
            {
                
                MessageBox.Show("Please choose an investment plan","Choose Investment plan Alert!");
                customerPanel.Visible = false;
            }
            else
            {
                //the customer panel is made visible and all display panel is invisible
                customerPanel.Visible = true;

                //values are prepopulated in the form
                selectedTermTextBox.Text = investmentDuration.ToString();
                selectedInterestrateTextBox.Text = interestRate.ToString();
                amountMaturityTextBox.Text = amountCalculated.ToString("c");
                interestEarnedTextBox.Text = interestEarned.ToString("c");
                amountInvestedTextBox.Text = amount.ToString("c");

                amountTextBox.Enabled = false;
                radioButtonGroupBox.Enabled = false;
                displayPanel.Visible = false;
               
            }
           
        }
        //event handler on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            defaultRadioButton.Checked = true;
        }


        //on click of confirm button
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //set of strings to store the values of the text box
            string employeeId = employeeIDTextBox.Text;
            string clientId = clientIdTextBox.Text;
            string uniqueId = transacIdTextBox.Text;
            string emailAddress = emailIdTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string phoneNumber = numberTextBox.Text;
            string transactionID = employeeIDTextBox.Text + "-" + clientIdTextBox.Text + "-" + transacIdTextBox.Text;

            
            //set of regEx object with patterns for matching
            Match employeeMatch = Regex.Match(employeeId, "^[a-zA-Z0-9]{3}");
            Match clientIDMatch = Regex.Match(clientId, "^[a-zA-Z0-9]{4}");
            Match uniqueIDMatch = Regex.Match(uniqueId, "^[a-zA-Z0-9]{3}");
            Match emailAddressMatch = Regex.Match(emailAddress, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match firstNameMatch = Regex.Match(firstName, @"^[A-z][A-z|\.|\s]+$");
            Match lastNameMatch = Regex.Match(lastName, @"^[A-z][A-z|\.|\s]+$");
            Match phoneNumberMatch = Regex.Match(phoneNumber, "^[0-9]{10}");
            //if the regex condition doesnt match
            if (employeeMatch.Success!=true)
            {
                //message box which prompts the user to enter in a correct format
                MessageBox.Show("Enter your Employee id!!", "EmployeeId validation");
                //it preselects the the text for a 1 button delete
                employeeIDTextBox.SelectAll();
                //the focus is returned to the text box
                employeeIDTextBox.Focus();
            }
            //if the regex condition doesnt match
            else if (clientIDMatch.Success!=true)
            {
                MessageBox.Show("Enter client Id!! ", "Client Id validation");
                clientIdTextBox.SelectAll();
                clientIdTextBox.Focus();
            }
            //if the regex condition doesnt match
            else if (uniqueIDMatch.Success!=true)
            {
                MessageBox.Show("Enter Unique Transaction Id!! ", "Unique Id validation");
                transacIdTextBox.SelectAll();
                transacIdTextBox.Focus();
            }
            //if the regex condition doesnt match
            else if (emailAddressMatch.Success!=true)
            {
                MessageBox.Show("Enter Email Id!! ", "Email Id validation");
                emailIdTextBox.SelectAll();
                emailIdTextBox.Focus();
            }
            //if the regex condition doesnt match
            else if (firstNameMatch.Success!=true)
            {
                MessageBox.Show("Enter first Name!! ", "First Name validation");
                firstNameTextBox.SelectAll();
                firstNameTextBox.Focus();
            }
            //if the regex condition doesnt match
            else if (lastNameMatch.Success!=true)
            {
                MessageBox.Show("Enter last name!! ", "Last Name validation");
                lastNameTextBox.SelectAll();
                lastNameTextBox.Focus();
            }
            //if the regex condition doesnt match
            else if (phoneNumberMatch.Success!=true)
            {
                MessageBox.Show("Phone number should contain 10 digits!! ", "Phone number validation");
                numberTextBox.SelectAll();
                numberTextBox.Focus();
            }
            //if all the conditions match then the message box is shown for confirmation
            else
            {
                DialogResult okResult;

                okResult = MessageBox.Show("Summary of Investment chosen: \n Customer Transaction ID: " + transactionID +
                                "\n Customer Email Id: " + emailIdTextBox.Text + "\n First Name: " + firstNameTextBox.Text + "\n Last Name: " + lastNameTextBox.Text +
                                "\n Customer Contact: " + numberTextBox.Text +"\n Amount Invested: "+amount +"\n Term Selected: " + selectedTermTextBox.Text + "\n Interest Rate: " +
                                selectedInterestrateTextBox.Text + "\n Amount on Maturity: " + amountMaturityTextBox.Text+
                                "\n Interest Earned on Maturity:"+interestEarnedTextBox.Text, "Confirm Booking", MessageBoxButtons.OKCancel);
                //if the result is ok
               if(okResult==DialogResult.OK)
                {
                    try
                    {
                        //stream writer object is created and all file is written 
                        StreamWriter outputDetails;
                        //if the file doesnt exist, create and write
                        if (!File.Exists(outPutFilePath))
                        {
                            //using the stream writer object the file is opened and 
                            //it is written in the file using write line method
                            outputDetails = File.CreateText(outPutFilePath);
                            outputDetails.WriteLine(transactionID);

                            outputDetails.WriteLine(emailAddress);

                            outputDetails.WriteLine(firstName);
                            outputDetails.WriteLine(lastName);
                            outputDetails.WriteLine(phoneNumber);
                            outputDetails.WriteLine(amount);
                            outputDetails.WriteLine(selectedTermTextBox.Text);
                            outputDetails.WriteLine(selectedInterestrateTextBox.Text);
                            outputDetails.WriteLine(amountMaturityTextBox.Text);
                            outputDetails.WriteLine(interestEarnedTextBox.Text);
                            

                            outputDetails.Close();
                        }
                        //if exists then append
                        else
                        {
                            outputDetails=File.AppendText(outPutFilePath);

                            outputDetails.WriteLine(transactionID);

                            outputDetails.WriteLine(emailAddress);

                            outputDetails.WriteLine(firstName);
                            outputDetails.WriteLine(lastName);
                            outputDetails.WriteLine(phoneNumber);
                            outputDetails.WriteLine(amount);
                            outputDetails.WriteLine(selectedTermTextBox.Text);
                            outputDetails.WriteLine(selectedInterestrateTextBox.Text);
                            outputDetails.WriteLine(amountMaturityTextBox.Text);
                            outputDetails.WriteLine(interestEarnedTextBox.Text);
                            

                            outputDetails.Close();
                        }

                      
                    }
                    //file write exception
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    


                    //confirmation message to show that booking is confirmed
                    MessageBox.Show("Your booking has been confirmed", "Booking confirmation");
                }

            }



        
        
        }
        // radio button handlers which assign the value from the method to a variable
        private void TermRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(amount<=lowerInvestmentSlab)
            {
                interestRate = lowerInterestRate1;
                investmentDuration = firstTerm;
                amountCalculated = oneMonthAmount;
                interestEarned = (amountCalculated - amount);

            }
            else
            {
                interestRate = higherInterestRate1;
                investmentDuration = secondTerm;
                amountCalculated = oneMonthAmount;
                interestEarned = (amountCalculated - amount);
            }
        }
        // radio button handlers which assign the value from the method to a variable
        private void TermRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (amount <= lowerInvestmentSlab)
            {
                interestRate = lowerInterestRate2;
                investmentDuration = secondTerm;
                amountCalculated = threeMonthsAmount;
                interestEarned=(amountCalculated-amount);

            }
            else
            {
                interestRate = higherinterestRate2;
                investmentDuration = secondTerm;
                amountCalculated = threeMonthsAmount;
                interestEarned = (amountCalculated - amount);
            }
        }
        // radio button handlers which assign the value from the method to a variable
        private void TermRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (amount <= lowerInvestmentSlab)
            {
                interestRate = lowerInterestRate3;
                investmentDuration = thirdTerm;
                amountCalculated = sixMonthsAmount;
                interestEarned = (amountCalculated - amount);

            }
            else
            {
                interestRate = higherInterestrate3;
                investmentDuration = thirdTerm;
                //for adding the bonus for customers with higher investment
                if (amount >= higherInvestmentSlab)
                {
                    amountCalculated = sixMonthwithBonus;
                    interestEarned = (amountCalculated - amount);
                }
                else
                {
                    amountCalculated = sixMonthsAmount;
                    interestEarned = (amountCalculated - amount);
                }
            }
        }
        // radio button handlers which assign the value from the method to a variable
        private void TermRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (amount <= lowerInvestmentSlab)
            {
                interestRate = lowerInterestRate4;
                investmentDuration = fourthTerm;
                amountCalculated = twelveMonthsAmount;
                interestEarned = (amountCalculated - amount);

            }
            else
            {
                interestRate = higherInterestrate4;
                investmentDuration = fourthTerm;
                //for adding the bonus for customers with higher investment
                if (amount >= higherInvestmentSlab)
                {
                    amountCalculated = twelveMonthwithBonus;
                    interestEarned = (amountCalculated - amount);
                }
                else
                {
                    amountCalculated = twelveMonthsAmount;
                    interestEarned = (amountCalculated - amount);
                }
            }
        }
        //searches the transactions stored in the file using transaction Number and email address
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //exception if file doesnt exist in that path
            if (File.Exists(outPutFilePath))
            {
               

                    string searchString;
                    listViewForTransactions.Items.Clear();
                    
                    StreamReader outPutFileReader;
                    bool transactionfound = false;
                    int numberofEmailSearches = 0;
                    string findTransactionId;
                    string findemailId;
                    
                    try
                    {

                        outPutFileReader = File.OpenText(outPutFilePath);
                        //checks the method of searching
                        if (transactionRadioButton.Checked == true)
                        {
                        searchString = transacNumberSearchTextBox.Text;
                            
                            const int searchCount = 9;
                          //searches for an empty string
                            if (searchString != "")
                            {
                                //searches for the transaction till the end of file and breaks if
                                //found and comes out of the loop and is displayed in the list view
                                while (!outPutFileReader.EndOfStream)
                                {
                                    findTransactionId = outPutFileReader.ReadLine();


                                    if (findTransactionId.Contains(searchString))

                                    {
                                    //list view object to display in the list view
                                        ListViewItem listviewdisplay = new ListViewItem(searchString);

                                        listViewForTransactions.Items.Add(listviewdisplay);
                                    //searches for the transaction id til the search count limit
                                        for (int i = 0; i < searchCount; i++)
                                        {
                                            findTransactionId = outPutFileReader.ReadLine();
                                            listviewdisplay.SubItems.Add(findTransactionId);

                                        }
                                        transactionfound = true;

                                        break;

                                    }


                                }
                                //if the condition is not true then the user has entered a wrong transaction number
                                if (transactionfound != true)
                                {
                                    listViewForTransactions.Visible = false;
                                    MessageBox.Show("transaction Id not found!!","No transaction Id Alert");
                                    transacNumberSearchTextBox.SelectAll();
                                    transacNumberSearchTextBox.Focus();

                                }
                                //the transaction id is found
                                else
                                {
                                    listViewForTransactions.Visible = true;
                                    MessageBox.Show("transaction found!");
                                    transacNumberSearchTextBox.Focus();
                                }
                            }
                            //prompts the user to enter the correct number and the focus is returnes
                            else
                            {
                                MessageBox.Show("Enter a correct transaction number");
                                transacNumberSearchTextBox.SelectAll();
                                transacNumberSearchTextBox.Focus();
                            }
                        }
                        //if it is email id search
                        if (emailIdRadioButton.Checked == true)
                        {
                            searchString = emailIdSearchTextBox.Text;
                            const int searchCount = 8;

                            if (searchString != "")
                            {
                                {
                                //searches for the transactions with similar email id till the end of
                                //the file and is added one by one to the list view
                                    while (!outPutFileReader.EndOfStream)
                                    {
                                        findTransactionId = outPutFileReader.ReadLine();
                                        findemailId = outPutFileReader.ReadLine();

                                        if (findemailId.Contains(searchString))
                                        {
                                            ListViewItem listviewdisplay = new ListViewItem(findTransactionId);
                                            listViewForTransactions.Items.Add(listviewdisplay);
                                            listviewdisplay.SubItems.Add(findemailId);


                                            for (int i = 0; i < searchCount; i++)
                                            {
                                                findemailId = outPutFileReader.ReadLine();
                                                listviewdisplay.SubItems.Add(findemailId);

                                            }
                                            numberofEmailSearches++;
                                        }
                                        //if not found then it loops till the search count limit
                                        //to find the next set of transactions
                                        else
                                        {
                                            for (int i = 0; i < searchCount; i++)
                                            {
                                                findemailId = outPutFileReader.ReadLine();
                                            }
                                        }
                                    }
                                    //if search count is greater than 0 then the email id entered is 
                                    //correct
                                    if (numberofEmailSearches >= 1)
                                    {

                                        listViewForTransactions.Visible = true;
                                        MessageBox.Show("Transactions Found!!");
                                    }
                                    //incorrect email id entered
                                    else
                                    {
                                        MessageBox.Show("Transactions not found","No transactions Alert!");
                                        listViewForTransactions.Visible = false;
                                        emailIdSearchTextBox.SelectAll();
                                        emailIdSearchTextBox.Focus();
                                    }
                                }
                            }
                            //incorrect email address alert
                            else
                            {
                                MessageBox.Show("Enter correct email address","Incorrect email address alert");
                                emailIdSearchTextBox.Focus();
                            }
                        }


                        //reader object is closed
                        outPutFileReader.Close();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No transactions present!!","No Transaction Alert");
                    }

                
                

            }
            else
            {
                MessageBox.Show("File doesn't exist,Please create a file","No file Alert!");
            }
        }


        //radio button event handler for the search panel radio buttons
            private void TransactionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            transacNumberSearchTextBox.Visible = true;
            emailIdSearchTextBox.Visible = false;
            emailIdSearchTextBox.Clear();
        
        }
        //radio button event handler for the search panel radio buttons
        private void EmailIDradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            transacNumberSearchTextBox.Visible = false;
            transacNumberSearchTextBox.Clear();
            emailIdSearchTextBox.Visible = true;
        }

        //event handler which clears the fields, enables/disbales controls on click of this button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            amountTextBox.Clear();
            selectedTermTextBox.Clear();
            selectedInterestrateTextBox.Clear();
            amountMaturityTextBox.Clear();
            amountInvestedTextBox.Clear();
            interestEarnedTextBox.Clear();
            employeeIDTextBox.Clear();
            clientIdTextBox.Clear();
            transacIdTextBox.Clear();
            emailIdTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            numberTextBox.Clear();
            displayPanel.Visible = true;
            customerPanel.Visible = false;
            employeeIDTextBox.Clear();
            clientIdTextBox.Clear();
            transacIdTextBox.Clear();
            firstNameTextBox.Clear();
            emailIdTextBox.Clear();
            lastNameTextBox.Clear();
            numberTextBox.Clear();
            amountInvestedTextBox.Clear();



            amountTextBox.Enabled = true;
            radioButtonGroupBox.Visible = false;
            
            defaultRadioButton.Checked = true;
        }
        //calculates the summary of transactions saved in the file
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //exception to handle when there are no transactions or file is not present
            try
            {
                StreamReader summaryReader;
                //creates a stream reader, temporary variables and loops till the end of file
                summaryReader = File.OpenText(outPutFilePath);
                transactionNumbersListBox.Items.Clear();

                double readamountInvested = 0;
                double readDurationOfInvestement = 0;
                double readInterestRate = 0;
                double readAmountOnMaturity = 0;
                double readtotalInterestEarned = 0;
                double totalInvestment = 0;
                double totalInvestmentDuration = 0;
                double totalAmountOnMaturity = 0;
                double totalInterestEarned = 0;
                double averageDuration = 0;
                int investementsCount = 0;
                //values are assigned to the temporary variables and loops till the end of file
                while (!summaryReader.EndOfStream)
                {
                    string readTransactionId = summaryReader.ReadLine();
                    transactionNumbersListBox.Items.Add(readTransactionId);
                    string readEmailId = summaryReader.ReadLine();
                    string readFirstName = summaryReader.ReadLine();
                    string readLastName = summaryReader.ReadLine();
                    string readPhoneNumber = summaryReader.ReadLine();
                    string readprincipal = summaryReader.ReadLine();
                    string readDuration = summaryReader.ReadLine();
                    string readInterest = summaryReader.ReadLine();
                    string readAmount = summaryReader.ReadLine();
                    string interestGained = summaryReader.ReadLine();

                    investementsCount = investementsCount + 1;
                    //string valuesfrom file are parsed as double
                    readamountInvested = double.Parse(readprincipal);
                    readDurationOfInvestement = double.Parse(readDuration);
                    readInterestRate = double.Parse(readInterest);
                    readAmountOnMaturity = double.Parse(readAmount);
                    readtotalInterestEarned = double.Parse(interestGained);

                    //total investment, duration, interest are added through recursive addition
                    totalInvestment += readamountInvested;
                    totalInvestmentDuration += readDurationOfInvestement;
                    totalAmountOnMaturity += readAmountOnMaturity;
                    totalInterestEarned += readtotalInterestEarned;
                    //average duration is calculated
                    averageDuration = (totalInvestmentDuration / investementsCount);




                }
                //transaction numbers are saved in the listbox and the values are displayed in the text box
                totalAmountInvestedTextBox.Text = totalInvestment.ToString("c");
                amountOnMaturityTextBox.Text = totalAmountOnMaturity.ToString("c");
                totalInterestEarnedTextBox.Text = totalInterestEarned.ToString("n2");
                averageDurationTextBox.Text = averageDuration.ToString("n2");

                summaryReader.Close();
            }
            //handles when no file exists
            catch(Exception )
            {
                MessageBox.Show("File doesn't exist!!","No File Alert");
                amountTextBox.Focus();
            }
            
        }

      

        //exits the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //clears the summary panel fields
        private void clearSumaryButton_Click(object sender, EventArgs e)
        {
            transactionNumbersListBox.Items.Clear();
            totalAmountInvestedTextBox.Clear();
            amountOnMaturityTextBox.Clear();
            totalInterestEarnedTextBox.Clear();
            averageDurationTextBox.Clear();
        }
    }
 }