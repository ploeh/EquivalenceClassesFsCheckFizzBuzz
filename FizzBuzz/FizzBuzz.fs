// Copyright (c) 2014 Mark Seemann.
// Permission to reproduce or modify is granted for personal, educational use.
// No warranty implied.

namespace Ploeh.Samples

open Xunit.Extensions
open Swensen.Unquote

module FizzBuzz =
    let transform number = 
        match number % 3, number with
        | _, 5 -> "Buzz"
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
    let ``FizzBuzz.transform returns Buzz`` (number : int) =
        let actual = FizzBuzz.transform number
        let expected = "Buzz"
        test <@ expected = actual @>
