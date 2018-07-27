/*This is a java program to calculate if a given input is a leap year or not
*
* Once the program is compiled it asks the user for an input, the user cam input year
* after 0 AD, it contains a method calculateLeapYear() to which the input year is passed.
*
* The method calculates and returns the result saying whether it is a leap year or not.
*
* @author: Shreyas Lokanath
* Version: 0.1 or 27/07/2018
*
* */

//imports the scanner class
import java.util.Scanner;


public class LeapYear {

    // public class that accepts the input year from the user that is passed from the main mehtod
    // and returns a string that indicates whether the year is a leap year or not
    //@param inputYear
    //@return String
    public String calculateLeapYear(int inputYear)
    {
        int input=inputYear;

        if((input%4==0)&&(input%100!=0))
        {
            return "The year "+input+" is a leap year";
        }
        else if ((input%4==0)&&(input%100==0)&&(input%400==0))
        {
            return "The year "+input+" is a leap year";
        }
        else
        {
            return "The year "+input+" is not a leap year";
        }

    }

    //Main method that creates an object of the class and accepts the user input
    //it passes the inputYear to the calculateLeapYear Method with inputYear as the
    //parameter.
    public static void main(String[] args)
    {
        Scanner scanner=new Scanner(System.in);
        LeapYear leapYear=new LeapYear();
        int inputYear;
        String result;

        while(true)
        {

            try
            {
                System.out.println("Enter the year: ");
                inputYear=scanner.nextInt();
                if(inputYear>0)
                {
                    result=leapYear.calculateLeapYear(inputYear);
                    System.out.println(result);
                    break;
                }
                else
                {
                    System.out.println("Enter a valid input");
                    continue;
                }
            }
            catch (Exception ex)
            {
                System.out.println("Enter a valid input");
                scanner.next();
            }
        }

    }
}
