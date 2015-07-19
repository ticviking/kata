let assertEqual expected actual =
  match actual with
    | a when a = expected -> "Passed!"
    | a -> sprintf "Failed! expected %O to equal %O" a expected




let test_suite =
  let cases =[
    (1,1)
    ]
  cases


[<EntryPoint>]
let main argv =
    test_suite
    |> printf "%O"
    0
