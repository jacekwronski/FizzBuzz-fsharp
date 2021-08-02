
let fizz number = if number % 5 = 0 then printfn "Fizz"
let buzz number = if number % 3 = 0 then printfn "Buzz"
let fizzBuzz number = if number % 5 = 0 && number % 3 = 0 then printfn "FizzBuzz"

let functions = [ fizz; buzz; fizzBuzz; ]

let numbers = [ 1..100 ]

let fizzBuzzFunction(num, func) =
    for n in num do
        for f in func do
            f(n)
            
fizzBuzzFunction(numbers, functions)