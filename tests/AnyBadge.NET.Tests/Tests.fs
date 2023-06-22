module Tests

open System
open Xunit

open AnyBadge.NET

[<Fact>]
let ``Placeholder Test`` () =
    Assert.Equal(Say.hello "World", "Hello World")

