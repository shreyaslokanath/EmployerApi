/*Sample code for a store to check if an employee enters the
//correct items and the correct prices for a particular business transaction
// if not the program gives an output with the item name and price for which
//an incorrect price was entered
//
@Author: Shreyas Lokanath
@version: 1.0 or 22/06/2018
*/

import java.util.Scanner;

public class FindIncorrectEntries {

    /*
    This method calculates the number of fraudlent entries by comparing each value in the
    fraudItems array with actualItems array, if the value is found their prices
    are checked if they are unequal that particular entry is rendered fraud

    @param checkActualItems, checkActualPrices, checkIncorrectItems,checkIncorrectPrices
    @return count
    * */
    public int checkForIncorrectEntry(String[] checkActualItems, double[] checkActualPrices, String[] checkIncorrectItems,double[] checkIncorrectPrices)
    {
       int count=0;
            for (int i = 0; i < checkIncorrectItems.length; i++) {
                for (int j = 0; j < checkActualItems.length; j++) {
                    if (checkIncorrectItems[i].equals(checkActualItems[j])) {
                        if (checkIncorrectPrices[i] != checkActualPrices[j]) {
                            count++;
                        }
                    }
                }
            }
            return count;


    }
    /*This method accepts the value from the user and enters the items into the
    actual items array
    @param none
    @return actualItemsArray
    * */
    public String[] listOfActualItems()
    {
        String arraySize;
        Scanner scanner=new Scanner(System.in);

        while(true) {
            System.out.println("Enter the size of the actual items array");
            arraySize=scanner.nextLine();
            try {
                int sizeOfActualItemsArray = Integer.parseInt(arraySize);
                if(sizeOfActualItemsArray>0)
                {
                    String[] actualItemsArray=new String[sizeOfActualItemsArray];
                    for(int i=0;i<actualItemsArray.length;i++)
                    {
                        System.out.println("Enter item number "+(i+1));
                        actualItemsArray[i]=scanner.next();
                        scanner.nextLine();

                    }
                    return  actualItemsArray;
                }
                else
                {
                    System.out.println("Invalid array size, it has to be greater than 0, please re-enter again");
                }

            } catch (Exception ex) {

                System.out.println("Incorrect array entry type, re-enter the size again");
            }
        }

    }
    /*This method accepts the value from the user and enters the items into the
    actual prices array
    @param none
    @return actualPricesArray
    * */
    public double[] listOfActualPrices()
    {
        String arraySize;
        String prices;

        Scanner scanner=new Scanner(System.in);

        while(true) {
            System.out.println("Enter the size of the actual items prices array");
            arraySize=scanner.nextLine();
            try {
                int sizeOfActualPricesArray = Integer.parseInt(arraySize);
                if(sizeOfActualPricesArray>0)
                {
                    double[] actualPricesArray=new double[sizeOfActualPricesArray];
                    for(int i=0;i<actualPricesArray.length;i++)
                    {
                       while (true)
                       {
                           System.out.println("Enter item number "+(i+1));
                           prices=scanner.nextLine();
                           try{
                               actualPricesArray[i]=Double.parseDouble(prices);
                               if(actualPricesArray[i]>=0) {

                                   break;
                               }
                               else
                               {
                                   System.out.println("Enter a price greater than 0");
                               }
                           }
                           catch (Exception ex)
                           {
                               System.out.println("In-correct input type of number "+(i+1)+",Please enter an integer value");

                           }
                       }

                    }
                    return  actualPricesArray;
                }
                else
                {
                    System.out.println("Invalid array size, it has to be greater than 0, please re-enter again");
                }

            } catch (Exception ex) {

                System.out.println("Incorrect array entry type, re-enter the size again");
            }
        }

    }
    /*This method accepts the value from the user and enters the items into the
    fraud items array
    @param none
    @return fraudItemsArray
    * */
    public String[] listOfFraudItems()
    {
        String arraySize;
        Scanner scanner=new Scanner(System.in);

        while(true) {
            System.out.println("Enter the size of the fraud items array");
            arraySize=scanner.nextLine();
            try {
                int sizeOfFraudItemsArray = Integer.parseInt(arraySize);
                if(sizeOfFraudItemsArray>0)
                {
                    String[] FraudItemsArray=new String[sizeOfFraudItemsArray];
                    for(int i=0;i<FraudItemsArray.length;i++)
                    {
                        System.out.println("Enter item number "+(i+1));
                        FraudItemsArray[i]=scanner.next();
                        scanner.nextLine();

                    }
                    return  FraudItemsArray;
                }
                else
                {
                    System.out.println("Invalid array size, it has to be greater than 0, please re-enter again");
                }

            } catch (Exception ex) {

                System.out.println("Incorrect array entry type, re-enter the size again");
            }
        }

    }

    /*This method accepts the value from the user and enters the items into the
    fruad prices array
    @param none
    @return fraudPricesArray
    * */
    public double[] listOfFraudPrices()
    {
        String arraySize;
        String prices;

        Scanner scanner=new Scanner(System.in);

        while(true) {
            System.out.println("Enter the size of the fraud items prices array");
            arraySize=scanner.nextLine();
            try {
                int sizeOfFraudPricesArray = Integer.parseInt(arraySize);
                if(sizeOfFraudPricesArray>0)
                {
                    double[] fraudPricesArray=new double[sizeOfFraudPricesArray];
                    for(int i=0;i<fraudPricesArray.length;i++)
                    {
                        while (true)
                        {
                            System.out.println("Enter item number "+(i+1));
                            prices=scanner.nextLine();
                            try{
                                fraudPricesArray[i]=Double.parseDouble(prices);
                                if(fraudPricesArray[i]>=0) {

                                    break;
                                }
                                else
                                {
                                    System.out.println("Enter a price greater than 0");
                                }
                            }
                            catch (Exception ex)
                            {
                                System.out.println("In-correct input type of number "+(i+1)+",Please enter an integer value");

                            }
                        }

                    }
                    return  fraudPricesArray;
                }
                else
                {
                    System.out.println("Invalid array size, it has to be greater than 0, please re-enter again");
                }

            } catch (Exception ex) {

                System.out.println("Incorrect array entry type, re-enter the size again");
            }
        }

    }
    public static void main(String[] args)
    {
        FindIncorrectEntries findIncorrectEntries=new FindIncorrectEntries();


       String[] actualItemsEntered=findIncorrectEntries.listOfActualItems();
       double[]  actualPricesEntered=findIncorrectEntries.listOfActualPrices();

       if(actualItemsEntered.length!=actualPricesEntered.length) {
           System.out.println("The size of actual items entered is " + actualItemsEntered.length + " while the size of actual prices array is " + actualPricesEntered.length);
           System.out.println("please enter the arrays again with equal lengths");

           actualItemsEntered=findIncorrectEntries.listOfActualItems();
           actualPricesEntered=findIncorrectEntries.listOfActualPrices();

       }

       String[] fraudItemsEntered=findIncorrectEntries.listOfFraudItems();
       double[] fraudPricesEntered=findIncorrectEntries.listOfFraudPrices();

       if(fraudItemsEntered.length!=fraudPricesEntered.length)
       {
           System.out.println("The size of fraud items entered is " + fraudItemsEntered.length + " while the size of fraud prices array is " + fraudPricesEntered.length);
           System.out.println("please enter the arrays again with equal lengths");

           fraudItemsEntered=findIncorrectEntries.listOfFraudItems();
           fraudPricesEntered=findIncorrectEntries.listOfFraudPrices();
       }


        int result = findIncorrectEntries.checkForIncorrectEntry(actualItemsEntered, actualPricesEntered, fraudItemsEntered, fraudPricesEntered);

        System.out.println("Incorrect prices were entered for "+result+" Items");
    }

}
