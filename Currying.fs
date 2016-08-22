let add x y = x + y

let inc = add 1
let anotherInc x = add 1 x
printfn "%d is the same as %d" (inc 1) (anotherInc 1)

// why list is the last arg in the list funcions
let searchEven = Seq.filter (fun v -> v % 2 = 0)
printfn "%d even numbers in [1, 100]"
    ([ 1 .. 100] |> searchEven |> Seq.length)
printfn "%d even numbers in [1, 1000]"
    ([ 1 .. 1000] |> searchEven |> Seq.length)


let sub x y = x - y
// It would be nice to be able to swap the arguments of sub without changing its definition so that we can use currying and fix the subtracted value (now the first argument). The following function can help us to do this:
let swapargs f x y = f y x

let dec = swapargs sub 1
printfn "Before 10 there is %d" (dec 10)
