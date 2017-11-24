module CalculatorFunctions

let add = 
  let split seperator (text : string) = text.Split seperator
  
  let parse (text : string) = match System.Int32.TryParse(text) with
                                | (true,int) -> int
                                | _          -> 0

  split [|',';'\n'|] >> Array.fold (fun acc x -> acc + parse x) 0