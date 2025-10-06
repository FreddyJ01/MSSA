MERGE_SORT (arr, start, end)  

// check if the subarray has more than one element

if start < end  

// find the middle index of the subarray

set mid = (start + end)/2  

// recursively sort the left subarray

MERGE_SORT(arr, start, mid)  

// recursively sort the right subarray

MERGE_SORT(arr, mid + 1, end)

// merge the sorted left and right subarrays into a single sorted array

MERGE (arr, start, mid, end)  

end of if  

END
 
 
 
and here are the instructions for implementing it: 
Write a C# program that demonstrates merge sort by sorting an array of integers. Initialize the array with the values {7, 4, 10, 5, 1, 8}. The program should first print the original array, then apply merge sort to rearrange the elements in ascending order. Implement a MergeSort method that recursively divides the array into left and right halves, and a Merge method that combines two sorted subarrays into a single sorted array. After sorting, print the fully sorted array to show how merge sort organizes the elements. Include a helper method called PrintArray that takes an array as input and prints all its elements in a single line.
 