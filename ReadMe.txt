Roman Numerals:
Write a method to convert Roman numerals into numbers. Roman numerals are based on seven symbols:
Symbol  Value
I       1
V       5
X       10
L       50
C       100
D       500
M       1,000


Working:-
In 'intToRoman' funtion-
We create array 'm' whose type is string which will hold the value for 1000 and above.
We create array 'c' whose type is string which will hold the value for 100 and below 1000.
We create array 'x' whose type is string which will hold the value for 10 and below 100.
We create array 'i' whose type is string which will hold the value for 1 and below 10.

We create string name 'thousand' which will check the thousand place roman value.
We create string name 'hundreds' which will check the hundred place roman value.
We create string name 'tens' which will check the tens place roman value.
We create string name 'ones' which will check the ones place roman value.

We create string name 'ans' which will crate the required output and return it to user.

In 'Main' function we take input number and covert it to roman value by calling function 'intToRoman'
