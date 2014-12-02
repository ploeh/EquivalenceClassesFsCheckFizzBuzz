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
    [<InlineData(3)>]
    let ``FizzBuzz.transform returns number`` (number : int) =
        let actual = FizzBuzz.transform (number * 3 * 5 + 1)
        let expected = (number * 3 * 5 + 1).ToString()
        test <@ expected = actual @>

    [<Theory>]
    [<InlineData(1)>]
    [<InlineData(2)>]
    [<InlineData(3)>]
    let ``FizzBuzz.transform returns Fizz`` (number : int) =
        let actual = FizzBuzz.transform (number * 3 * 5 + 3)
        let expected = "Fizz"
        test <@ expected = actual @>


    [<Theory>]
    [<InlineData(1)>]
    [<InlineData(2)>]
    [<InlineData(3)>]
    let ``FizzBuzz.transform returns Buzz`` (number : int) =
        let actual = FizzBuzz.transform (number * 3 * 5 + 5)
        let expected = "Buzz"
        test <@ expected = actual @>

    [<Theory>]
    [<InlineData(89)>]
    [<InlineData(19)>]
    [<InlineData(147326)>]
    let ``FizzBuzz.transform returns FizzBuzz`` (number : int) =
        let actual = FizzBuzz.transform (number * 3 * 5)
        let expected = "FizzBuzz"
        test <@ expected = actual @>
