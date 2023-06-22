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