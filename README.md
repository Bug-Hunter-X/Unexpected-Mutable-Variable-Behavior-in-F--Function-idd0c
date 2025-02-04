# F# Mutable Variable Bug

This repository demonstrates a subtle bug related to mutable variables and function calls in F#.  The issue arises from a misunderstanding of how mutable variables are handled within function scopes and how the `let` keyword behaves with mutable values.  The original code exhibits unexpected behavior compared to the developer's assumptions about mutable variable state after a function call.

## Bug Description
The primary problem lies in the `add` function.  It modifies both `x` and `y` directly but the return value does not align with the expected behavior concerning the final values of x and y. The expectation is that x and y would take on different values after calling the function, but the result differs unexpectedly.