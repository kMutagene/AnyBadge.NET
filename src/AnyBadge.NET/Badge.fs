namespace AnyBadge.NET

type Badge(
    Label: string,
    Value: string,
    ?FontName: string,
    ?FontSize: int,
    ?NumPaddingChars: int,
    ?NumLabelPaddingChars: float,
    ?NumValuePaddingChars: float,
    ?Template: string,
    ?Style: string,
    ?ValuePrefix: string,
    ?ValueSuffix: string,
    ?Thresholds: Map<float,string>,
    ?DefaultColor: string,
    ?UseMaxWhenValueExceeds: bool,
    ?ValueFormat: string,
    ?TextColor: string,
    ?Semver: bool
) = 
    member this.Label = Label
    member this.Value = Value