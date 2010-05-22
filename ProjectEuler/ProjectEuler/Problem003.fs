module Problem003

// #003: Find the largest prime factor of 600851475143.
let Run =
    //let number = 100L
    let number = 600851475143L
    let reinsert x table prime =
       let comp = x+prime
       match Map.tryFind comp table with
       | None        -> table |> Map.add comp [prime]
       | Some(facts) -> table |> Map.add comp (prime::facts)

    let rec sieve x table =
      seq {
        match Map.tryFind x table with
        | None ->
            yield x
            yield! sieve (x+1L) (table |> Map.add (x*x) [x])
        | Some(factors) ->
            yield! sieve (x+1L) (factors |> List.fold (reinsert x) (table |> Map.remove x)) }

    let primes = sieve 2L Map.empty 

    let inline isFactor n d = n % d = 0L

    let primeFactors n =
        let rec inner n factors =
            seq {
                let f = Seq.head factors
                if isFactor n f then
                    yield f
                    yield! inner (n/f) factors
                elif n > f then
                    yield! inner n (Seq.skip 1 factors)
            }
        inner n primes

    let sln003 = primeFactors number |> Seq.max
    printfn "#003: %i" sln003
    assert (sln003=6857L)

