namespace FSharpKoans
open System

[<AutoOpenAttribute>]
module Helpers =

    let inline __<'T> : 'T = failwith "Seek wisdom by filling in the __"

    type FILL_ME_IN =
        class end
        
    type FILL_IN_THE_EXCEPTION() =
        inherit Exception()