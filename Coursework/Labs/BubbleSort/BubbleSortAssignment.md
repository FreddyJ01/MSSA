Write a C# program that demonstrates bubble sort on an integer array such as {5, 2, 8, 3, 9}. The program should first print the original array, then sort it using a BubbleSortmethod that compares adjacent elements and swaps them if they are out of order, including an optimization to stop early if no swaps occur in a pass.

 Implement a Swaphelper method to exchange elements by reference, and finally print the sorted array in ascending order to show how the largest elements gradually “bubble” to the end.

procedure bubble Sort(list : array of items)
   loop = list.count;
   for i = 0 to loop-1 do:
      swapped = false
      for j = 0 to loop-1 do:
         if list[j] > list[j+1] then 
            swap( list[j], list[j+1] )
            swapped = true
         end if
end for
if(not swapped) then
         break
      end if
   end for
end procedure return list