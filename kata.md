# FizzBuzz in F#

FizzBuzz is a common programming exercise.
Derived from a child's game to practice multiplication and division the rules of fizz buzz are:

>   The group counts up from 1, each taking a turn saying the next number. 
>   When it is your turn say the current number, unless one of the below rules applies.
>    If that number is 3 or a multiple of 3, do not say the number, say "Fizz".
>    If that number is 5 or a multiple of 5, do not say the number, say "Buzz".

The FizzBuzz module plays this game, given a number it outputs the correct thing for a player to say on that number.

The goal of this kata is to practice tool use, the code problem is as small and simple as possible to make issues in my tools and approach the pain points.

# Run Log

Since I do not have a whole lot of record-keeping set up yet, each set of runs is logged here
1. Bare bones. Use as few tools as possible but still follow best practices. This may require writing some additional scripts, or shell based build scripts. Establish how long it takes to accomplish the 
   1. 7/19/2015 6:20PM - First run. (notes to follow)
     So I notice a few things about this run.
     - It took longer than I expected
     - I spent about 30 min making a mini TDD framework that was most assuredly lacking in features.
       - but the fact that a set of test functions took me that little time to get running given that I started on a new machine is pretty sweet
     - Despite forgetting to install f# on this machine before doing the kata I was still able to do it without much pain.
     - LEARN YO TOOLS (emacs is perhaps less awesome than I had hoped, but still more awesome than pure shell + vim)
       - magit
       - evil-mode
       - states: I suspect I'm stuck in multiple states at once and changing behavior of things in ways I do not anticipate
     - evil-change appears to be buggy, I cannot reliably do `cw` or `ci(` to edit inside things. This cost me several seconds repeatedly. 

