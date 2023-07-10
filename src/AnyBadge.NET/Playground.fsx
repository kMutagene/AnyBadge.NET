#r "nuget: Semver"
#r "bin/Debug/net6.0/AnyBadge.NET.dll"

open AnyBadge.NET
open System.IO

let b = Badge("test", "42", DefaultColor = "#4c1", TextColor = "#fff")

b.BadgeSvgText
|> fun b -> File.WriteAllText(@"C:/Users/schne/Source/repos/kMutagene/AnyBadge.NET/src/AnyBadge.NET/badge.svg", b)

Badge(label="label", value="fred", DefaultColor="soos").BadgeColorCode

let color_badges = 
    [
        BLACK
        NAVY 
        DARKBLUE
        MEDIUMBLUE
        BLUE 
        DARKGREEN 
        GREEN_2 
        TEAL 
        DARKCYAN
        DEEPSKYBLUE
        DARKTURQUOISE 
        MEDIUMSPRINGGREEN 
        LIME 
        SPRINGGREEN 
        AQUA 
        CYAN 
        MIDNIGHTBLUE
        DODGERBLUE
        LIGHTSEAGREEN
        FORESTGREEN
        SEAGREEN
        DARKSLATEGRAY
        DARKSLATEGREY
        LIMEGREEN 
        MEDIUMSEAGREEN 
        TURQUOISE 
        ROYALBLUE 
        STEELBLUE 
        DARKSLATEBLUE 
        MEDIUMTURQUOISE 
        INDIGO 
        GREEN 
        DARKOLIVEGREEN 
        CADETBLUE 
        CORNFLOWERBLUE 
        REBECCAPURPLE 
        MEDIUMAQUAMARINE 
        DIMGRAY
        DIMGREY
        SLATEBLUE
        OLIVEDRAB
        SLATEGRAY
        SLATEGREY
        LIGHTSLATEGRAY 
        LIGHTSLATEGREY 
        MEDIUMSLATEBLUE
        LAWNGREEN 
        CHARTREUSE 
        AQUAMARINE
        MAROON
        PURPLE
        OLIVE  
        GRAY 
        GREY 
        SKYBLUE
        LIGHTSKYBLUE
        BLUEVIOLET
        DARKRED 
        DARKMAGENTA 
        SADDLEBROWN 
        DARKSEAGREEN 
        LIGHTGREEN
        MEDIUMPURPLE 
        DARKVIOLET 
        PALEGREEN 
        DARKORCHID 
        YELLOWGREEN
        LIGHT_GREY
        SIENNA 
        YELLOW_GREEN 
        BROWN 
        DARKGRAY
        DARKGREY
        LIGHTBLUE
        GREENYELLOW 
        PALETURQUOISE 
        LIGHTSTEELBLUE 
        POWDERBLUE 
        FIREBRICK 
        DARKGOLDENROD
        MEDIUMORCHID
        ROSYBROWN
        DARKKHAKI
        SILVER
        MEDIUMVIOLETRED
        INDIANRED 
        PERU 
        CHOCOLATE 
        TAN 
        LIGHTGRAY 
        LIGHTGREY 
        THISTLE 
        ORCHID 
        GOLDENROD 
        PALEVIOLETRED 
        CRIMSON 
        GAINSBORO 
        PLUM 
        BURLYWOOD 
        YELLOW 
        RED 
        LIGHTCYAN 
        LAVENDER 
        DARKSALMON
        VIOLET 
        PALEGOLDENROD 
        LIGHTCORAL 
        KHAKI 
        ALICEBLUE 
        HONEYDEW 
        AZURE 
        SANDYBROWN 
        WHEAT 
        BEIGE 
        WHITESMOKE 
        MINTCREAM 
        GHOSTWHITE 
        SALMON 
        ANTIQUEWHITE 
        LINEN 
        LIGHTGOLDENRODYELLOW
        OLDLACE 
        ORANGE 
        BRIGHT_RED 
        RED_2 
        FUCHSIA 
        MAGENTA 
        DEEPPINK 
        ORANGERED
        TOMATO 
        HOTPINK
        CORAL 
        DARKORANGE 
        LIGHTSALMON 
        ORANGE_2 
        LIGHTPINK 
        PINK 
        GOLD 
        PEACHPUFF 
        NAVAJOWHITE
        MOCCASIN 
        BISQUE 
        MISTYROSE 
        BLANCHEDALMOND
        PAPAYAWHIP 
        LAVENDERBLUSH 
        SEASHELL 
        CORNSILK 
        LEMONCHIFFON 
        FLORALWHITE 
        SNOW 
        BRIGHT_YELLOW 
        YELLOW_2 
        LIGHTYELLOW 
        IVORY 
        WHITE 
    ] 
    |> List.map (fun c ->
        Badge (
            label = "Color",
            value = (c.ToString()),
            defaultColor = c
        )
    )

color_badges
|> List.iter (fun b ->
    b.BadgeSvgText
    |> fun s ->
        File.WriteAllText(
            $"C:/Users/schne/Source/repos/kMutagene/AnyBadge.NET/sample_badges/{b.ValueText}.svg", s)
)