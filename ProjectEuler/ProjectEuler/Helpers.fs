module Helpers

let primes =
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

    sieve 2L Map.empty 
