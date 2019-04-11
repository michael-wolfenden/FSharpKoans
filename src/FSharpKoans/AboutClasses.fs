namespace FSharpKoans
open Xunit

//---------------------------------------------------------------
// About Classes
//
// As a full fledged Object Oriented language, F# allows you to
// create traditional classes to contain data and methods.
//---------------------------------------------------------------

type Zombie() =
    member this.FavoriteFood = "brains"

    member this.Eat food =
        match food with
        | "brains" -> "mmmmmmmmmmmmmmm"
        | _ -> "grrrrrrrr"

type Person(name:string) =
    member this.Speak() =
        "Hi my name is " + name

type Zombie2() =
    let favoriteFood = "brains"

    member this.Eat food =
        if food = favoriteFood then "mmmmmmmmmmmmmmm" else "grrrrrrrr"

type Person2(name:string) =
    let mutable internalName = name

    member this.Name
        with get() = internalName
        and set(value) = internalName <- value

    member this.Speak() =
        "Hi my name is " + this.Name

module ``about classes`` =

    [<Fact>]
    let ClassesCanHaveProperties() =
        let zombie = new Zombie()

        Assert.Equal(zombie.FavoriteFood, __)

    [<Fact>]
    let ClassesCanHaveMethods() =
        let zombie = new Zombie()

        let result = zombie.Eat "brains"
        Assert.Equal(result, __)
    
    [<Fact>]
    let ClassesCanHaveConstructors() =
    
        let person = new Person("Shaun")

        let result = person.Speak()
        Assert.Equal(result, __)

    [<Fact>]
    let ClassesCanHaveLetBindingsInsideThem() =
        let zombie = new Zombie2()

        let result = zombie.Eat "chicken"
        Assert.Equal(result, __)

        (* TRY IT: Can you access the let bound value Zombie2.favoriteFood
                   outside of the class definition? *)

    [<Fact>]
    let ClassesCanHaveReadWriteProperties() =
        let person = new Person2("Shaun")

        let firstPhrase = person.Speak()
        Assert.Equal(firstPhrase, __)

        person.Name <- "Shaun of the Dead"
        let secondPhrase = person.Speak()
        Assert.Equal(secondPhrase, __)
