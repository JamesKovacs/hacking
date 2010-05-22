module Problem002

// #002: Find the sum of all the even-valued terms in the Fibonacci sequence which do not exceed four million.
let Run =
    let fibs = Seq.unfold (fun (i,j) -> Some(i,(j,i+j))) (0,1)
    let lessThanOrEqualTo x = Seq.takeWhile (fun i -> i <= x)
    let onlyEven = Seq.filter (fun x -> x % 2 = 0)
    let sum = Seq.fold (+) 0
    let sln002 = sum (onlyEven fibs |> lessThanOrEqualTo 4000000)
    printfn "#002: %i" sln002
    assert (sln002=4613732)