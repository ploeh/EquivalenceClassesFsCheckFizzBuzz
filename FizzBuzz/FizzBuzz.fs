// Copyright (c) 2014 Mark Seemann.
// Permission to reproduce or modify is granted for personal, educational use.
// No warranty implied.

namespace Ploeh.Samples

open Xunit.Extensions
open Swensen.Unquote

module FizzBuzz =
    let transform number = 
        match number % 3, number % 5, number with
        | _, _, 15 -> "FizzBuzz"
        | _, 0, _ -> "Buzz"
        | 0, _, _ -> "Fizz"
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
    let ``FizzBuzz.transform returns FizzBuzz`` (number : int) =
        let actual = FizzBuzz.transform number
        let expected = "FizzBuzz"
        test <@ expected = actual @>
