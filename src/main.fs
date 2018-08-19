module Spreadsheet
open Fable.Core
open Fable.Import
open Elmish

type Model = string
let initial:Model = "Hallo Welt"
let render _ state  =   h?h1 [] [text state]
let update state _ = state

app "main" initial render update
