open FizzBuzz

let assertEqual expected actual =
  match actual with
    | a when a = expected -> "Passed!"
    | a -> sprintf "Failed! expected %O to equal %O" a expected




let test_suite =
  let cases =[
    (1,"1")
    (3, "fizz")
    (5, "buzz")
    ]
  cases
  |> List.map (fun (input, output) -> (fizzBuzz input, output))  
  |> List.map (fun (actual, expected) -> assertEqual expected actual)


[<EntryPoint>]
let main argv =
    test_suite
    |> List.map (printf "%O\n")
    |> ignore
    0
