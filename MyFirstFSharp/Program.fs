// Learn more about F# at http://fsharp.net

#light

open System

let main() = 
    let print x = printfn "%s" x
    let welcome = "Welcome to my first F# Program"
    let finished =
        print "Finished!"
        Console.ReadLine()
    let list =  1 :: 2 :: 3 :: 4 :: []
    let printList = 
        for x in list do 
            printfn "%i" x
    let testLoop = 
        for i = 1 to 3 do
            printfn "Test"
                    
    print welcome
    testLoop
    printList

    let list =  1 :: 2 :: 3 :: 4 :: []
        
    for x in list do 
        printfn "%i" x

    let list2 =  [1..4]
        
    for x in list2 do 
        printfn "%i" x

    for x in [1..4] do 
        printfn "%i" x

    finished
    
main()