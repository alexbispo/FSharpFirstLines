namespace FirstApp

module PeriodoDeTempo =

    open System

    type Periodo = { DataInicial:DateTime; DataFinal:DateTime }

    let adicionarDias periodo dias = {
        DataInicial = periodo.DataInicial.AddDays dias
        DataFinal = periodo.DataFinal.AddDays dias
    }

    let verificaSeDataEstaDentroDoPeriodo periodo (dataParaTestar:DateTime) = 
        dataParaTestar.CompareTo periodo.DataInicial >= 0 && dataParaTestar.CompareTo periodo.DataFinal <= 0

