//This program accepts size of the array, array inputs from the user
//and compares each value in the max array with the input array and
//check if it is less than or equal to the value in the input array and outputs
//the number of value as an array

import java.util.Scanner;

public class compareArrayValues {

    public  int[]  returnComparisonValue(int[] inputArray,int[] maxArray)
    {
        int[] inputArray1=inputArray;
        int[] maxArray1=maxArray;
        int[] resultArray=new int[maxArray1.length];
        int count=0;

        if((inputArray1!=null)&&(maxArray1!=null))
        {
            for(int i=0;i<maxArray1.length;i++)
            {
                count=0;
                for(int j=0;j<inputArray1.length;j++)
                {
                    if(maxArray1[i]>inputArray1[j])
                    {
                        count++;
                    }
                }
                 resultArray[i]=count;

            }
        }
        else
        {
            System.out.println("Array size=0");
        }


        return resultArray;
    }

    public static void main(String[] args)
    {
        Scanner scanner=new Scanner(System.in);

        System.out.println("Enter the size of input array");
        int sizeofInputArray=scanner.nextInt();

        System.out.println("Enter the size of Max array");
        int sizeOfMaxArray=scanner.nextInt();

        int[] inputArray=new int[sizeofInputArray];
        int[] maxArray=new int[sizeOfMaxArray];

        for(int i=0;i<inputArray.length;i++)
        {
            System.out.println("Enter the value of "+(i+1)+" number");
            inputArray[i]=scanner.nextInt();
        }

        for (int j=0;j<maxArray.length;j++)
        {
            System.out.println("Enter the value of "+(j+1)+" number for the max array");
            maxArray[j]=scanner.nextInt();
        }
        compareArrayValues compareArrayValues=new compareArrayValues();
        int[] result=compareArrayValues.returnComparisonValue(inputArray,maxArray);

        System.out.println("The result array is");

        for (int m=0;m<result.length;m++)
        {
            System.out.print(result[m]);
        }


    }
}
