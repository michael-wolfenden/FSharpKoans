﻿namespace FSharpKoans
open Xunit

//---------------------------------------------------------------
// About Tuples
//
// Tuples are used to easily group together values in F#. They're 
// another fundamental construct of the language.
//---------------------------------------------------------------
module ``about tuples`` =

    [<Fact>]
    let CreatingTuples() =
        let items = ("apple", "dog")
        
        Assert.Equal(items, ("apple", __))
        
    [<Fact>]
    let AccessingTupleElements() =
        let items = ("apple", "dog")
        
        let fruit = fst items
        let animal = snd items
        
        Assert.Equal(fruit, __)
        Assert.Equal(animal, __)

    [<Fact>]
    let AccessingTupleElementsWithPatternMatching() =

        (* fst and snd are useful in some situations, but they only work with
           tuples containing two elements. It's usually better to use a 
           technique called pattern matching to access the values of a tuple. 
           
           Pattern matching works with tuples of any arity, and it allows you to 
           simultaneously break apart the tuple while assigning a name to each 
           value. Here's an example. *)
        
        let items = ("apple", "dog", "Mustang")
        
        let fruit, animal, car = items
        
        Assert.Equal(fruit, __)
        Assert.Equal(animal, __)
        Assert.Equal(car, __)
        
    [<Fact>]
    let IgnoringValuesWithPatternMatching() =
        let items = ("apple", "dog", "Mustang")
        
        let _, animal, _ = items
        
        Assert.Equal(animal, __)
    
    (* NOTE: pattern matching is found in many places
             throughout F#, and we'll revisit it again later *)
        
    [<Fact>]
    let ReturningMultipleValuesFromAFunction() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
        
        let squared, cubed = squareAndCube 3.0
        
        
        Assert.Equal(squared, __)
        Assert.Equal(cubed, __)
    
    (* THINK ABOUT IT: Is there really more than one return value?
                       What type does the squareAndCube function
                       return? *)
    
    [<Fact>]
    let TheTruthBehindMultipleReturnValues() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
            
        let result = squareAndCube 3.0
       
        Assert.Equal(result, __)
