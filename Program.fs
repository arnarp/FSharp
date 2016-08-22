// Learn more about F# at http://fsharp.org

open System

let rec quicksort = function
    | [] -> []
    | x :: xs ->
        let smaller = List.filter ((>) x) xs
        let larger = List.filter ((<) x) xs
        quicksort smaller @ [x] @ quicksort larger

let printarray arr =
    arr |> List.iter (printf "%d ")

[<EntryPoint>]
let main argv =
    let array = [6;3;9;0]
    let sorted = quicksort array
    printarray sorted
    printfn "Hello World!"
    printfn "%A" argv
    0 // return an integer exit code

