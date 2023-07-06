namespace AnyBadge.NET

type Color =
    | BLACK
    | NAVY 
    | DARKBLUE
    | MEDIUMBLUE
    | BLUE 
    | DARKGREEN 
    | GREEN_2 
    | TEAL 
    | DARKCYAN
    | DEEPSKYBLUE
    | DARKTURQUOISE 
    | MEDIUMSPRINGGREEN 
    | LIME 
    | SPRINGGREEN 
    | AQUA 
    | CYAN 
    | MIDNIGHTBLUE
    | DODGERBLUE
    | LIGHTSEAGREEN
    | FORESTGREEN
    | SEAGREEN
    | DARKSLATEGRAY
    | DARKSLATEGREY
    | LIMEGREEN 
    | MEDIUMSEAGREEN 
    | TURQUOISE 
    | ROYALBLUE 
    | STEELBLUE 
    | DARKSLATEBLUE 
    | MEDIUMTURQUOISE 
    | INDIGO 
    | GREEN 
    | DARKOLIVEGREEN 
    | CADETBLUE 
    | CORNFLOWERBLUE 
    | REBECCAPURPLE 
    | MEDIUMAQUAMARINE 
    | DIMGRAY
    | DIMGREY
    | SLATEBLUE
    | OLIVEDRAB
    | SLATEGRAY
    | SLATEGREY
    | LIGHTSLATEGRAY 
    | LIGHTSLATEGREY 
    | MEDIUMSLATEBLUE
    | LAWNGREEN 
    | CHARTREUSE 
    | AQUAMARINE
    | MAROON
    | PURPLE
    | OLIVE  
    | GRAY 
    | GREY 
    | SKYBLUE
    | LIGHTSKYBLUE
    | BLUEVIOLET
    | DARKRED 
    | DARKMAGENTA 
    | SADDLEBROWN 
    | DARKSEAGREEN 
    | LIGHTGREEN
    | MEDIUMPURPLE 
    | DARKVIOLET 
    | PALEGREEN 
    | DARKORCHID 
    | YELLOWGREEN
    | LIGHT_GREY
    | SIENNA 
    | YELLOW_GREEN 
    | BROWN 
    | DARKGRAY
    | DARKGREY
    | LIGHTBLUE
    | GREENYELLOW 
    | PALETURQUOISE 
    | LIGHTSTEELBLUE 
    | POWDERBLUE 
    | FIREBRICK 
    | DARKGOLDENROD
    | MEDIUMORCHID
    | ROSYBROWN
    | DARKKHAKI
    | SILVER
    | MEDIUMVIOLETRED
    | INDIANRED 
    | PERU 
    | CHOCOLATE 
    | TAN 
    | LIGHTGRAY 
    | LIGHTGREY 
    | THISTLE 
    | ORCHID 
    | GOLDENROD 
    | PALEVIOLETRED 
    | CRIMSON 
    | GAINSBORO 
    | PLUM 
    | BURLYWOOD 
    | YELLOW 
    | RED 
    | LIGHTCYAN 
    | LAVENDER 
    | DARKSALMON
    | VIOLET 
    | PALEGOLDENROD 
    | LIGHTCORAL 
    | KHAKI 
    | ALICEBLUE 
    | HONEYDEW 
    | AZURE 
    | SANDYBROWN 
    | WHEAT 
    | BEIGE 
    | WHITESMOKE 
    | MINTCREAM 
    | GHOSTWHITE 
    | SALMON 
    | ANTIQUEWHITE 
    | LINEN 
    | LIGHTGOLDENRODYELLOW
    | OLDLACE 
    | ORANGE 
    | BRIGHT_RED 
    | RED_2 
    | FUCHSIA 
    | MAGENTA 
    | DEEPPINK 
    | ORANGERED
    | TOMATO 
    | HOTPINK
    | CORAL 
    | DARKORANGE 
    | LIGHTSALMON 
    | ORANGE_2 
    | LIGHTPINK 
    | PINK 
    | GOLD 
    | PEACHPUFF 
    | NAVAJOWHITE
    | MOCCASIN 
    | BISQUE 
    | MISTYROSE 
    | BLANCHEDALMOND
    | PAPAYAWHIP 
    | LAVENDERBLUSH 
    | SEASHELL 
    | CORNSILK 
    | LEMONCHIFFON 
    | FLORALWHITE 
    | SNOW 
    | BRIGHT_YELLOW 
    | YELLOW_2 
    | LIGHTYELLOW 
    | IVORY 
    | WHITE 
    | Custom of string

    static member toHexCode (c:Color) =
        match c with
        | BLACK -> "#000000"
        | NAVY -> "#000080"
        | DARKBLUE -> "#00008B"
        | MEDIUMBLUE -> "#0000CD"
        | BLUE -> "#0000FF"
        | DARKGREEN -> "#006400"
        | GREEN_2 -> "#008000"
        | TEAL -> "#008080"
        | DARKCYAN -> "#008B8B"
        | DEEPSKYBLUE -> "#00BFFF"
        | DARKTURQUOISE -> "#00CED1"
        | MEDIUMSPRINGGREEN -> "#00FA9A"
        | LIME -> "#00FF00"
        | SPRINGGREEN -> "#00FF7F"
        | AQUA -> "#00FFFF"
        | CYAN -> "#00FFFF"
        | MIDNIGHTBLUE -> "#191970"
        | DODGERBLUE -> "#1E90FF"
        | LIGHTSEAGREEN -> "#20B2AA"
        | FORESTGREEN -> "#228B22"
        | SEAGREEN -> "#2E8B57"
        | DARKSLATEGRAY -> "#2F4F4F"
        | DARKSLATEGREY -> "#2F4F4F"
        | LIMEGREEN -> "#32CD32"
        | MEDIUMSEAGREEN -> "#3CB371"
        | TURQUOISE -> "#40E0D0"
        | ROYALBLUE -> "#4169E1"
        | STEELBLUE -> "#4682B4"
        | DARKSLATEBLUE -> "#483D8B"
        | MEDIUMTURQUOISE -> "#48D1CC"
        | INDIGO -> "#4B0082"
        | GREEN -> "#4C1"
        | DARKOLIVEGREEN -> "#556B2F"
        | CADETBLUE -> "#5F9EA0"
        | CORNFLOWERBLUE -> "#6495ED"
        | REBECCAPURPLE -> "#663399"
        | MEDIUMAQUAMARINE -> "#66CDAA"
        | DIMGRAY -> "#696969"
        | DIMGREY -> "#696969"
        | SLATEBLUE -> "#6A5ACD"
        | OLIVEDRAB -> "#6B8E23"
        | SLATEGRAY -> "#708090"
        | SLATEGREY -> "#708090"
        | LIGHTSLATEGRAY -> "#778899"
        | LIGHTSLATEGREY -> "#778899"
        | MEDIUMSLATEBLUE -> "#7B68EE"
        | LAWNGREEN -> "#7CFC00"
        | CHARTREUSE -> "#7FFF00"
        | AQUAMARINE -> "#7FFFD4"
        | MAROON -> "#800000"
        | PURPLE -> "#800080"
        | OLIVE -> "#808000"
        | GRAY -> "#808080"
        | GREY -> "#808080"
        | SKYBLUE -> "#87CEEB"
        | LIGHTSKYBLUE -> "#87CEFA"
        | BLUEVIOLET -> "#8A2BE2"
        | DARKRED -> "#8B0000"
        | DARKMAGENTA -> "#8B008B"
        | SADDLEBROWN -> "#8B4513"
        | DARKSEAGREEN -> "#8FBC8F"
        | LIGHTGREEN -> "#90EE90"
        | MEDIUMPURPLE -> "#9370DB"
        | DARKVIOLET -> "#9400D3"
        | PALEGREEN -> "#98FB98"
        | DARKORCHID -> "#9932CC"
        | YELLOWGREEN -> "#9ACD32"
        | LIGHT_GREY -> "#9F9F9F"
        | SIENNA -> "#A0522D"
        | YELLOW_GREEN -> "#A4A61D"
        | BROWN -> "#A52A2A"
        | DARKGRAY -> "#A9A9A9"
        | DARKGREY -> "#A9A9A9"
        | LIGHTBLUE -> "#ADD8E6"
        | GREENYELLOW -> "#ADFF2F"
        | PALETURQUOISE -> "#AFEEEE"
        | LIGHTSTEELBLUE -> "#B0C4DE"
        | POWDERBLUE -> "#B0E0E6"
        | FIREBRICK -> "#B22222"
        | DARKGOLDENROD -> "#B8860B"
        | MEDIUMORCHID -> "#BA55D3"
        | ROSYBROWN -> "#BC8F8F"
        | DARKKHAKI -> "#BDB76B"
        | SILVER -> "#C0C0C0"
        | MEDIUMVIOLETRED -> "#C71585"
        | INDIANRED -> "#CD5C5C"
        | PERU -> "#CD853F"
        | CHOCOLATE -> "#D2691E"
        | TAN -> "#D2B48C"
        | LIGHTGRAY -> "#D3D3D3"
        | LIGHTGREY -> "#D3D3D3"
        | THISTLE -> "#D8BFD8"
        | ORCHID -> "#DA70D6"
        | GOLDENROD -> "#DAA520"
        | PALEVIOLETRED -> "#DB7093"
        | CRIMSON -> "#DC143C"
        | GAINSBORO -> "#DCDCDC"
        | PLUM -> "#DDA0DD"
        | BURLYWOOD -> "#DEB887"
        | YELLOW -> "#DFB317"
        | RED -> "#E05D44"
        | LIGHTCYAN -> "#E0FFFF"
        | LAVENDER -> "#E6E6FA"
        | DARKSALMON -> "#E9967A"
        | VIOLET -> "#EE82EE"
        | PALEGOLDENROD -> "#EEE8AA"
        | LIGHTCORAL -> "#F08080"
        | KHAKI -> "#F0E68C"
        | ALICEBLUE -> "#F0F8FF"
        | HONEYDEW -> "#F0FFF0"
        | AZURE -> "#F0FFFF"
        | SANDYBROWN -> "#F4A460"
        | WHEAT -> "#F5DEB3"
        | BEIGE -> "#F5F5DC"
        | WHITESMOKE -> "#F5F5F5"
        | MINTCREAM -> "#F5FFFA"
        | GHOSTWHITE -> "#F8F8FF"
        | SALMON -> "#FA8072"
        | ANTIQUEWHITE -> "#FAEBD7"
        | LINEN -> "#FAF0E6"
        | LIGHTGOLDENRODYELLOW -> "#FAFAD2"
        | OLDLACE -> "#FDF5E6"
        | ORANGE -> "#FE7D37"
        | BRIGHT_RED -> "#FF0000"
        | RED_2 -> "#FF0000"
        | FUCHSIA -> "#FF00FF"
        | MAGENTA -> "#FF00FF"
        | DEEPPINK -> "#FF1493"
        | ORANGERED -> "#FF4500"
        | TOMATO -> "#FF6347"
        | HOTPINK -> "#FF69B4"
        | CORAL -> "#FF7F50"
        | DARKORANGE -> "#FF8C00"
        | LIGHTSALMON -> "#FFA07A"
        | ORANGE_2 -> "#FFA500"
        | LIGHTPINK -> "#FFB6C1"
        | PINK -> "#FFC0CB"
        | GOLD -> "#FFD700"
        | PEACHPUFF -> "#FFDAB9"
        | NAVAJOWHITE -> "#FFDEAD"
        | MOCCASIN -> "#FFE4B5"
        | BISQUE -> "#FFE4C4"
        | MISTYROSE -> "#FFE4E1"
        | BLANCHEDALMOND -> "#FFEBCD"
        | PAPAYAWHIP -> "#FFEFD5"
        | LAVENDERBLUSH -> "#FFF0F5"
        | SEASHELL -> "#FFF5EE"
        | CORNSILK -> "#FFF8DC"
        | LEMONCHIFFON -> "#FFFACD"
        | FLORALWHITE -> "#FFFAF0"
        | SNOW -> "#FFFAFA"
        | BRIGHT_YELLOW -> "#FFFF00"
        | YELLOW_2 -> "#FFFF00"
        | LIGHTYELLOW -> "#FFFFE0"
        | IVORY -> "#FFFFF0"
        | WHITE -> "#FFFFFF"
        | Custom s -> s

    static member fromString (s:string) =
        match s.ToUpper() with
        | "#000000" | "BLACK" -> BLACK
        | "#000080" | "NAVY" -> NAVY 
        | "#00008B" | "DARKBLUE" -> DARKBLUE
        | "#0000CD" | "MEDIUMBLUE" -> MEDIUMBLUE
        | "#0000FF" | "BLUE" -> BLUE 
        | "#006400" | "DARKGREEN" -> DARKGREEN 
        | "#008000" | "GREEN_2" -> GREEN_2 
        | "#008080" | "TEAL" -> TEAL 
        | "#008B8B" | "DARKCYAN" -> DARKCYAN
        | "#00BFFF" | "DEEPSKYBLUE" -> DEEPSKYBLUE
        | "#00CED1" | "DARKTURQUOISE" -> DARKTURQUOISE 
        | "#00FA9A" | "MEDIUMSPRINGGREEN" -> MEDIUMSPRINGGREEN 
        | "#00FF00" | "LIME" -> LIME 
        | "#00FF7F" | "SPRINGGREEN" -> SPRINGGREEN 
        | "#00FFFF" | "AQUA" -> AQUA 
        | "#191970" | "MIDNIGHTBLUE" -> MIDNIGHTBLUE
        | "#1E90FF" | "DODGERBLUE" -> DODGERBLUE
        | "#20B2AA" | "LIGHTSEAGREEN" -> LIGHTSEAGREEN
        | "#228B22" | "FORESTGREEN" -> FORESTGREEN
        | "#2E8B57" | "SEAGREEN" -> SEAGREEN
        | "#2F4F4F" | "DARKSLATEGRAY" -> DARKSLATEGRAY
        | "#32CD32" | "LIMEGREEN" -> LIMEGREEN 
        | "#3CB371" | "MEDIUMSEAGREEN" -> MEDIUMSEAGREEN 
        | "#40E0D0" | "TURQUOISE" -> TURQUOISE 
        | "#4169E1" | "ROYALBLUE" -> ROYALBLUE 
        | "#4682B4" | "STEELBLUE" -> STEELBLUE 
        | "#483D8B" | "DARKSLATEBLUE" -> DARKSLATEBLUE 
        | "#48D1CC" | "MEDIUMTURQUOISE" -> MEDIUMTURQUOISE 
        | "#4B0082" | "INDIGO" -> INDIGO 
        | "#4C1"    | "GREEN" -> GREEN 
        | "#556B2F" | "DARKOLIVEGREEN" -> DARKOLIVEGREEN 
        | "#5F9EA0" | "CADETBLUE" -> CADETBLUE 
        | "#6495ED" | "CORNFLOWERBLUE" -> CORNFLOWERBLUE 
        | "#663399" | "REBECCAPURPLE" -> REBECCAPURPLE 
        | "#66CDAA" | "MEDIUMAQUAMARINE" -> MEDIUMAQUAMARINE 
        | "#696969" | "DIMGRAY" -> DIMGRAY
        | "#6A5ACD" | "SLATEBLUE" -> SLATEBLUE
        | "#6B8E23" | "OLIVEDRAB" -> OLIVEDRAB
        | "#708090" | "SLATEGRAY" -> SLATEGRAY
        | "#778899" | "LIGHTSLATEGRAY" -> LIGHTSLATEGRAY 
        | "#7B68EE" | "MEDIUMSLATEBLUE" -> MEDIUMSLATEBLUE
        | "#7CFC00" | "LAWNGREEN" -> LAWNGREEN 
        | "#7FFF00" | "CHARTREUSE" -> CHARTREUSE 
        | "#7FFFD4" | "AQUAMARINE" -> AQUAMARINE
        | "#800000" | "MAROON" -> MAROON
        | "#800080" | "PURPLE" -> PURPLE
        | "#808000" | "OLIVE" -> OLIVE  
        | "#808080" | "GRAY" -> GRAY 
        | "#87CEEB" | "SKYBLUE" -> SKYBLUE
        | "#87CEFA" | "LIGHTSKYBLUE" -> LIGHTSKYBLUE
        | "#8A2BE2" | "BLUEVIOLET" -> BLUEVIOLET
        | "#8B0000" | "DARKRED" -> DARKRED 
        | "#8B008B" | "DARKMAGENTA" -> DARKMAGENTA 
        | "#8B4513" | "SADDLEBROWN" -> SADDLEBROWN 
        | "#8FBC8F" | "DARKSEAGREEN" -> DARKSEAGREEN 
        | "#90EE90" | "LIGHTGREEN" -> LIGHTGREEN
        | "#9370DB" | "MEDIUMPURPLE" -> MEDIUMPURPLE 
        | "#9400D3" | "DARKVIOLET" -> DARKVIOLET 
        | "#98FB98" | "PALEGREEN" -> PALEGREEN 
        | "#9932CC" | "DARKORCHID" -> DARKORCHID 
        | "#9ACD32" | "YELLOWGREEN" -> YELLOWGREEN
        | "#9F9F9F" | "LIGHT_GREY" -> LIGHT_GREY
        | "#A0522D" | "SIENNA" -> SIENNA 
        | "#A4A61D" | "YELLOW_GREEN" -> YELLOW_GREEN 
        | "#A52A2A" | "BROWN" -> BROWN 
        | "#A9A9A9" | "DARKGRAY" -> DARKGRAY
        | "#ADD8E6" | "LIGHTBLUE" -> LIGHTBLUE
        | "#ADFF2F" | "GREENYELLOW" -> GREENYELLOW 
        | "#AFEEEE" | "PALETURQUOISE" -> PALETURQUOISE 
        | "#B0C4DE" | "LIGHTSTEELBLUE" -> LIGHTSTEELBLUE 
        | "#B0E0E6" | "POWDERBLUE" -> POWDERBLUE 
        | "#B22222" | "FIREBRICK" -> FIREBRICK 
        | "#B8860B" | "DARKGOLDENROD" -> DARKGOLDENROD
        | "#BA55D3" | "MEDIUMORCHID" -> MEDIUMORCHID
        | "#BC8F8F" | "ROSYBROWN" -> ROSYBROWN
        | "#BDB76B" | "DARKKHAKI" -> DARKKHAKI
        | "#C0C0C0" | "SILVER" -> SILVER
        | "#C71585" | "MEDIUMVIOLETRED" -> MEDIUMVIOLETRED
        | "#CD5C5C" | "INDIANRED" -> INDIANRED 
        | "#CD853F" | "PERU" -> PERU 
        | "#D2691E" | "CHOCOLATE" -> CHOCOLATE 
        | "#D2B48C" | "TAN" -> TAN 
        | "#D3D3D3" | "LIGHTGRAY" -> LIGHTGRAY 
        | "#D8BFD8" | "THISTLE" -> THISTLE 
        | "#DA70D6" | "ORCHID" -> ORCHID 
        | "#DAA520" | "GOLDENROD" -> GOLDENROD 
        | "#DB7093" | "PALEVIOLETRED" -> PALEVIOLETRED 
        | "#DC143C" | "CRIMSON" -> CRIMSON 
        | "#DCDCDC" | "GAINSBORO" -> GAINSBORO 
        | "#DDA0DD" | "PLUM" -> PLUM 
        | "#DEB887" | "BURLYWOOD" -> BURLYWOOD 
        | "#DFB317" | "YELLOW" -> YELLOW 
        | "#E05D44" | "RED" -> RED 
        | "#E0FFFF" | "LIGHTCYAN" -> LIGHTCYAN 
        | "#E6E6FA" | "LAVENDER" -> LAVENDER 
        | "#E9967A" | "DARKSALMON" -> DARKSALMON
        | "#EE82EE" | "VIOLET" -> VIOLET 
        | "#EEE8AA" | "PALEGOLDENROD" -> PALEGOLDENROD 
        | "#F08080" | "LIGHTCORAL" -> LIGHTCORAL 
        | "#F0E68C" | "KHAKI" -> KHAKI 
        | "#F0F8FF" | "ALICEBLUE" -> ALICEBLUE 
        | "#F0FFF0" | "HONEYDEW" -> HONEYDEW 
        | "#F0FFFF" | "AZURE" -> AZURE 
        | "#F4A460" | "SANDYBROWN" -> SANDYBROWN 
        | "#F5DEB3" | "WHEAT" -> WHEAT 
        | "#F5F5DC" | "BEIGE" -> BEIGE 
        | "#F5F5F5" | "WHITESMOKE" -> WHITESMOKE 
        | "#F5FFFA" | "MINTCREAM" -> MINTCREAM 
        | "#F8F8FF" | "GHOSTWHITE" -> GHOSTWHITE 
        | "#FA8072" | "SALMON" -> SALMON 
        | "#FAEBD7" | "ANTIQUEWHITE" -> ANTIQUEWHITE 
        | "#FAF0E6" | "LINEN" -> LINEN 
        | "#FAFAD2" | "LIGHTGOLDENRODYELLOW" -> LIGHTGOLDENRODYELLOW
        | "#FDF5E6" | "OLDLACE" -> OLDLACE 
        | "#FE7D37" | "ORANGE" -> ORANGE 
        | "#FF0000" | "BRIGHT_RED" -> BRIGHT_RED 
        | "#FF00FF" | "FUCHSIA" -> FUCHSIA 
        | "#FF1493" | "DEEPPINK" -> DEEPPINK 
        | "#FF4500" | "ORANGERED" -> ORANGERED
        | "#FF6347" | "TOMATO" -> TOMATO 
        | "#FF69B4" | "HOTPINK" -> HOTPINK
        | "#FF7F50" | "CORAL" -> CORAL 
        | "#FF8C00" | "DARKORANGE" -> DARKORANGE 
        | "#FFA07A" | "LIGHTSALMON" -> LIGHTSALMON 
        | "#FFA500" | "ORANGE_2" -> ORANGE_2 
        | "#FFB6C1" | "LIGHTPINK" -> LIGHTPINK 
        | "#FFC0CB" | "PINK" -> PINK 
        | "#FFD700" | "GOLD" -> GOLD 
        | "#FFDAB9" | "PEACHPUFF" -> PEACHPUFF 
        | "#FFDEAD" | "NAVAJOWHITE" -> NAVAJOWHITE
        | "#FFE4B5" | "MOCCASIN" -> MOCCASIN 
        | "#FFE4C4" | "BISQUE" -> BISQUE 
        | "#FFE4E1" | "MISTYROSE" -> MISTYROSE 
        | "#FFEBCD" | "BLANCHEDALMOND" -> BLANCHEDALMOND
        | "#FFEFD5" | "PAPAYAWHIP" -> PAPAYAWHIP 
        | "#FFF0F5" | "LAVENDERBLUSH" -> LAVENDERBLUSH 
        | "#FFF5EE" | "SEASHELL" -> SEASHELL 
        | "#FFF8DC" | "CORNSILK" -> CORNSILK 
        | "#FFFACD" | "LEMONCHIFFON" -> LEMONCHIFFON 
        | "#FFFAF0" | "FLORALWHITE" -> FLORALWHITE 
        | "#FFFAFA" | "SNOW" -> SNOW 
        | "#FFFF00" | "BRIGHT_YELLOW" -> BRIGHT_YELLOW 
        | "#FFFFE0" | "LIGHTYELLOW" -> LIGHTYELLOW 
        | "#FFFFF0" | "IVORY" -> IVORY 
        | "#FFFFFF" | "WHITE" -> WHITE 
        | s -> if s.StartsWith("#") then Custom s else failwithf "%s is not a hex color code" s