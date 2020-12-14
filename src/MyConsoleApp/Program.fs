open MyLibrary.Cli

let parseUserArgs argv =
    let parser = Argu.ArgumentParser.Create<CliArguments>(programName = "gadget.exe")
    let usage = parser.PrintUsage()
    let results = (parser.Parse argv).GetAllResults()
    results, usage
   
[<EntryPoint>]
let main argv =
    let commands, usage = parseUserArgs argv
    match commands with
    | [] -> printfn "%s" usage
            1
    | _  -> printfn  "%A" commands
            0
