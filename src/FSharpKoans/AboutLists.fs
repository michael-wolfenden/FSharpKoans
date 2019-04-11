namespace FSharpKoans
open Xunit
open System.Collections.Generic

//---------------------------------------------------------------
// About Lists
//
// Lists are important building blocks that you'll use frequently
// in F# programming. They are used to group arbitrarily large 
// sequences of values. It's very common to store values in a 
// list and perform operations across each value in the 
// list.
//---------------------------------------------------------------
module ``about lists`` =

    [<Fact>]
    let CreatingLists() =
        let list = ["apple"; "pear"; "grape"; "peach"]
        
        //Note: The list data type in F# is a singly linked list, 
        //      so indexing elements is O(n). 
        
        Assert.Equal(list.Head, "apple")
        Assert.Equal<IEnumerable<string>>(list.Tail, ["pear"; "grape"; "peach"])
        Assert.Equal(list.Length, 4)

        (* .NET developers coming from other languages may be surprised
           that F#'s list type is not the same as the base class library's
           List<T>. In other words, the following assertion is true *)

        let dotNetList = new List<string>()
        //you don't need to modify the following line
        Assert.NotEqual (list.GetType(), dotNetList.GetType())

    [<Fact>]
    let BuildingNewLists() =
        let first = ["grape"; "peach"]
        let second = "pear" :: first
        let third = "apple" :: second

        //Note: "::" is known as "cons"
        
        Assert.Equal<IEnumerable<string>>(["apple"; "pear"; "grape"; "peach"], third)
        Assert.Equal<IEnumerable<string>>(second, ["pear"; "grape"; "peach"])
        Assert.Equal<IEnumerable<string>>(first, ["grape"; "peach"])

        //What happens if you uncomment the following?

        //first.Head <- "apple"
        //first.Tail <- ["peach"; "pear"]

        //THINK ABOUT IT: Can you change the contents of a list once it has been
        //                created?


    [<Fact>]
    let ConcatenatingLists() =
        let first = ["apple"; "pear"; "grape"]
        let second = first @ ["peach"]

        Assert.Equal<IEnumerable<string>>(first, ["apple"; "pear"; "grape"])
        Assert.Equal<IEnumerable<string>>(second, ["apple"; "pear"; "grape"; "peach"])

    (* THINK ABOUT IT: In general, what performs better for building lists, 
       :: or @? Why?
       
       Hint: There is no way to modify "first" in the above example. It's
       immutable. With that in mind, what does the @ function have to do in
       order to append ["peach"] to "first" to create "second"? *)
        
    [<Fact>]
    let CreatingListsWithARange() =
        let list = [0..4]
        
        Assert.Equal(list.Head, 0)
        Assert.Equal<IEnumerable<int>>(list.Tail, [1..4])
        
    [<Fact>]
    let CreatingListsWithComprehensions() =
        let list = [for i in 0..4 do yield i ]
                            
        Assert.Equal<IEnumerable<int>>(list, [0..4])
    
    [<Fact>]
    let ComprehensionsWithConditions() =
        let list = [for i in 0..10 do 
                        if i % 2 = 0 then yield i ]
                            
        Assert.Equal<IEnumerable<int>>(list, [0; 2; 4; 6; 8; 10])

    [<Fact>]
    let TransformingListsWithMap() =
        let square x =
            x * x

        let original = [0..5]
        let result = List.map square original

        Assert.Equal<IEnumerable<int>>(original, [0..5])
        Assert.Equal<IEnumerable<int>>(result, [0; 1; 4; 9; 16; 25])

    [<Fact>]
    let FilteringListsWithFilter() =
        let isEven x =
            x % 2 = 0

        let original = [0..5]
        let result = List.filter isEven original

        Assert.Equal<IEnumerable<int>>(original, [0..5])
        Assert.Equal<IEnumerable<int>>(result, [0; 2; 4])

    [<Fact>]
    let DividingListsWithPartition() =
        let isOdd x =
            x % 2 <> 0

        let original = [0..5]
        let result1, result2 = List.partition isOdd original
        
        Assert.Equal<IEnumerable<int>>(result1, [1; 3; 5])
        Assert.Equal<IEnumerable<int>>(result2, [0; 2; 4])

    (* Note: There are many other useful methods in the List module. Check them
       via intellisense in Visual Studio by typing '.' after List, or online at
       http://msdn.microsoft.com/en-us/library/ee353738.aspx *)
