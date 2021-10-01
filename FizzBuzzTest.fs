namespace FizzBuzz.App

open NUnit.Framework
open FizzBuzz

module fizz_buzz_test =
    [<SetUp>]
    let Setup () =
        ()

    [<Test>]
    let Passing5_ReturnsBuzz () =
        let actual = fizzBuzzGenerator [5]
        Assert.That(actual, Is.EqualTo("Buzz"))
      
    [<Test>]
    let Passing1_Returns1 () =
        let actual = fizzBuzzGenerator [1]
        Assert.That(actual, Is.EqualTo("1"))
    
    [<Test>]
    let Passing3_ReturnsFizz () =
        let actual = fizzBuzzGenerator [3]
        Assert.That(actual, Is.EqualTo("Fizz"))

    [<Test>]
    let Passing15_ReturnsFizzBuzz () =
        let actual = fizzBuzzGenerator [15]
        Assert.That(actual, Is.EqualTo("FizzBuzz"))

    [<Test>]
    let Passing1_3_5_15_Returns1FizzBuzzFizzBuzz () =
        let actual = fizzBuzzGenerator [1; 3; 5; 15]
        Assert.That(actual, Is.EqualTo("1,Fizz,Buzz,FizzBuzz"))
