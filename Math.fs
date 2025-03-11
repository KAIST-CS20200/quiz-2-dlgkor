module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  
  let isEven n = (n%2UL=0UL)
  let rec collatz_rec n ct = if n=1UL then ct 
                             elif isEven n then (collatz_rec (n/2UL) (ct+1))
                             else (collatz_rec (3UL*n+1UL) (ct+1))
  collatz_rec (uint64 n) 0   
