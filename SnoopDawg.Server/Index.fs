module SnoopDawg.Server.Index

open Bolero
open Bolero.Html
open Bolero.Server.Html
open SnoopDawg

let page = doctypeHtml {
    head {
        meta { attr.charset "UTF-8" }
        meta { attr.name "viewport"; attr.content "width=device-width, initial-scale=1.0" }
        title { "Bolero Application" }
        ``base`` { attr.href "/" }
        link { attr.rel "stylesheet"; attr.href "SnoopDawg.Client.styles.css" }
    }
    body {
        div { attr.id "main"; comp<Client.Main.MyApp> }
        boleroScript
    }
}
