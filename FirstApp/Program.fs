namespace FirstApp


module Program =
    open System
    open System

    let ``say hello`` =
        printfn "Olá F#!"

    let elevaNumeroAoQuadrado numero = numero * numero

    let somaQuadradoDosNumerosAteDez =
       [1..10] 
       |> List.map elevaNumeroAoQuadrado 
       |> List.sum

    [<EntryPoint>]
    let main argv =
        ``say hello``

        printfn "%i" somaQuadradoDosNumerosAteDez

        let periodoTeste = { PeriodoDeTempo.DataInicial =  DateTime.Parse "21/11/1988"; PeriodoDeTempo.DataFinal = DateTime.Parse("29/10/1989") }

        let datasParaTeste =
            [
                DateTime.Parse "13/01/1989"
                DateTime.Parse "05/05/1998"
                DateTime.Parse "29/10/1989"
            ]

        datasParaTeste
        |> List.iter (fun e -> printfn "%b" (PeriodoDeTempo.verificaSeDataEstaDentroDoPeriodo periodoTeste e))

        Console.ReadKey() |> ignore

        0 // return an integer exit code
