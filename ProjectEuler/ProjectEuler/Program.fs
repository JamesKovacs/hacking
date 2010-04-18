printfn "Project Euler"
printfn "============="

// #001: Add all the natural numbers below one thousand that are multiples of 3 or 5.
let zeroTo999 = [0..999]
let divBy3Or5 = zeroTo999 |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
let sln001 = divBy3Or5 |> List.fold (+) 0
printfn "#001: %i" sln001
assert (sln001=233168)

// #002: Find the sum of all the even-valued terms in the Fibonacci sequence which do not exceed four million.
let fibs = Seq.unfold (fun (i,j) -> Some(i,(j,i+j))) (0,1)
let lessThan x = Seq.takeWhile (fun i -> i < x)
let onlyEven = Seq.filter (fun x -> x % 2 = 0)
let sum = Seq.fold (+) 0
let sln002 = sum (onlyEven fibs |> lessThan 4000000)
printfn "#002: %i" sln002
assert (sln002=4613732)

// #003: Find the largest prime factor of a composite number.
//printfn "#002: %i" sln003