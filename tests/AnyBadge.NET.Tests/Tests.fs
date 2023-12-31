module Tests

open System
open Xunit

open AnyBadge.NET

[<Fact>]
let ``default svg template is correct`` () =
    Assert.Equal(
        Globals.DEFAULT_TEMPLATE,
        Common.getEmbeddedResource "templates.default.svg"
    )

[<Fact>]
let ``gitlab scoped svg template is correct`` () =
    Assert.Equal(
        Globals.GITLAB_SCOPED_TEMPLATE,
        Common.getEmbeddedResource "templates.gitlab_scoped.svg"
    )

[<Fact>]
let ``fixed width font width calculation`` () =
    let fontWidth = Helpers.getApproxStringWidth "GOOGLE|ijkl" 10 true
    Assert.Equal(110, fontWidth)

[<Fact>]
let ``non-fixed width font width approximation`` () =
    let fontWidth = Helpers.getApproxStringWidth "GOOGLE|ijkl" 10 false
    Assert.Equal(77, fontWidth)
