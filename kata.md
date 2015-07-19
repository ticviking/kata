# FizzBuzz in F#

FizzBuzz is a common programming exercise.
Derived from a child's game to practice multiplication and division the rules of fizz buzz are:

>   The group counts up from 1, each taking a turn saying the next number. 
>   When it is your turn say the current number, unless one of the below rules applies.
>    If that number is 3 or a multiple of 3, do not say the number, say "Fizz".
>    If that number is 5 or a multiple of 5, do not say the number, say "Buzz".

The FizzBuzz module plays this game, given a number it outputs the correct thing for a player to say on that number.

The goal of the fizz buzz kata is to practice tool use & the TPP.
The rules above constitute the entire acceptance criteria,
and are simple enough to be covered in a single test with fewer than 10 test cases.
Therefore the goal of a run is simple, in 15 minutes be as absolutely correct in both tool use, and implementation order, as you can be.

# Run Log

Since I do not have a whole lot of record-keeping set up yet, each run is logged here
1. Complete the test cases using TDD and the built-in unit test framework. Commit on
each red-green-refactor step, and do not work about any special automation or the TPP.
