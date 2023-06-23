namespace AnyBadge.NET

open System.IO
open Globals

type TemplateStyle =
    | Default
    | GitLabScoped

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
    ?Thresholds: Map<float,string>,
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
    member this.Value_text_color = valueTextColor
    member this.Use_max_when_value_exceeds = defaultArg UseMaxWhenValueExceeds true
    //member this.Mask_str = self.__class__._get_next_mask_str() // not sure how to port this yet

    /// <summary>
    ///The total width of badge.
    ///
    ///┌───────────────────────────┬────────────────────────────────┐
    ///
    ///│--------Label text---------│-----------Value text-----------│
    ///
    ///└───────────────────────────┴────────────────────────────────┘
    ///
    ///◀────────────────────────────────────────────────────────────▶
    ///                         badge_width
    /// </summary>
    member this.BadgeWidth =
        this.LabelWidth + this.ValueWidth

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
            .Replace(FONT_SIZE, this.FontSize)
            .Replace(LABEL, this.Label)
            .Replace(VALUE, this.value_text)
            .Replace(LABEL_ANCHOR, str(this.label_anchor))
            .Replace(LABEL_ANCHOR_SHADOW, str(this.label_anchor_shadow))
            .Replace(VALUE_ANCHOR, str(this.value_anchor))
            .Replace(VALUE_ANCHOR_SHADOW, str(this.value_anchor_shadow))
            .Replace(COLOR, this.badge_color_code)
            .Replace(LABEL_TEXT_COLOR, this.label_text_color)
            .Replace(VALUE_TEXT_COLOR, this.value_text_color)
            .Replace(COLOR_SPLIT_X, str(this.color_split_position))
            .Replace(VALUE_WIDTH, str(this.value_width))
            .Replace(MASK_ID, this.mask_str)
            .Replace(VALUE_BOX_WIDTH, str(this.value_box_width))
            .Replace(ARC_START, str(this.arc_start))
        
