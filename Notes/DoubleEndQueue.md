Create an array-based double-ended queue (Deque)class that allows integer elements to be inserted and removed from both ends. 

Your class should include a constructor that accepts the maximum size of the deque and initializes an internal array along with variables to track the front and rearpositions. 

Implement methods to insert at the front and insert at the rear, as well as delete from the frontand delete from the rear, making sure to handle underflow and overflow conditions appropriately. 

Use modulo arithmetic to allow the deque to wrap around the array when the front or rear reaches the end, maintaining a circular structure. 

In a Mainmethod, demonstrate inserting the values 10 and 20 at the rear and 5 at the front, then deleting one element from the front and one from the rear, displaying the deque contents after each operation to show how elements are added and removed from both ends.