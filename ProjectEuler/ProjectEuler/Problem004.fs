module Problem004

(* #004: 
    A palindromic number reads the same both ways. The largest palindrome made 
    from the product of two 2-digit numbers is 9009 = 91 × 99.
    Find the largest palindrome made from the product of two 3-digit numbers.
*)
let Run =
    let isPalindrome n =
        let s = sprintf "%d" n |> Array.ofSeq
        let rev_s = Array.rev s
        Array.forall2 (fun a b -> a = b) s rev_s

    let threeDigits = {999..-1..100}
    let products = Seq.collect (fun x -> Seq.map (fun y -> x*y) threeDigits) threeDigits
    let largestPalindrome = products |> Seq.filter isPalindrome |> Seq.max
    printfn "#004: %d" largestPalindrome
    assert (largestPalindrome = 906609)
    