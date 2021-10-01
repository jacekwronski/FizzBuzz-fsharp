namespace FizzBuzz.App

open FizzBuzz

module Program =

    [<EntryPoint>]
    let main _ = 
        printfn "%s" <| fizzBuzzGenerator [1..100]
        0
