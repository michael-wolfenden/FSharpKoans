namespace FSharpKoans
open Xunit

type Character = {
    Name: string
    Occupation: string
}

//---------------------------------------------------------------
// About Record Types
//
// Record types are lightweight ways to construct new types.
// You can use them to group data in a more structured way than
// tuples.
//---------------------------------------------------------------
module ``about record types`` =

    [<Fact>]
    let RecordsHaveProperties() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }

        Assert.Equal(mario.Name, "Mario")
        Assert.Equal(mario.Occupation, "Plumber")

    [<Fact>]
    let CreatingFromAnExistingRecord() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }
        let luigi = { mario with Name = "Luigi"; }

        Assert.Equal(mario.Name, "Mario")
        Assert.Equal(mario.Occupation, "Plumber")

        Assert.Equal(luigi.Name, "Luigi")
        Assert.Equal(luigi.Occupation, "Plumber")

    [<Fact>]
    let ComparingRecords() =
        let greenKoopa = { Name = "Koopa"; Occupation = "Soldier"; }
        let bowser = { Name = "Bowser"; Occupation = "Kidnapper"; }
        let redKoopa = { Name = "Koopa"; Occupation = "Soldier"; }

        let koopaComparison =
             if greenKoopa = redKoopa then
                 "all the koopas are pretty much the same"
             else
                 "maybe one can fly"

        let bowserComparison = 
            if bowser = greenKoopa then
                "the king is a pawn"
            else
                "he is still kind of a koopa"

        Assert.Equal(koopaComparison, "all the koopas are pretty much the same")
        Assert.Equal(bowserComparison, "he is still kind of a koopa")

    [<Fact>]
    let YouCanPatternMatchAgainstRecords() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }
        let luigi = { Name = "Luigi"; Occupation = "Plumber"; }
        let bowser = { Name = "Bowser"; Occupation = "Kidnapper"; }

        let determineSide character =
            match character with
            | { Occupation = "Plumber" } -> "good guy"
            | _ -> "bad guy"

        Assert.Equal((determineSide mario), "good guy")
        Assert.Equal((determineSide luigi), "good guy")
        Assert.Equal((determineSide bowser), "bad guy")
