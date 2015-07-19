module FizzBuzz

let fizzBuzz n =
  match n with
    | n when ((n % 3) = 0 )-> "fizz"
    | n -> sprintf "%d" n
