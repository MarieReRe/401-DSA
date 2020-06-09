# Insertion Sort in C#
What is an insertion sort anyways? 
By definition an insertion sort is an algorithm that iterates through unsorted elements and inserts them into the correct spot. 
How Does it do that one may ask? Well the insertion sort algorithm maintains  a sublist of the collection that it is initially given as the sorted sublist. It then iterates through a collection and one by one, nserts the elements into the correct spots in the sorted sublist


## Efficency
Insertion sort is a very slow way to sort.
- Time: O(n^2) Quadratic
	- Since we will be using nested loops the performance of this algorithm is directly proportiomal to the square of the size of the input data set.
- Space: O(1) Constant
	- Insertion sort is being sorted **in place**, so this will always be the size of the array.


## How to create an insertion sort
First, we will assume that the first item is sorted. Then we will find the next value to compare to the first "sorted value". After that we will shift over any necessary elements t make space for the value to be added. Finally, we will insert the value into the sorted subset and repeat over and over until the elements are completely sorted. 


## Test Cases

Sort a unique array

sort same values

sort a reversed array

sort an array that is nearly sorted

## Some extra resources to learn more about the Insertion Sort
https://www.youtube.com/watch?v=DFG-XuyPYUQ
https://www.khanacademy.org/computing/computer-science/algorithms/insertion-sort/a/insertion-sort
https://www.interviewbit.com/tutorial/insertion-sort-algorithm/

