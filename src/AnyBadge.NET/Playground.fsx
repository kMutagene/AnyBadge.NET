#r "bin/Debug/net6.0/AnyBadge.NET.dll"

open AnyBadge.NET
open System.IO

let b = Badge("test", "42")

b.BadgeSvgText
|> fun b -> File.WriteAllText(@"C:\Users\schne\Source\repos\kMutagene\AnyBadge.NET\src\AnyBadge.NET\badge.svg", b)
