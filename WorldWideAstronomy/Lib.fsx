#I __SOURCE_DIRECTORY__
#r @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\netstandard.dll"
#r @"C:\Users\kalvis\source\repos\wwa\WorldWideAstronomy\WWA.Core\bin\Debug\netcoreapp3.0\WWA.Core.dll"
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

WWA.wwaCal2jd(2017, 3, 17, &e1, &e2) |> ignore
let gmst = WWA.wwaGmst82(e1, e2)

let mutable sign = ' '
let hms = Array.zeroCreate<int> 4
//11h 38m 2.7608sec, Mica  2.7586 mine 1982: 2.7608
let r = WWA.wwaA2tf(4, gmst, &sign, hms)

let gmst2 = WWA.wwaGmst82(2457829.5, 0.0 )
let r2 = WWA.wwaA2tf(6, gmst2, &sign, hms)