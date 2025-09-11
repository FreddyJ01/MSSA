Create an array-based circular queueclass that maintains FIFO order and allows efficient insertion and deletion without shifting elements. 

Your class should include a constructor that accepts the maximum size of the queue and initializes an internal array along with front and rearpointers. 

Implement methods to enqueue elements at the rear (wrapping around to the beginning of the array when necessary) and dequeue elements from the front, handling underflow and overflow conditions appropriately. 

Include a method to display all elements currently in the queue in order from front to rear. 

In a Mainmethod, demonstrate the queue by enqueuing the values 10, 20, 30, and 40, displaying the queue contents, performing a dequeueoperation, and displaying the updated queue contents to illustrate how the circular structure works.