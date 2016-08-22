open System.Diagnostics

let traceMessage(msg : string,
                 [<CallerLineNumber>] ?line : int,
                 [<CallerFilePath>]   path : string) =
    Trace.WriteLine (sprintf "Message: %s" msg)
    Trace.WriteLine (sprintf "Line: %d" line.Value)
    Trace.WriteLine (sprintf "Path: %d" path)

let message = "Hello, World!"
traceMessage message

// Sample output:
//
// Message: Hello, World!
// Line: 10
// Path: c:\Users\heyitsme\Documents\Visual Studio 2015\Projects\CallerInfoFS\CallerInfoFS\demo.fs