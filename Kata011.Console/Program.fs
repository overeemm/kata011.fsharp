open CalculatorFunctions

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main (argv : string[])= 
    match argv with 
      | [|first|] -> add first |> printfn "%A"
      | _         -> failwith "Must have only one argument."
    0
