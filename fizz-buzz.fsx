let numbers = [ 1 .. 100 ]

let getFizzBuzz n =
    match n with
    | n when n % 3 = 0 && n % 5 = 0 -> "FizzBuzz"
    | n when n % 5 = 0 -> "Buzz"
    | n when n % 3 = 0 -> "Fizz"
    | _ -> n.ToString()

let fizzBuzzFunction num =
    let fizzBuzzArr = [for n in num do yield getFizzBuzz n]
        
    printfn "%s" <| String.concat "," fizzBuzzArr

fizzBuzzFunction numbers
