module Arithmetic =
    let add a b = a + b

    let subtract a b = a - b

    let multiply a b = a * b

    let divide a b =
        if b = 0 then
            Error "Division by zero is not allowed."
        else
            Ok (a / b)
