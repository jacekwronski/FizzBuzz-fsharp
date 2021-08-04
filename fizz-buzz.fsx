let buzz number = if number % 5 = 0 then "Buzz" else ""
let fizz number = if number % 3 = 0 then "Fizz" else ""

let rec appyFizzBuzz functions acc number =
    match functions with
    | [] -> acc
    | f :: func -> appyFizzBuzz func (acc + f (number)) number

let finalFizzBuzzString result number partial =
    result
    + match partial with
      | "" -> number.ToString()
      | _ -> partial

let fizzBuzz (functions) =
    let mutable result = ""

    for n in 1 .. 100 do
        result <-
            n
            |> appyFizzBuzz functions ""
            |> finalFizzBuzzString result n

    printfn ($"{result}")

let functions = [ fizz; buzz ]
fizzBuzz (functions)
