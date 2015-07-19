module FizzBuzz 

let assertEqual expected actual =
  match actual with
    | a when a = expected -> "Passed!"
    | a -> sprintf "Failed! expected %O to equal %O" a expected
