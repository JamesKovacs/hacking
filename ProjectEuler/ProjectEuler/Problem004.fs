module Problem004

(* #004: 
    A palindromic number reads the same both ways. The largest palindrome made 
    from the product of two 2-digit numbers is 9009 = 91 × 99.
    Find the largest palindrome made from the product of two 3-digit numbers.
*)
let Run =
    let reverse n =
        let rec loop n res =
            if n = 0 then res
            else loop (n/10) (res*10 + n%10)
        loop n 0

    let isPalindrome n =
        n = reverse n

    let threeDigits = {999..-1..100}
    let products = Seq.collect (fun x -> Seq.map (fun y -> x*y) (threeDigits |> Seq.filter (fun z -> z>=x))) threeDigits
    let largestPalindrome = products |> Seq.filter isPalindrome |> Seq.max
    printfn "#004: %d" largestPalindrome
    assert (largestPalindrome = 906609)
    