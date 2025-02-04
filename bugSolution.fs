let x = ref 10
let y = ref 20

let add x y = 
    x := !x + !y
    !y

let z = add x y
printf "%d %d %d" !x !y z //expect 30 20 20