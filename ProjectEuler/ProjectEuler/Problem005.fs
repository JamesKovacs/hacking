module Problem005

(* #005:
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*)
open Helpers
let Run =
    let primeFactors n =
        let rec inner num primesToCheck result =
            let nextPrime = Seq.head primesToCheck
            match num % nextPrime with
            | 0L when num <> nextPrime -> inner (num/nextPrime) primesToCheck (nextPrime::result)
            | 0L when num = nextPrime -> nextPrime::result
            | _ -> inner num (primesToCheck |> Seq.skip 1) result
        inner n primes [] |> List.sort

    printfn "%d: %A" 100 (primeFactors 100L)
(*
    let smallestMultipleOf numbers =
        
        let rec inner innerNumbers result =
            printfn "inner %A %d" innerNumbers result
            match innerNumbers with
            | n::xs when result % n = 0 -> inner xs result
            | n::xs when result % n <> 0 -> inner xs (result*n)
            | [] -> result
            | _ -> result
        inner numbers 1

    let result = smallestMultipleOf [1;2;4;5;7;9] // [1;2;3;4;5;6;7;8;9;10]
    printfn "%d" result
    assert (result = 2520)

    1 * 2 * 3 * (2*2) * 5 * (2*3) * 7 * (2*2*2) * (3*3) * (2*5) = 720
    1 * 2 * 3 * 2 * 5 * 7 * 2 * 3 = 2520
*)