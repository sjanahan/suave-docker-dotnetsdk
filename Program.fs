// Learn more about F# at http://fsharp.org

open System
open Suave 
[<EntryPoint>]
let main argv =
    startWebServer
        { defaultConfig with
            bindings = [ HttpBinding.create HTTP System.Net.IPAddress.Any 8083us ] }
        (Successful.OK "Hello World!")
    
    0
