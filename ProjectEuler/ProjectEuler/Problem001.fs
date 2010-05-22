module Problem001

// #001: Add all the natural numbers below one thousand that are multiples of 3 or 5.
let Run =
    let naturalsBelow x = [0..x-1]
    let multipleOf x = fun i -> i % x = 0
    let multipleOf3Or5 x = x |> multipleOf 3 || x |> multipleOf 5
    let sln001 = naturalsBelow 1000 |> List.filter multipleOf3Or5 |> List.fold (+) 0
    printfn "#001: %i" sln001
    assert (sln001=233168)