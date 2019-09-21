#r @"C:\Users\kalvis\Documents\Projects\wwa\WorldWideAstronomy\WWA\bin\Debug\WWA.dll"

open WorldWideAstronomy
open System

// Classic F# reference
let m1 = ref 0.0
let m2 = ref 0.0
let e = WWA.wwaCal2jd(2018, 5, 12, m1, m2)
printfn "%A %A " !m1 !m2

// Use mutable as from F# 4.0, enable warnings to see stack or heap allocation
let mutable e1 = 1.0
let mutable e2 = 1.0
WWA.wwaCal2jd(2018, 5, 12, &e1, &e2) |> ignore
printfn "%A %A " e1 e2

let pi_d = 3.14159265358979323846
printfn "pi = %.33f\n   + %.33f\n   + %.33f\n" pi_d (sin(pi_d)) (Math.PI)
let t = Math.Sin(1e22)
printfn "%.33f" t