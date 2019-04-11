namespace FSharpKoans

open System.Collections.Generic
open Xunit

//---------------------------------------------------------------
// About Arrays
//
// Like lists, arrays are another basic container type in F#.
//---------------------------------------------------------------
module ``about arrays`` =
    
    [<Fact>]
    let CreatingArrays() =
        let fruits = [| "apple"; "pear"; "peach"|]

        Assert.Equal(fruits.[0], "apple")
        Assert.Equal(fruits.[1], "pear")
        Assert.Equal(fruits.[2], "peach")

    [<Fact>]
    let ArraysAreDotNetArrays() =
        let fruits = [| "apple"; "pear" |]

        let arrayType = fruits.GetType()
        let systemArray = System.Array.CreateInstance(typeof<string>, 0).GetType()

        (* Unlike List, Arrays in F# are the standard .NET arrays that
           you've used to if you're coming from another .NET language *)
        Assert.Equal(arrayType, systemArray)

    [<Fact>]
    let ArraysAreMutable() =
        let fruits = [| "apple"; "pear" |]
        fruits.[1] <- "peach"

        Assert.Equal<IEnumerable<string>>(fruits, [| "apple"; "peach" |])

    [<Fact>]
    let YouCanCreateArraysWithComprehensions() =
        let numbers = 
            [| for i in 0..10 do 
                   if i % 2 = 0 then yield i |]

        Assert.Equal<IEnumerable<int>>(numbers, [| 0; 2; 4; 6; 8; 10 |])

    [<Fact>]
    let ThereAreAlsoSomeOperationsYouCanPerformOnArrays() =
        let cube x =
            x * x * x

        let original = [| 0..5 |]
        let result = Array.map cube original

        Assert.Equal<IEnumerable<int>>(original, [| 0..5 |])
        Assert.Equal<IEnumerable<int>>(result, [| 0; 1; 8; 27; 64; 125 |])
