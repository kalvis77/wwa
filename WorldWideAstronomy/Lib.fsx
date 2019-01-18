#r @"C:\Users\kalvis\Documents\Projects\wwa\WorldWideAstronomy\WWA\bin\Debug\WWA.dll"

open WorldWideAstronomy
let m1 = ref 0.0
let m2 = ref 0.0
let e = WWA.wwaCal2jd(2018, 5, 12, m1, m2)
printfn "%A %A " !m1 !m2
//let rc = WWA