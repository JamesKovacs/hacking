module Program

printfn "Project Euler"
printfn "============="

let stopwatch = new System.Diagnostics.Stopwatch()
stopwatch.Start()

//Problem001.Run
//Problem002.Run
//Problem003.Run
//Problem004.Run
Problem005.Run

printfn "%A ms" stopwatch.ElapsedMilliseconds
printfn "Press <ENTER> to exit..."
let endOfApp = System.Console.ReadKey()
