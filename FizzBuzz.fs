module FizzBuzz

let fizzBuzz n =
  match n with
    | n when ((n % 5) = 0 )-> "buzz"
    | n when ((n % 3) = 0 )-> "fizz"
    | n -> sprintf "%d" n
