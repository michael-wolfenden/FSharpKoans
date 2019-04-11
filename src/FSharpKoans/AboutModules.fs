namespace FSharpKoans
open Xunit

module MushroomKingdom =
    type Power =
        | Mushroom
        | Star
        | FireFlower
        
    type Character = {
        Name: string
        Occupation: string
        Power: Power option
    }

    let Mario = { Name = "Mario"; Occupation = "Plumber"; Power = None}

    let powerUp character =
        { character with Power = Some Mushroom }

//---------------------------------------------------------------
// About Modules
//
// Modules are used to group functions, values, and types. 
// They're similar to .NET namespaces, but they have slightly 
// different semantics as you'll see below.
//---------------------------------------------------------------
module ``about modules`` =

    [<Fact>]
    let ModulesCanContainValuesAndTypes() =

        Assert.Equal(MushroomKingdom.Mario.Name, __)
        Assert.Equal(MushroomKingdom.Mario.Occupation, __)
        
        let moduleType = MushroomKingdom.Mario.GetType()
        Assert.Equal(moduleType, typeof<FILL_ME_IN>)

    [<Fact>]
    let ModulesCanContainFunctions() =
        let superMario = MushroomKingdom.powerUp MushroomKingdom.Mario

        Assert.Equal(superMario.Power, __)

(* NOTE: In previous sections, you've seen modules like List and Option that 
         contain useful functions for dealing with List types and Option types
         respectively. *)

open MushroomKingdom

module ``about opened modules`` =
    
    let inline __<'T> : 'T = failwith "Seek wisdom by filling in the __"

    [<Fact>]
    let OpenedModulesBringTheirContentsInScope() = 
        Assert.Equal(Mario.Name, __)
        Assert.Equal(Mario.Occupation, __)
        Assert.Equal(Mario.Power, __)