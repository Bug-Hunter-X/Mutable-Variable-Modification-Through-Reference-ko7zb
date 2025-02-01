let mutable x = 1
let mutable y = ref x
printf "%d" x
y := 2
printf "%d" x
printf "%d" !y