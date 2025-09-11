# Asymptotic Analysis & Complexity

---

## What is Asymptotic Analysis?
Asymptotic analysis is a method of describing the efficiency of algorithms as the input size grows. It helps us compare algorithms independently of hardware or implementation details.

---

## Big O Notation
Big O notation describes the **upper bound** of an algorithm's running time. It tells us the worst-case scenario for how long an algorithm could take as the input size increases.

- **Example:** O(n) means the running time increases linearly with input size.
- **Usage:** Used to express the maximum time or space an algorithm could require.

---

## Big Omega Notation
Big Omega notation describes the **lower bound** of an algorithm's running time. It tells us the best-case scenario for how fast an algorithm could run.

- **Example:** Ω(n) means the algorithm takes at least linear time.
- **Usage:** Used to express the minimum time or space required.

---

## Big Theta Notation
Big Theta notation describes a **tight bound** on an algorithm's running time. It means the algorithm will always run in this time, both in the best and worst cases.

- **Example:** Θ(n) means the running time is always linear.
- **Usage:** Used when the upper and lower bounds are the same.

---

## Common Complexity Classes
| Notation | Name           | Example Algorithm         |
|----------|----------------|--------------------------|
| O(1)     | Constant       | Hash table lookup        |
| O(log n) | Logarithmic    | Binary search            |
| O(n)     | Linear         | Simple search            |
| O(n log n)| Linearithmic  | Merge sort, heapsort     |
| O(n^2)   | Quadratic      | Bubble sort, selection sort |
| O(n^3)   | 
| O(2^n)   | Exponential    | Recursive Fibonacci      |
| O(n!)    | Factorial      | Traveling salesman brute force |

---

## Time vs Space Complexity
- **Time Complexity:** How the runtime grows as input size increases.
- **Space Complexity:** How the memory usage grows as input size increases.

---

## Tips for Analyzing Algorithms
- Focus on the highest-order term (ignore constants and lower-order terms).
- Consider worst-case, best-case, and average-case scenarios.
- Use asymptotic analysis to compare scalability, not exact performance.

---