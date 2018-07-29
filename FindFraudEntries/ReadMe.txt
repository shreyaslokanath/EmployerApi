Program Overview:what does it do?

The following program calculates the fraud entries for a praticular business transaction.
The program has 2 array's each for actual entries and 2 array's for fraudlent entries.
The user is asked to enter the size and the inputs for each array. Then checkForIncorrectEntry()
method calculates the number of entries that have an incorrect entry by comparing the 
values of fraudArray[] with the actualArray[]

Why is the project useful?
The main purpose of the project is to find the number of fraudlent entries for a particular
transaction, this can be further enhanced by adding two interfaces
1) Admin interface
2) staff interface

and calculate the how many entries are in-correct and the items for which incorrect values were
entered

Who maintains and contributes to the project?
Shreyas Lokanath 

Number of methods:4
checkForIncorrectEntry()
listOfActualItems()
listOfActualPrices()
listOfFraudItems()
listOfFraudPrices()

Exceptions handled:
1) Array size exception
2) inputmismatch excpetion
3) negative value exception
4) array size mis-match exception


Logic used:
1) enter the value of actual items and actual prices
2) check for their size, if their size mismatch re-enter the array with equal size
3) enter the value of fraud items and fraud prices
4) check for their size, if their size mismatch re-enter the array with equal size

5) The fraud items array compares each value in the actualItems array, if the value is found
if the values are unequal, that particular entry is rendered a fraudlent entry. 