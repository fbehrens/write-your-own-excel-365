# Write your own exel 

Is a talk of Tomas Petricek on NDC Oslo 2018: https://www.youtube.com/watch?v=Bnm71YEt_lI

He kindly provided the slides along with the code: https://github.com/tpetricek/Talks/tree/master/2018/write-your-own-excel

I used this to learn how this all works.

# Installation

```
yarn install
npm run start
```

Now Point you browser to http://localhost:8080

```
// ----------------------------------------------------------------------------

// STEP #1
//
// TODO: Define Position and State with Rows, Cols, Active & Cells
// DEMO: Create an initial state
// DEMO: app "main" initial render update
// TODO: Define silly `render` and `update` functions  
// TODO: Render grid in `render` and call `renderCell trigger pos state`

// ----------------------------------------------------------------------------

// STEP #2
//
// DEMO: Rendering functions `renderEditor` and `renderView` 
// TODO: Define `Event` with `StartEdit` and `UpdateValue`
// TODO: "onclick" =!> fun _ -> trigger(StartEdit(pos)) & update `update` function
// DEMO: "oninput" =!> fun d -> trigger (UpdateValue(pos, unbox d?target?value)) & `update`

// ----------------------------------------------------------------------------

// STEP #3
//
// TODO: Define `Expr` as either `Number` or `Binary`
// TODO: Operator is `char '+'` etc.
// TODO: Number is `integer` mapped into `Number`
// TODO: Define binary and expr is number or binary
// TODO: `run expr input`

// ----------------------------------------------------------------------------

// STEP #4
//
// TODO: Add recursive evaluator
// DEMO: let ops = dict ['+', (+); '-', (-); '*', (*); '/', (/)]
// DEMO: Parse expressions with brackets
// TODO: Add `Reference of Position` case
// TODO: `reference = letter <*> integer |> map Reference` in the parser

// ----------------------------------------------------------------------------

// STEP #5
//
// TODO: Return option from `evaluate` and use `Option.bind`
// DEMO: "style" => if Option.isNone value then "background:#ffe0e0" else ""
// TODO: Add recursion check to the evaluator (using a set)

// ----------------------------------------------------------------------------
```
