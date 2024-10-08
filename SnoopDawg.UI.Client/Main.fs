module SnoopDawg.UI.Client.Main

open Elmish
open Bolero
open Bolero.Html
open Bolero.Templating.Client

type Model =
    {
        x: string
    }

let initModel =
    {
        x = ""
    }

type Message =
    | Ping

let update message model =
    match message with
    | Ping -> model

let view model dispatch =
    p { "Hello, world!" }

type MyApp() =
    inherit ProgramComponent<Model, Message>()

    override this.Program =
        Program.mkSimple (fun _ -> initModel) update view
#if DEBUG
        |> Program.withHotReload
#endif
