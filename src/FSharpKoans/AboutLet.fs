﻿namespace FSharpKoans

open Xunit

//---------------------------------------------------------------
// About Let
//
// The let keyword is one of the most fundamental parts of F#.
// You'll use it in almost every line of F# code you write, so
// let's get to know it well! (no pun intended)
//---------------------------------------------------------------
module ``about let`` =

    [<Fact>]
    let LetBindsANameToAValue() =
        let x = 50
        
        Assert.Equal(x, __)
    
    (* In F#, values created with let are inferred to have a type like
       "int" for integer values, "string" for text values, and "bool" 
       for true or false values. *)
    [<Fact>]
    let LetInfersTheTypesOfValuesWherePossible() =
        let x = 50
        let typeOfX = x.GetType()
        Assert.Equal(typeOfX, typeof<int>)

        let y = "a string"
        let expectedType = y.GetType()
        Assert.Equal(expectedType, typeof<FILL_ME_IN>)

    [<Fact>]
    let YouCanMakeTypesExplicit() =
        let (x:int) = 42
        let typeOfX = x.GetType()

        let y:string = "forty two"
        let typeOfY = y.GetType()

        Assert.Equal(typeOfX, typeof<FILL_ME_IN>)
        Assert.Equal(typeOfY, typeof<FILL_ME_IN>)

        (* You don't usually need to provide explicit type annotations types for 
           local variables, but type annotations can come in handy in other 
           contexts as you'll see later. *)
    
    [<Fact>]
    let FloatsAndInts() =
        (* Depending on your background, you may be surprised to learn that
           in F#, integers and floating point numbers are different types. 
           In other words, the following is true. *)
        let x = 20
        let typeOfX = x.GetType()

        let y = 20.0
        let typeOfY = y.GetType()

        //you don't need to modify these
        Assert.Equal(typeOfX, typeof<int>)
        Assert.Equal(typeOfY, typeof<float>)

        //If you're coming from another .NET language, float is F# slang for
        //the double type.

    [<Fact>]
    let ModifyingTheValueOfVariables() =
        let mutable x = 100
        x <- 200

        Assert.Equal(x, __)

    [<Fact>]
    let YouCannotModifyALetBoundValueIfItIsNotMutable() =
        let x = 50
        
        //What happens if you uncomment the following?
        //
        //x <- 100

        //NOTE: Although you can't modify immutable values, it is possible
        //      to reuse the name of a value in some cases using "shadowing".
        let x = 100
         
        Assert.Equal(x, __)