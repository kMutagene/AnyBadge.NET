namespace AnyBadge.NET

open System.IO
open Globals
open Semver

type TemplateStyle =
    | Default
    | GitLabScoped

type ValueType =
    | StringValue
    | IntValue
    | FloatValue
    | SemverValue

type Badge(
    Label: string,
    Value: string,
    ?FontName: string,
    ?FontSize: int,
    ?NumPaddingChars: int,
    ?NumLabelPaddingChars: float,
    ?NumValuePaddingChars: float,
    ?Template: string,
    ?Style: TemplateStyle,
    ?ValuePrefix: string,
    ?ValueSuffix: string,
    ?Thresholds: Map<string,string>,
    ?DefaultColor: string,
    ?UseMaxWhenValueExceeds: bool,
    ?ValueFormat,
    ?TextColor: string,
    ?Semver: bool
) = 
    // Set defaults if values were not passed
    let fontName = 
        let fn = defaultArg FontName Defaults.DEFAULT_FONT
        if not (Defaults.FONT_WIDTHS.ContainsKey(fn)) then
            failwithf "Font name '%s' not found. Available fonts: %s" fn (Defaults.FONT_WIDTHS.Keys |> String.concat ", ")
        fn

    let fontSize = defaultArg FontSize Defaults.DEFAULT_FONT_SIZE

    let numLabelPaddingChars = 
        match NumPaddingChars with
        | Some p -> float p
        | None -> defaultArg NumLabelPaddingChars Defaults.NUM_PADDING_CHARS
        
    let numValuePaddingChars = 
        match NumPaddingChars with
        | Some p -> float p
        | None -> defaultArg NumValuePaddingChars Defaults.NUM_PADDING_CHARS

    let template = defaultArg Template Globals.DEFAULT_TEMPLATE
    let style = defaultArg Style TemplateStyle.Default
    let defaultColor = defaultArg DefaultColor Defaults.DEFAULT_COLOR
    let textColor = defaultArg TextColor Defaults.DEFAULT_TEXT_COLOR

    let valueText =
        match ValueFormat with
        | Some f -> sprintf f Value
        | None -> Value

    // text_color can be passed as a single value or a pair of comma delimited values
    let textColors = textColor.Split(",")
    let labelTextColor = textColors.[0]
    let valueTextColor = 
        if textColors.Length > 1 then
            textColors.[1]
        else
            textColors.[0]
 
    member this.Label = Label
    member this.Value = Value

    member this.ValueIsVersion = defaultArg Semver false
    member this.ValueFormat = ValueFormat
    member this.ValuePrefix = defaultArg ValuePrefix ""
    member this.ValueSuffix = defaultArg ValueSuffix ""
    member this.ValueText = this.ValuePrefix + valueText + this.ValueSuffix
    member this.FontName = fontName
    member this.FontSize = fontSize
    member this.NumLabelPaddingChars = numLabelPaddingChars
    member this.NumValuePaddingChars = numValuePaddingChars
    member this.Template = template
    member this.Style = style
    member this.Thresholds = Thresholds
    member this.DefaultColor = defaultColor
    member this.TextColor = textColor
    member this.LabelTextColor = labelTextColor
    member this.ValueTextColor = valueTextColor
    member this.UseMaxWhenValueExceeds = defaultArg UseMaxWhenValueExceeds true
    member this.MaskStr = 
        Globals.maskId <- Globals.maskId + 1 // in the port we increase the mask id globally
        Globals.maskId

    /// <summary>
    /// Return the width multiplier for a font.
    ///
    ///    Returns:
    ///        int: Maximum pixel width of badges selected font.
    ///
    ///    Example:
    ///
    ///        >>> Badge(label='x', value='1').font_width
    ///        10
    /// </summary>
    member this.FontWidth = Defaults.FONT_WIDTHS[this.FontName][this.FontSize]

    /// <summary>
    /// Return the width of text.
    ///
    ///Args:
    ///    text(str): Text to get the pixel width of.
    ///
    ///Returns:
    ///    int: Pixel width of the given text based on the badges selected font.
    ///
    ///This implementation assumes a fixed font of:
    ///
    ///font-family="DejaVu Sans,Verdana,Geneva,sans-serif" font-size="11"
    ///>>> badge = Badge('x', 1, font_name='DejaVu Sans,Verdana,Geneva,sans-serif', font_size=11)
    ///>>> badge.get_text_width('pylint')
    ///34
    /// </summary>
    /// <param name="text"></param>
    member this.GetTextWidth(text: string) = Helpers.getApproxStringWidth text this.FontWidth false

    /// <summary>
    /// The SVG width of the label text.
    /// </summary>
    member this.LabelWidth =

        float (this.GetTextWidth(this.Label))
        + (2.0 * this.NumLabelPaddingChars * (float this.FontWidth))
        |> int

    /// <summary>
    /// The SVG width of the value text.
    /// </summary>
    member this.ValueWidth =

        float (this.GetTextWidth(this.Value))
        + (2.0 * this.NumLabelPaddingChars * (float this.FontWidth))
        |> int

    /// <summary>
    /// The SVG width of the value text box.
    /// </summary>
    member this.ValueBoxWidth = this.ValueWidth - 9

    /// <summary>
    ///The total width of badge.
    /// </summary>
    member this.BadgeWidth =
        this.LabelWidth + this.ValueWidth

    /// <summary>
    /// The SVG x position where the color split should occur.
    /// </summary>
    member this.ColorSplitPosition =  this.BadgeWidth - this.ValueWidth

    /// <summary>
    /// The SVG x position of the middle anchor for the label text.
    /// </summary>
    member this.LabelAnchor = float this.ColorSplitPosition / 2.

    /// <summary>
    /// The SVG x position of the middle anchor for the value text.
    /// </summary>
    member this.ValueAnchor =
        float this.ColorSplitPosition + ((float this.BadgeWidth - float this.ColorSplitPosition) / 2.)

    ///<summary>
    /// The SVG x position of the label shadow anchor.
    /// </summary>
    member this.LabelAnchorShadow = this.LabelAnchor + 1.

    /// <summary>
    /// The SVG x position of the value shadow anchor.
    /// </summary>
    member this.ValueAnchorShadow = this.ValueAnchor + 1.

    /// <summary>
    /// The position where the arc on the arc should start.
    /// </summary>
    member this.ArcStart = this.BadgeWidth - 10

    member this.ValueIsInt = 
        //"""Identify whether the value text is an int.
        //
        //Returns: bool
        //"""
        try
            let a = int(this.Value)
            let b = float(this.Value)
            float a = b
        with _ ->
            false
            

    member this.ValueIsFloat =
        // If the value is an int then it should not be considered a float.
        // We need to check this first before we check whether it is a float because the
        // float check also returns True for an int string.
        if this.ValueIsInt then
            false
        else
            try
                float(this.Value) |> ignore
                true
            with _ ->
                false


    member this.ValueType =
        if this.ValueIsVersion then
            ValueType.SemverValue 
        elif this.ValueIsFloat then
            ValueType.FloatValue
        elif this.ValueIsInt then
            ValueType.IntValue
        else
            ValueType.StringValue

    member this.SemverVersion =
        if this.ValueIsVersion && this.ValueType = ValueType.SemverValue then
            Some (SemVersion.Parse(this.Value, style=SemVersionStyles.Any))
        else
            None

    //"""Thresholds as a dict using Version as keys."""
    member this.SemverThresholds =
        // Version is not a hashable type, so can't be used to create an
        // ordered dict directly. First we need to create an ordered list of keys
        match this.Thresholds with
        | None -> None
        | Some t ->
            if this.ValueIsVersion && this.ValueType = ValueType.SemverValue then
                Some (
                    t 
                    |> Map.toArray
                    |> Array.map (fun (ver,col) ->
                        SemVersion.Parse(ver, style=SemVersionStyles.Any), col
                    )
                    |> Map.ofArray
                )
            else
                None

    member this.FloatThresholds =
        //"""Thresholds as a dict using float as keys."""
        match this.Thresholds with
        | None -> None
        | Some t ->
            if this.ValueIsFloat || this.ValueIsInt then
                Some (
                        t 
                        |> Map.toArray
                        |> Array.map (fun (step,col) ->
                            float step, col
                        )
                        |> Map.ofArray
                    )
                else
                    None


    /// <summary>
    /// Return the color code for the badge.
    /// </summary>
    // TO-DO: threshold logic
    member this.BadgeColor = 
        //"""Badge color based on the configured thresholds."""
        // If no thresholds were passed then return the default color
        match this.Thresholds with 
        | None -> this.DefaultColor
        | Some t ->
            match this.ValueType with
            | ValueType.StringValue ->
                if Map.containsKey this.Value t then
                    t[this.Value]
                else
                    this.DefaultColor
            | ValueType.SemverValue ->
                // Set value and thresholds based on the value type. This will result in either
                // value and thresholds as floats or value and thresholds as semantic versions.
                
                let thresholds = this.SemverThresholds.Value
                let value = this.SemverVersion.Value

                let mutable exceeds = true
                let mutable color = this.DefaultColor

                thresholds
                |> Map.toSeq
                |> Seq.rev
                |> Seq.iter (fun (threshold,thresholdColor) ->
                    if value < threshold then 
                        color <- thresholdColor
                        exceeds <- false
                )

                if not exceeds then
                    color
                elif this.UseMaxWhenValueExceeds then
                    thresholds.[thresholds.Keys |> Seq.max]
                else
                    this.DefaultColor

            | _ ->
                let thresholds = this.FloatThresholds.Value
                let value = float this.Value

                let mutable exceeds = true
                let mutable color = this.DefaultColor

                thresholds
                |> Map.toSeq
                |> Seq.rev
                |> Seq.iter (fun (threshold,thresholdColor) ->
                    if value < threshold then 
                        color <- thresholdColor
                        exceeds <- false
                )

                if not exceeds then
                    color
                elif this.UseMaxWhenValueExceeds then
                    thresholds.[thresholds.Keys |> Seq.max]
                else
                    this.DefaultColor

    ///<summary>
    /// Return the color code for the badge.
    /// </summary>
    member this.BadgeColorCode = 
        this.BadgeColor
        |> Color.fromString
        |> Color.toHexCode


    ///<summary>
    /// Return the correct SVG template to render, based on the style and template
    /// that have been set
    ///</summary>
    member this.GetSvgTemplate() =

        if this.Style = TemplateStyle.GitLabScoped then
            Globals.GITLAB_SCOPED_TEMPLATE
        else
            // Identify whether template is a file or the actual template text
            if this.Template.Split("\n").Length = 1 then
                try 
                    File.ReadAllText(this.Template)
                with _ ->
                    failwith "need to implement unknown template error in the future"
                    
            else
                this.Template


    member this.BadgeSvgText =

        let badgeText = this.GetSvgTemplate()

        badgeText
            .Replace(BADGE_WIDTH, string this.BadgeWidth)
            .Replace(FONT_NAME, this.FontName)
            .Replace(FONT_SIZE, string this.FontSize)
            .Replace(LABEL, this.Label)
            .Replace(VALUE, this.ValueText)
            .Replace(LABEL_ANCHOR, string this.LabelAnchor)
            .Replace(LABEL_ANCHOR_SHADOW, string this.LabelAnchorShadow)
            .Replace(VALUE_ANCHOR, string this.ValueAnchor)
            .Replace(VALUE_ANCHOR_SHADOW, string this.ValueAnchorShadow)
            .Replace(COLOR, this.BadgeColorCode)
            .Replace(LABEL_TEXT_COLOR, this.LabelTextColor)
            .Replace(VALUE_TEXT_COLOR, this.ValueTextColor)
            .Replace(COLOR_SPLIT_X, string this.ColorSplitPosition)
            .Replace(VALUE_WIDTH, string this.ValueWidth)
            //.Replace(MASK_ID, this.mask_str)
            .Replace(VALUE_BOX_WIDTH, string this.ValueBoxWidth)
            .Replace(ARC_START, string this.ArcStart)
        
    new (
        Label: string,
        Value: string,
        ?FontName: string,
        ?FontSize: int,
        ?NumPaddingChars: int,
        ?NumLabelPaddingChars: float,
        ?NumValuePaddingChars: float,
        ?Template: string,
        ?Style: TemplateStyle,
        ?ValuePrefix: string,
        ?ValueSuffix: string,
        ?Thresholds: Map<string,Color>,
        ?DefaultColor: Color,
        ?UseMaxWhenValueExceeds: bool,
        ?ValueFormat,
        ?TextColor: string,
        ?Semver: bool
    ) = 
        Badge(
            Label = Label,
            Value = Value,
            ?FontName = FontName,
            ?FontSize = FontSize,
            ?NumPaddingChars = NumPaddingChars,
            ?NumLabelPaddingChars = NumLabelPaddingChars,
            ?NumValuePaddingChars = NumValuePaddingChars,
            ?Template = Template,
            ?Style = Style,
            ?ValuePrefix = ValuePrefix,
            ?ValueSuffix = ValueSuffix,
            ?Thresholds = (
                Thresholds 
                |> Option.map (fun m ->
                    m |> Map.map (fun k v -> Color.toHexCode v)
                )
            ),
            ?DefaultColor = (DefaultColor |> Option.map Color.toHexCode),
            ?UseMaxWhenValueExceeds = UseMaxWhenValueExceeds,
            ?ValueFormat = ValueFormat,
            ?TextColor = TextColor,
            ?Semver = Semver
        )