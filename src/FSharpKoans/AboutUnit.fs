namespace FSharpKoans
open Xunit

//---------------------------------------------------------------
// About Unit
//
// The unit type is a special type that represents the lack of
// a value. It's similar to void in other languages, but unit
// is actually considered to be a type in F#.
//---------------------------------------------------------------
module ``about unit`` =

    [<Fact>]
    let UnitIsUsedWhenThereIsNoReturnValueForAFunction() =
        let sendData data =
            //...sending the data to the server...
            ()

        let x = sendData "data"
        Assert.Equal(x, ()) //Don't overthink this. Note also the value "()" displays as "null" in some cases.

    [<Fact>]
    let ParameterlessFunctionsTakeUnitAsTheirArgument() =
        let sayHello() =
            "hello"

        let result = sayHello()
        Assert.Equal(result, "hello")
