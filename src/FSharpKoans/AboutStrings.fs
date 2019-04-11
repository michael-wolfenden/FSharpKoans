namespace FSharpKoans
open Xunit

//---------------------------------------------------------------
// About Strings
//
// Most languages have a set of utilities for manipulating 
// strings. F# is no different.
//---------------------------------------------------------------
module ``about strings`` =

    [<Fact>]
    let StringValue() =
        let message = "hello"

        Assert.Equal(message, __)

    [<Fact>]
    let StringConcatValue() =
        let message = "hello " + "world"

        Assert.Equal(message, __)

    [<Fact>]
    let FormattingStringValues() =
        let message = sprintf "F# turns it to %d!" 11

        Assert.Equal(message, __)

        //NOTE: you can use printf to print to standard output

        (* TRY IT: What happens if you change 11 to be something besides 
                   a number? *)

    [<Fact>]
    let FormattingOtherTypes() =
        let message = sprintf "hello %s" "world"

        Assert.Equal(message, __)

    [<Fact>]
    let FormattingAnything() =
        let message = sprintf "Formatting other types is as easy as: %A" (1, 2, 3)

        Assert.Equal(message, __)

    (* NOTE: For all the %formatters that you can use with string formatting 
             see: http://msdn.microsoft.com/en-us/library/ee370560.aspx *)

    [<Fact>]
    let CombineMultiline() =
        let message = "super\
                        cali\
                        fragilistic\
                        expiali\
                        docious"

        Assert.Equal(message, __)

    [<Fact>]
    let Multiline() =
        let message = "This
                        is
                        on
                        five
                        lines"

        Assert.Equal(message, __)

    [<Fact>]
    let ExtractValues() =
        let message = "hello world"

        let first = message.[0]
        let other = message.[4] 

 (* A single character is denoted using single quotes, example: 'c',
        not double quotes as you would use for a string *)
           
        Assert.Equal(first, __)
        Assert.Equal(other, __)

    [<Fact>]
    let ApplyWhatYouLearned() =
        (* It's time to apply what you've learned so far. Fill in the function below to
           make the asserts pass *)
        let getFunFacts x =
            __

        let funFactsAboutThree = getFunFacts 3
        let funFactsAboutSix = getFunFacts 6

        Assert.Equal("3 doubled is 6, and 3 tripled is 9!", funFactsAboutThree)
        Assert.Equal("6 doubled is 12, and 6 tripled is 18!", funFactsAboutSix)
