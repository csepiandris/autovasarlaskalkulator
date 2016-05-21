// Gépjármű vásárlás kalkulátor
open System.Net
open System.IO


printf "Üdvözöllek a gépjármű vásárlás kalkulátorban! Kezdéshez nyomj egy entert!"
System.Console.ReadLine()

printf "Add meg a jármű gyártóját és típusát!: "
let auto = System.Console.ReadLine()

printf "A jármű vételára: "
let ara = System.Console.ReadLine() |> System.Int32.Parse

printf "A jármű kora (év): "
let kor = System.Console.ReadLine() |> System.Int32.Parse

printf "A jármű teljesítménye (kw): "
let kw = System.Console.ReadLine() |> System.Int32.Parse

printf "A jármű lökettérfogata (ccm): "
let ccm = System.Console.ReadLine() |> System.Int32.Parse

// operator helper
let inline (<=.) left middle = (left <= middle, middle)
let inline (.<=) (leftResult, middle) right = leftResult && (middle <= right)
let inline (.<=.) middleLeft middleRight = (middleLeft .<= middleRight, middleRight)

// vagyonszerzési illeték
let illetek = 
    if 0 <=. kw .<= 40 then 
        if 0 <=. kor .<= 3 then kw * 550
        elif 4 <=. kor .<= 8 then kw * 450
        else kw * 350
    elif 41 <=. kw .<= 80 then 
        if 0 <=. kor .<= 3 then kw * 650
        elif 4 <=. kor .<= 8 then kw * 550
        else kw * 450
    elif 81 <=. kw .<= 120 then 
        if 0 <=. kor .<= 3 then kw * 750
        elif 4 <=. kor .<= 8 then kw * 650
        else kw * 550
    else 
        if 0 <=. kor .<= 3 then kw * 850
        elif 4 <=. kor .<= 8 then kw * 750
        else kw * 650

// eredetiség vizsgálat díja
let eredetiseg = 
    if 0 <=. ccm .<= 1400 then 17000
    elif 1401 <=. ccm .<= 2000 then 18500
    else 20000

let atiratas = eredetiseg + illetek + 12000
let vegosszeg = atiratas + ara

printf "Nyomj entert az összeg kiszámításához!"
System.Console.ReadLine()

printfn "A megnevezett autóhoz (%s) a díjak:" auto
printfn "Vagyonszerzési illeték: %d Ft" illetek
printfn "Új forgalmi engedély: 6000 Ft"
printfn "Új törzskönyv: 6000 Ft"
printfn "Eredetiségvizsga: %d Ft" eredetiseg
printfn "____________________________________"
printfn "Átiratás összesen: %d" atiratas
printfn "Vételárral együtt: %d" vegosszeg







    


    






System.Console.ReadKey()


