let (a,b) = (1,2)

printfn "a = %d" a
printfn "b = %d" b

let addPair (f,s) = f + s

let addPair2 p =
    match p with
        | (f, 0) -> f
        | (0, s) -> s
        | (f, s) -> f + s

// addPair and addPair2 are equivalent

let equivalent = addPair (0, 2) = addPair2 (0, 2)


