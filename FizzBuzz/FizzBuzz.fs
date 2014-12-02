// Copyright (c) 2014 Mark Seemann.
// Permission to reproduce or modify is granted for personal, educational use.
// No warranty implied.

namespace Ploeh.Samples

open Xunit.Extensions
open Swensen.Unquote

module FizzBuzz =
    let transform number = 
        match number % 3, number % 5 with
        | 0, 0 -> "FizzBuzz"
        | _, 0 -> "Buzz"
        | 0, _ -> "Fizz"
        | _ -> number.ToString()

module Tests =
    [<Theory>]
    [<InlineData(1)>]
    [<InlineData(2)>]
    [<InlineData(4)>]
    let ``FizzBuzz.transform returns number`` (number : int) =
        let actual = FizzBuzz.transform number
        let expected = number.ToString()
        test <@ expected = actual @>

    [<Theory>]
    [<InlineData(3)>]
    [<InlineData(6)>]
    [<InlineData(9)>]
    let ``FizzBuzz.transform returns Fizz`` (number : int) =
        let actual = FizzBuzz.transform number
        let expected = "Fizz"
        test <@ expected = actual @>


    [<Theory>]
    [<InlineData(5)>]
    [<InlineData(10)>]
    [<InlineData(20)>]
    let ``FizzBuzz.transform returns Buzz`` (number : int) =
        let actual = FizzBuzz.transform number
        let expected = "Buzz"
        test <@ expected = actual @>

    [<Theory>]
    [<InlineData(15)>]
    [<InlineData(30)>]
    [<InlineData(45)>]
    let ``FizzBuzz.transform returns FizzBuzz`` (number : int) =
        let actual = FizzBuzz.transform number
        let expected = "FizzBuzz"
        test <@ expected = actual @>
