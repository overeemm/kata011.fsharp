module CalculatorFunctions

let add = 
  let split seperator (text : string) = text.Split seperator
  
  let parse (text : string) = match System.Int32.TryParse(text) with
                                | (true,int) -> int
                                | _          -> 0

  let failOnEmpty text = match text with
                            | "" -> failwith ("Invalid input")
                            | _  -> text

  let map = Array.map
  let fold = Array.fold

  let failOnNonEmptyListWithEmptyValues (array : string[]) : string[] = 
                         match array.Length with
                            | 0  -> array
                            | 1  -> array
                            | _  -> map failOnEmpty array

  split [|',';'\n'|] >> failOnNonEmptyListWithEmptyValues >> map parse >> fold (+) 0