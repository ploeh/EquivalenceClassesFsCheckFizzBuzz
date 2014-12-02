// Copyright (c) 2014 Mark Seemann.
// Permission to reproduce or modify is granted for personal, educational use.
// No warranty implied.

namespace Ploeh.Samples

open Xunit.Extensions
open FsCheck
open FsCheck.Xunit

module FizzBuzz =
    let transform number = 
        match number % 3, number % 5 with
        | 0, 0 -> "FizzBuzz"
        | _, 0 -> "Buzz"
        | 0, _ -> "Fizz"
        | _ -> number.ToString()

module Tests =
    [<Property>]
    let ``FizzBuzz.transform returns number`` (number : int) =
        (number % 3 <> 0 && number % 5 <> 0) ==> lazy
        let actual = FizzBuzz.transform number
        let expected = number.ToString()
        expected = actual

    [<Property>]
    let ``FizzBuzz.transform returns Fizz`` (number : int) =
        (number % 3 = 0 && number % 5 <> 0) ==> lazy
        let actual = FizzBuzz.transform number
        let expected = "Fizz"
        expected = actual


    [<Property>]
    let ``FizzBuzz.transform returns Buzz`` (number : int) =
        (number % 5 = 0 && number % 3 <> 0) ==> lazy
        let actual = FizzBuzz.transform number
        let expected = "Buzz"
        expected = actual

    [<Property(MaxFail = 2000)>]
    let ``FizzBuzz.transform returns FizzBuzz`` (number : int) =
        number % 15 = 0 ==> lazy
        let actual = FizzBuzz.transform number
        let expected = "FizzBuzz"
        expected = actual
