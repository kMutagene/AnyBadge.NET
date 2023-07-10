module BadgeTests

open Xunit
open AnyBadge.NET
open System

//Test that label and value widths are equal when text is the same.
[<Fact>]
let ``badge equal label value width`` () =
    let badge = Badge(label="a", value="a", NumPaddingChars=0)
    Assert.Equal(badge.LabelWidth, badge.ValueWidth)

//Test that the color split is in the middle when label and value are equal width.
[<Fact>]
let ``test badge equal split`` () =
    let badge = Badge(label="a", value="a")
    Assert.Equal(int(float badge.BadgeWidth / 2.), badge.ColorSplitPosition)


//Test the width of a badge generated with a long text value.
[<Fact>]
let ``test badge equal split no padding`` () =
    let badge = Badge(
        label="CppCheck",
        value="err: 2 | warn: 9 | info: 99 | style: 365",
        DefaultColor="red"
    )
    Assert.True(badge.BadgeWidth <= 326)

//Test the width of a badge generated with a long text value and no padding.
[<Fact>]
let ``test badge width with long value text zero padding`` () =
    let badge = Badge(
        label="CppCheck",
        value="err: 2 | warn: 9 | info: 99 | style: 365",
        DefaultColor="red",
        NumPaddingChars=0
    )
    Assert.True(badge.BadgeWidth <= 306)


//Test the width of a badge generated with a medium text value.
[<Fact>]
let ``test badge width with medium value text`` () = 
    let badge = Badge(label="medium", value="89.67%", DefaultColor="green")
    Assert.True(badge.BadgeWidth <= 138)

//Test the width of a badge generated with a medium text value and no padding.
[<Fact>]
let ``test badge width with medium value text zero pad`` () =
    let badge = Badge(
        label="medium no padding",
        value="89.67%",
        DefaultColor="green",
        NumPaddingChars=0
    )
    Assert.True(badge.BadgeWidth <= 156)

[<Fact>]
let ``test badge width with short value text`` () =
    let badge = Badge(label="short", value="1", DefaultColor="green")
    Assert.True(badge.BadgeWidth <= 101)

[<Fact>]
let ``test badge width with short value text zero pad`` () =
    let badge = Badge(
        label="short value no padding",
        value="1",
        DefaultColor="green",
        NumPaddingChars=0
    )
    Assert.True(badge.BadgeWidth <= 143)

[<Fact>]
let ``test badge width with tiny value text`` () =
    let badge = Badge(label="a", value="1", DefaultColor="green")
    Assert.True(badge.BadgeWidth <= 76)

[<Fact>]
let ``test badge width with tiny value text no padding`` () =
    let badge = Badge(label="a", value="1", DefaultColor="green", NumPaddingChars=0)
    Assert.True(badge.BadgeWidth <= 76)

[<Fact>]
let ``test badge width thresholds`` () =
    let thresholds = Map(["2", "red"; "4", "orange"; "6", "green"; "8", "brightgreen"])
    let badge = Badge(label="thresholds", value="2.22", ValueSuffix="%", Thresholds=thresholds)
    Assert.Equal(badge.BadgeColorCode, Color.toHexCode(ORANGE))

[<Fact>]
let ``test badge with text color`` () =
    let badge = Badge(
        label="text color",
        value="2.22",
        ValueSuffix="%",
        TextColor="#010101"
    )
    Assert.Equal(badge.TextColor, Color.toHexCode(Color.Custom "#010101"))

[<Fact>]
let ``test multiple badges in one session`` () =
    let badges = [
        Badge(label="multiple 1", value="100", ValueSuffix="%", NumPaddingChars=0)
        Badge(label="multiple 2", value="1234567890")
    ]
    Assert.NotEqual(badges.[0].BadgeWidth, badges.[1].BadgeWidth)

[<Fact>]
let ``test multiple badges get different mask`` () =
    let badges = [
        Badge(label="multiple 1", value="100", ValueSuffix="%", NumPaddingChars=0)
        Badge(label="multiple 2", value="1234567890")
    ]
    Assert.NotEqual(badges.[0].MaskStr, badges.[1].MaskStr)

[<Fact>]
let ``test integer str value is handled as integer`` () =
    let badge = Badge(label="integer", value="1234")
    Assert.True(badge.ValueIsInt)
    Assert.False(badge.ValueIsFloat)

[<Fact>]
let ``test integer int value is handled as integer`` () =
    let badge = Badge(label="integer", value=1234)
    Assert.True(badge.ValueIsInt)
    Assert.False(badge.ValueIsFloat)

[<Fact>]
let ``test float str value is handled as float`` () =
    let badge = Badge(label="float str", value="1234.1")
    Assert.False(badge.ValueIsInt)
    Assert.True(badge.ValueIsFloat)

[<Fact>]
let ``test float value is handled as float`` () =
    let badge = Badge(label="float int", value=1234.1)
    Assert.False(badge.ValueIsInt)
    Assert.True(badge.ValueIsFloat)

[<Fact>]
let ``test float value with zero decimal`` () =
    let badge = Badge(label="float with zeros", value="10.00")
    Assert.False(badge.ValueIsInt)
    Assert.True(badge.ValueIsFloat)

[<Fact>]
let ``test float value with non zero decimal`` () =
    let badge = Badge(label="float str no decimal", value="10.01")
    Assert.False(badge.ValueIsInt)
    Assert.True(badge.ValueIsFloat)

[<Fact>]
let ``test label width no padding`` () =
    let badge = Badge(label="a", value="1", NumLabelPaddingChars = 0)
    Assert.True(badge.LabelWidth <= 7)

[<Fact>]
let ``test label width with padding`` () =
    let badge = Badge(label="a", value="1", NumLabelPaddingChars = 2)
    Assert.True(badge.LabelWidth <= 47)

[<Fact>]
let ``test value width no padding`` () =
    let badge = Badge(label="a", value="1", NumLabelPaddingChars = 0)
    Assert.Equal(badge.ValueWidth,  7)

[<Fact>]
let ``test value width with padding`` () =
    let badge = Badge(label="a", value="1", NumLabelPaddingChars = 2)
    Assert.True(badge.ValueWidth <= 47)

[<Fact>]
let ``test value formatting`` () =
    let badge = Badge(label="value formatting", value="10", ValueFormat = Printf.StringFormat<_>("%s hits/sec"))
    Assert.Equal("10 hits/sec", badge.ValueText)

[<Fact>]
let ``test font name`` () =
    let font = "Arial, Helvetica, sans-serif"
    let badge = Badge(label="font", value=font, FontName=font)

    Assert.Equal(badge.FontName,font)

[<Fact>]
let ``test invalid font name`` () =
    let font = "Invalid font"
    Assert.Throws<System.Exception>(fun () -> Badge(label="font", value=font, FontName=font) |> ignore)

[<Fact>]
let ``test font size`` () =
    let badge = Badge(label="font size", value=10, FontSize=10)
    Assert.Equal(badge.FontSize, 10)

[<Fact>]
let ``test invalid color`` () =
    //Assert.Throws<System.Exception>(fun () -> Color.fromString "soos" |> ignore)
    Assert.Throws<System.Exception>(fun () -> Badge(label="label", value="fred", DefaultColor="soos") |> ignore)

// Test wether value width is calculated correctly when using a value prefix
[<Fact>]
let ``test value width with prefix``() =
    let badge = Badge(label = "aa", value= "a", ValuePrefix="a")
    Assert.Equal(badge.LabelWidth, badge.ValueWidth)
    Assert.Equal(24, badge.ValueWidth)

// Test wether value width is calculated correctly when using a value suffix
[<Fact>]
let ``test value width with suffix``() =
    let badge = Badge(label = "aa", value= "a", ValueSuffix="a")
    Assert.Equal(badge.LabelWidth, badge.ValueWidth)
    Assert.Equal(24, badge.ValueWidth)

// Test wether value width is calculated correctly when using a value suffix
[<Fact>]
let ``test value width with pefix and suffix``() =
    let badge = Badge(label = "aaa", value= "a", ValueSuffix="a", ValuePrefix = "a")
    Assert.Equal(badge.LabelWidth, badge.ValueWidth)
    Assert.Equal(31, badge.ValueWidth)

[<Fact>]
let ``test simple badge write`` () =
    let badge = Badge(
        label = "label",
        value = "value"
    )
    let p = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "test.svg")
    badge.WriteBadge(p)
    let result = System.IO.File.ReadAllText(p)
    Assert.Equal(badge.BadgeSvgText, result)