open System

let rec fibR n =
    if n=0 then 0
    elif n=1 then 1
    elif n=2 then 1
    else fibR (n-1) + fibR (n-2)+ fibR (n-3)

let sFiboR n =
    for i in 0..n-1 do
       printf "%d " (fibR i) 

let sFiboE n =
    let mutable a = 0
    let mutable b = 1
    let mutable c = 1
    let mutable d = 0
    for i in 0..n-1 do
       printf "%d " a
       d <- a + b + c
       a <- b
       b <- c
       c <- d

[<EntryPoint>]
let main argumentos = 
    Console.Write("Introduzca el un numero: ")
    let n1 = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine()
    Console.WriteLine("Sucesion fibonacci con funcion recursiva")
    Console.WriteLine(sFiboR n1)
    Console.WriteLine("Sucesion fibonacci con funcion estructurada")
    Console.WriteLine(sFiboE n1)
    let f = Console.ReadKey()
    0 

