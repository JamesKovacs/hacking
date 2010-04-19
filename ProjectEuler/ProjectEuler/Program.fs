printfn "Project Euler"
printfn "============="

// #001: Add all the natural numbers below one thousand that are multiples of 3 or 5.
let naturalsBelow x = [0..x-1]
let multipleOf x = fun i -> i % x = 0
let multipleOf3Or5 x = x |> multipleOf 3 || x |> multipleOf 5
let sln001 = naturalsBelow 1000 |> List.filter multipleOf3Or5 |> List.fold (+) 0
printfn "#001: %i" sln001
assert (sln001=233168)

// #002: Find the sum of all the even-valued terms in the Fibonacci sequence which do not exceed four million.
let fibs = Seq.unfold (fun (i,j) -> Some(i,(j,i+j))) (0,1)
let lessThanOrEqualTo x = Seq.takeWhile (fun i -> i <= x)
let onlyEven = Seq.filter (fun x -> x % 2 = 0)
let sum = Seq.fold (+) 0
let sln002 = sum (onlyEven fibs |> lessThanOrEqualTo 4000000)
printfn "#002: %i" sln002
assert (sln002=4613732)

// #003: Find the largest prime factor of 600851475143.
let number = 600851475143L
//printfn "#002: %i" sln003
//assert (sln003=???)