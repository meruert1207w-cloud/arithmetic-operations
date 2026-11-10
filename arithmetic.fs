module Arithmetic =
    let add = function
        | (a: float, b: float) -> a + b

    let subtract = function
        | (a: float, b: float) -> a - b

    let multiply = function
        | (a: float, b: float) -> a * b

    let divide = function
        | (a: float, b: float) when b = 0.0 -> Error "Division by zero is not allowed."
        | (a: float, b: float) -> Ok (a / b)
