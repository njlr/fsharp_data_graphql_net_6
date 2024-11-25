module FSharp.Data.GraphQL.Net6

open FSharp.Data.GraphQL
open FSharp.Data.GraphQL.Types

let queryType =
  Define.Object(
    name = "Query",
    fields =
      [
        Define.Field("hello", StringType, fun _ _ -> "world")
      ]
  )

let query = """{
  hello
}"""

[<EntryPoint>]
let main argv =
  async {
    let schema = Schema(queryType)
    let executor = Executor<unit>(schema)

    let! response = executor.AsyncExecute(query)

    printfn $"%A{response}"
  }
  |> Async.RunSynchronously
  0
