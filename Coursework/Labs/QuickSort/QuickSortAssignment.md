Algorithm
Step 1 − Select a pivot, which is generally the first element, but there can be other elements, as mentioned previously. 
Step 2 − Move elements smaller than the pivot to the left side of the pivot.
Step 3 − Move elements larger than the pivot to the right side of the pivot.
Step 4 − After having the pivot in the right position, work with the sub-arrays on both sides.
Step 5 − Sort one side of the pivot - the right side and get the pivot in the right position.
Step 6 − Choose a new pivot from the left side and perform swap operations.
Step 7 − Keep repeating step 6 until the entire list is sorted.

Write a C# program that demonstrates the quick sort algorithm. Start by initializing an integer array with sample values, such as { 7, 4, 10, 5, 1, 8 }. Display the original array before sorting. Then implement a QuickSort method that recursively sorts the array using the divide-and-conquer approach. Create a Partition method that selects a pivot element (for simplicity, use the last element in the array), rearranges the elements so that all values less than the pivot appear before it and all values greater appear after it, and returns the pivot’s correct index. Also implement a helper Swap method to exchange two elements and a PrintArray method to display the array contents. Finally, call QuickSort in your Main method and display the array again to show the sorted result.