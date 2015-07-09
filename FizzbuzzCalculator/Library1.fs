namespace FizzbuzzCalculator

type FizzbuzzCalculator() = 
    static member fizzbuzzCalc(x) : string =
        if x % 3 = 0 && x % 5 = 0 then  "FizzBuzz"  
        elif x % 3 = 0 then  "Fizz"
        elif x % 5 = 0 then  "Buzz"
        else x.ToString()
