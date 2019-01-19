#r @"C:\Users\kalvis\Documents\Projects\wwa\WorldWideAstronomy\WWA\bin\Debug\WWA.dll"

open WorldWideAstronomy
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