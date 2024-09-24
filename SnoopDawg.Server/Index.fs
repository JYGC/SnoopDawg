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
        link { attr.rel "stylesheet"; attr.href "https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.4/css/bulma.min.css" }
        link { attr.rel "stylesheet"; attr.href "css/index.css" }
        link { attr.rel "stylesheet"; attr.href "SnoopDawg.Client.styles.css" }
        link { attr.rel "manifest"; attr.href "manifest.json" }
        link { attr.rel "apple-touch-icon"; attr.sizes "512x512"; attr.href "icon-512.png" }
    }
    body {
        nav {
            attr.``class`` "navbar is-dark"
            "role" => "navigation"
            attr.aria "label" "main navigation"
            div {
                attr.``class`` "navbar-brand"
                a {
                    attr.``class`` "navbar-item has-text-weight-bold is-size-5"
                    attr.href "https://fsbolero.io"
                    img { attr.style "height:40px"; attr.src "https://github.com/fsbolero/website/raw/master/src/Website/img/wasm-fsharp.png" }
                    "  Bolero"
                }
            }
        }
        div { attr.id "main"; comp<Client.Main.MyApp> }
        boleroScript
        script { rawHtml "navigator.serviceWorker.register('service-worker.js');" }
    }
}
