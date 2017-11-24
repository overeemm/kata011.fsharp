module CalculatorFunctionsTests

open NUnit.Framework
open FsUnit
open CalculatorFunctions

[<Test>]
let ``with simple number should return the number`` () =
  1 |>  should equal (add "1")