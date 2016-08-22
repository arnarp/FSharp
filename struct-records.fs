// Regular record type
type Vector3 = { X: float; Y: float; Z:float }

// Same record type, but now it's a struct
[<Struct>]
type StructVector3 = { X: float; Y: float; Z:float }