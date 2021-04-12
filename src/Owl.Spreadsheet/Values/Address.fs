﻿namespace Owl.Spreadsheet

[<Struct>]
type Address = { row: int; column: int }
with
  member __.to_tuple() = (__.row, __.column)
  member __.to_string() = $"%s{__.column.to_column_name()}%d{__.row}"
