/*This program calculates the ticket prices of 3 different ticket types
the user provides the inputs for number of tickets and the prices for each ticket type

calculatePriceTicketA, calculatePriceTicketB,calculatePriceTicketC are the 3 public methods that
calculate the prices of each ticket type and return the sum in the double format.

@author: Shreyas Lokanath
@date and version: 23/07/2018/ 1.1
*/

//imports scanner clss
import java.util.Scanner;

public class TotalSaleofConcert {

	
    String numberOfATicketsSold;
    int ticketsSoldA;
    String priceOfATicket;
    double ticketPriceA;

	
    String numberOfBTicketsSold;
    int ticketsSoldB;
    String priceOfBTicket;
    double ticketPriceB;

    String numberOfCTicketsSold;
    int ticketsSoldC;
    String priceOfCTicket;
    double ticketPriceC;

	/*This method calculates the total price of ticket type A and returns the sum in 
	a double format
	@param none
	@return resultOfTicketA
	*/
    public double calculatePriceTicketA() {

        double resultOfTicketA = 0.0;
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("Enter the number of A tickets ");
            numberOfATicketsSold = scanner.nextLine();
            try {
                ticketsSoldA = Integer.parseInt(numberOfATicketsSold);
                if (ticketsSoldA >= 0) {
                    while (true) {
                        System.out.println("Enter the price of ticket type A");
                        priceOfATicket = scanner.nextLine();
                        try {
                            ticketPriceA=Double.parseDouble(priceOfATicket);
                            if (ticketPriceA > 0.0) {
                                resultOfTicketA = ticketsSoldA * ticketPriceA;
                                return resultOfTicketA;
                            } else {
                                System.out.println("Enter valid ticket price of A");

                            }
                        }
                        catch (Exception ex)
                        {
                            System.out.println("In-correct type of input");
                        }
                    }

                }
            } catch (Exception ex) {

            }
            System.out.println("Please enter a valid integer");

        }
    }

	/*This method calculates the total price of ticket type B and returns the sum in 
	a double format
	@param none
	@return resultOfTicketB
	*/
    public double calculatePriceTicketB()
    {
        double resultOfTicketB = 0.0;
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("Enter the number of B tickets ");
            numberOfBTicketsSold = scanner.nextLine();
            try {
                ticketsSoldB = Integer.parseInt(numberOfBTicketsSold);
                if (ticketsSoldB >= 0) {

                    while (true) {
                        System.out.println("Enter the price of ticket type B");
                        priceOfBTicket = scanner.nextLine();
                        try
                        {
                            ticketPriceB=Double.parseDouble(priceOfBTicket);
                            if (ticketPriceB > 0.0) {
                                resultOfTicketB = ticketsSoldB * ticketPriceB;
                                return resultOfTicketB;
                            } else {
                                System.out.println("Enter valid ticket price of B");

                            }
                        }
                        catch (Exception ex) {
                            System.out.println("In-correct type of input");
                        }
                    }
                }
            } catch (Exception ex) {
            }
            System.out.println("Please enter a valid integer");
        }
    }

	/*This method calculates the total price of ticket type C and returns the sum in 
	a double format
	@param none
	@return resultOfTicketC
	*/
    public double calculatePriceTicketC()
    {
        double resultOfTicketC = 0.0;
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("Enter the number of C tickets ");
            numberOfCTicketsSold = scanner.nextLine();
            try {
                ticketsSoldC = Integer.parseInt(numberOfCTicketsSold);
                if (ticketsSoldC >= 0) {

                    while (true) {
                        System.out.println("Enter the price of ticket type C");
                        priceOfCTicket = scanner.nextLine();
                        try
                        {
                            ticketPriceC=Double.parseDouble(priceOfCTicket);

                            if (ticketPriceC > 0.0) {
                                resultOfTicketC = ticketsSoldC * ticketPriceC;
                                return resultOfTicketC;
                            } else {
                                System.out.println("Enter valid ticket price of C");
                            }
                        }
                        catch (Exception ex)
                        {
                            System.out.println("In-correct type of input");
                        }
                    }
                }
            } catch (Exception ex) {

            }
            System.out.println("Please enter a valid integer");
        }
    }

	/*Main method calculates creates an object of the class and the overall result of the concert is
	printed in the format expected.*/
    public static void main(String[] args)
    {
        double grandTotalForTheConcert;

        TotalSaleofConcert totalSaleofConcert=new TotalSaleofConcert();

        double totalPriceOfTicketA= totalSaleofConcert.calculatePriceTicketA();
        double totalPriceOfTicketB= totalSaleofConcert.calculatePriceTicketB();
        double totalPriceOfTicketC= totalSaleofConcert.calculatePriceTicketC();

        grandTotalForTheConcert=totalPriceOfTicketA+totalPriceOfTicketB+totalPriceOfTicketC;

        System.out.println("\n \t \t Tickets Sold \t Price per Ticket");
        System.out.println("\n A ticket\t \t"+ totalSaleofConcert.numberOfATicketsSold+"\t"+totalSaleofConcert.priceOfATicket);
        System.out.println("\n B ticket\t \t"+ totalSaleofConcert.numberOfBTicketsSold+"\t"+totalSaleofConcert.priceOfCTicket);
        System.out.println("\n C ticket\t \t"+ totalSaleofConcert.numberOfCTicketsSold+"\t"+totalSaleofConcert.priceOfCTicket);

        System.out.println("\n\n Total Sales "+grandTotalForTheConcert);
    }
}
