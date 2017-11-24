module CalculatorFunctionsTests

open NUnit.Framework
open FsUnit
open CalculatorFunctions

[<Test>]
let ``with simple number should return the number`` () =
  1 |>  should equal (add "1")

[<Test>]
let ``with empty string should return 0`` () =
  0 |>  should equal (add "")

[<Test>]
let ``with multiple numbers should return addition`` () =
  3 |>  should equal (add "1,2")