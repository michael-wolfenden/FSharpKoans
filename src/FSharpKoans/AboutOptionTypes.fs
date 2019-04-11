namespace FSharpKoans
open Xunit
    
type Game = {
    Name: string
    Platform: string
    Score: int option
}


//---------------------------------------------------------------
// About Option Types
//
// Option Types are used to represent calculations that may or
// may not return a value. You may be used to using null for this
// in other languages. However, using option types instead of nulls
// has subtle but far reaching benefits.
//---------------------------------------------------------------
module ``about option types`` =

    [<Fact>]
    let OptionTypesMightContainAValue() =
        let someValue = Some 10
        
        Assert.Equal(someValue.IsSome, __)
        Assert.Equal(someValue.IsNone, __)
        Assert.Equal(someValue.Value, __)

    [<Fact>]
    let OrTheyMightNot() =
        let noValue = None

        Assert.Equal(noValue.IsSome, __)
        Assert.Equal(noValue.IsNone, __)
        
        Assert.Throws<FILL_IN_THE_EXCEPTION>(fun () -> noValue.Value |> ignore)

    [<Fact>]
    let UsingOptionTypesWithPatternMatching() =
        let chronoTrigger = { Name = "Chrono Trigger"; Platform = "SNES"; Score = Some 5 }
        let halo = { Name = "Halo"; Platform = "Xbox"; Score = None }

        let translate score =
            match score with
            | 5 -> "Great"
            | 4 -> "Good"
            | 3 -> "Decent"
            | 2 -> "Bad"
            | 1 -> "Awful"
            | _ -> "Unknown"

        let getScore game =
            match game.Score with
            | Some score -> translate score
            | None -> "Unknown"

        Assert.Equal((getScore chronoTrigger), __)
        Assert.Equal((getScore halo), __)

    [<Fact>]
    let ProjectingValuesFromOptionTypes() =
        let chronoTrigger = { Name = "Chrono Trigger"; Platform = "SNES"; Score = Some 5 }
        let halo = { Name = "Halo"; Platform = "Xbox"; Score = None }

        let decideOn game =

            game.Score
            |> Option.map (fun score -> if score > 3 then "play it" else "don't play")

        //HINT: look at the return type of the decide on function
        Assert.Equal((decideOn chronoTrigger), __)
        Assert.Equal((decideOn halo), __)
