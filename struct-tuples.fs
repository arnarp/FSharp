// Creating a new struct tuple.
let origin = struct (0, 0)

// Take struct tuples as arguments to a function and generate a new struct tuple.
let getPointFromOffset (point: struct (x, y)) (offset: struct (dx, dy)) =
    struct (x + dx, y + dy)

// Pattern match on a struct tuple.
let doAMatch (input: struct (x, y)) =
    match input with
    | struct (0, 0) -> sprintf "The tuple is the origin!"
    | struct (_, _) -> sprintf "The tuple is NOT the origin!"

// Attempt to use a struct tuple as a reference tuple.
//
// This results in a compiler error.
let thisWillFail (x : struct (int, int)) : (int * int) = x