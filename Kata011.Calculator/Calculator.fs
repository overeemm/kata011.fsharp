module CalculatorFunctions

  let add = 
    let split seperator (text : string) = text.Split seperator
    let parse (text : string) = System.Int32.Parse(text)
    
    split [|','|] >> Array.fold (fun acc x -> acc + parse x) 0