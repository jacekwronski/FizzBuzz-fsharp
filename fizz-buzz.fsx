let buzz number = if number % 5 = 0 then "Buzz" else ""
let fizz number = if number % 3 = 0 then "Fizz" else ""

let rec appyFizzBuzz (number, func, acc) =
    match func with
    | [] -> acc
    | f :: func -> appyFizzBuzz (number, func, acc + f (number))

let finalFizzBuzzString (partial, result, number) =
    result
    + match partial with
      | "" -> number.ToString()
      | _ -> partial

let fizzBuzz (functionsList) =
    let mutable result = ""

    for n in 1 .. 100 do
        //TODO: capire come si usa l'operatore |> e >>>, sicuramente migliorabiile
        let partial = appyFizzBuzz (n, functionsList, "")
        result <- finalFizzBuzzString (partial, result, n)

    printfn ($"{result}")

let functions = [ fizz; buzz ]
fizzBuzz (functions)
