let buzz number = if number % 5 = 0 then "Buzz" else ""
let fizz number = if number % 3 = 0 then "Fizz" else ""

let functions = [ fizz; buzz ]

let numbers = [ 1 .. 100 ]

let fizzBuzzFunction (num, func) =
    let mutable result = ""

    for n in num do
        let mutable partial = ""
        for f in func do
            partial <- partial + f (n)

        if partial = "" then
            result <- result + n.ToString()
        else
            result <- result + partial

    printfn ($"{result}")

fizzBuzzFunction (numbers, functions)
