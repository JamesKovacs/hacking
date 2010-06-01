module Problem003

// #003: Find the largest prime factor of 600851475143.
open Helpers
let Run =
    let number = 600851475143L

    let inline isFactor n d = n % d = 0L

    let primeFactors n =
        let rec inner n factors =
            seq {
                let f = Seq.head factors
                if isFactor n f then
                    yield f
                    if float f > sqrt (float n) then
                        yield n
                    else
                        yield! inner (n/f) factors
                elif n > f then
                    yield! inner n (Seq.skip 1 factors)
            }
        inner n primes

    let sln003 = primeFactors number |> Seq.max
    printfn "#003: %i" sln003
    assert (sln003=6857L)

