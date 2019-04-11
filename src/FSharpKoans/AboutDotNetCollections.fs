namespace FSharpKoans
open Xunit
open System.Collections.Generic

//---------------------------------------------------------------
// About .NET Collections
//
// Since F# is built for seamless interop with other CLR 
// languages, you can use all of the basic .NET collections types
// you're already familiar with if you're a C# or VB programmer.
//---------------------------------------------------------------
module ``about dot net collections`` =

    [<Fact>]
    let CreatingDotNetLists() =
        let fruits = new List<string>()

        fruits.Add("apple")
        fruits.Add("pear")
 
        Assert.Equal(fruits.[0], "apple")
        Assert.Equal(fruits.[1], "pear")

    [<Fact>]
    let CreatingDotNetDictionaries() =
        let addressBook = new Dictionary<string, string>()

        addressBook.["Chris"] <- "Ann Arbor"
        addressBook.["SkillsMatter"] <- "London"

        Assert.Equal(addressBook.["Chris"], "Ann Arbor")
        Assert.Equal(addressBook.["SkillsMatter"], "London")

    [<Fact>]
    let YouUseCombinatorsWithDotNetTypes() =
        let addressBook = new Dictionary<string, string>()

        addressBook.["Chris"] <- "Ann Arbor"
        addressBook.["SkillsMatter"] <- "London"

        let verboseBook = 
            addressBook
            |> Seq.map (fun kvp -> sprintf "Name: %s - City: %s" kvp.Key kvp.Value)
            |> Seq.toArray

        //NOTE: The seq type in F# is an alias for .NET's IEnumerable interface
        //      Like the List and Array module, the Seq module contains functions 
        //      that you can combine to perform operations on types implementing 
        //      seq/IEnumerable.

        Assert.Equal(verboseBook.[0], "Name: Chris - City: Ann Arbor")
        Assert.Equal(verboseBook.[1], "Name: SkillsMatter - City: London")

    [<Fact>]
    let SkippingElements() =
        let original = [0..5]
        let result = Seq.skip 2 original
        
        Assert.Equal<IEnumerable<int>>(result, [2..5])

    [<Fact>]
    let FindingTheMax() =
        let values = new List<int>()

        values.Add(11)
        values.Add(20)
        values.Add(4)
        values.Add(2)
        values.Add(3)

        let result = Seq.max values
        
        Assert.Equal(result, 20)
    
    [<Fact>]
    let FindingTheMaxUsingACondition() =
        let getNameLength (name:string) =
            name.Length
        
        let names = [| "Harry"; "Lloyd"; "Nicholas"; "Mary"; "Joe"; |]
        let result = Seq.maxBy getNameLength names 
        
        Assert.Equal(result, "Nicholas")
