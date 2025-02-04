let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y

let z = add x y
printf "%d %d %d" x y z //expect 30 20 20, but get 30 30 20