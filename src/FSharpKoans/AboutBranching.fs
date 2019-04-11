namespace FSharpKoans
open Xunit

//---------------------------------------------------------------
// About Branching
//
// Branching is used to tell a program to conditionally perform
// an operation. It's another fundamental part of F#.
//---------------------------------------------------------------
module ``about branching`` =

    [<Fact>]
    let BasicBranching() =
        let isEven x =
            if x % 2 = 0 then
                "it's even!"
            else
                "it's odd!"
                
        let result = isEven 2                
        Assert.Equal(result, __)
    
    [<Fact>]
    let IfStatementsReturnValues() =
    
        (* In languages like C#, if statements do not yield results; they can 
           only cause side effects. If statements in F# return values due to 
           F#'s functional programming roots. *)
           
        let result = 
            if 2 = 3 then
                "something is REALLY wrong"
            else
                "no problem here"

        Assert.Equal(result, __)

    [<Fact>]
    let BranchingWithAPatternMatch() =
        let isApple x =
            match x with
            | "apple" -> true
            | _ -> false
        
        let result1 = isApple "apple"
        let result2 = isApple ""
        
        Assert.Equal(result1, __)
        Assert.Equal(result2, __)
    
    [<Fact>]
    let UsingTuplesWithIfStatementsQuicklyBecomesClumsy() =
        
        let getDinner x = 
            let name, foodChoice = x
            
            if foodChoice = "veggies" || foodChoice ="fish" || 
               foodChoice = "chicken" then
                sprintf "%s doesn't want red meat" name
            else
                sprintf "%s wants 'em some %s" name foodChoice
         
        let person1 = ("Chris", "steak")
        let person2 = ("Dave", "veggies")
        
        Assert.Equal((getDinner person1), __)
        Assert.Equal((getDinner person2), __)
        
    [<Fact>]
    let PatternMatchingIsNicer() =
    
        let getDinner x =
            match x with
            | (name, "veggies")
            | (name, "fish")
            | (name, "chicken") -> sprintf "%s doesn't want red meat" name
            | (name, foodChoice) -> sprintf "%s wants 'em some %s" name foodChoice 
            
        let person1 = ("Bob", "fish")
        let person2 = ("Sally", "Burger")
        
        Assert.Equal((getDinner person1), __)
        Assert.Equal((getDinner person2), __)
