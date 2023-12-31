# AnyBadge.NET

[![Build and test](https://github.com/kMutagene/AnyBadge.NET/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/plotly/Plotly.NET/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/vpre/AnyBadge.NET)](https://www.nuget.org/packages/AnyBadge.NET/)

A .NET port of https://github.com/jongracecox/anybadge written in F#. It generates badges for your projects.

The port is aimed to be honest to the python source, even when the translation leads to non-idiomatic F#.
In the future, there might be dedicated F# and C# sub-packages, that add idiomatic API layers.

## Overview

`AnyBadge.NET` can be used to add badge generation to your .NET projects.
It will also provide a [command line interface soon](https://github.com/kMutagene/AnyBadge.NET/issues/2).

This utility can be used to generate .svg badge images, using configurable
thresholds for coloring the badges based on the badge value. Many badge
generation tools just provide the ability to specify the color of badge.
`AnyBadge.NET` allows you to specify the label, badge value, and color, but
it also allows you to specify a set of thresholds that can be used to
select a color based on the badge value.

`AnyBadge.NET` may be useful wherever a call to external badge services may be undesirable, or not customizable enough.

The package can referenced from nuget [![](https://img.shields.io/nuget/vpre/AnyBadge.NET)](https://www.nuget.org/packages/AnyBadge.NET/) , [or soon also run directly from the
command line](https://github.com/kMutagene/AnyBadge.NET/issues/2) as a .NET tool.

## Demo

Have a look at the [playground notebook](./src/AnyBadge.NET/playground.ipynb) which shows how to use the library.


Available named colors are:

| Color Name           | Hex     | Example |
| -------------------- | ------- | ------- |
| aliceblue            | #F0F8FF | ![](./sample_badges/ALICEBLUE.svg) |
| antiquewhite         | #FAEBD7 | ![](./sample_badges/ANTIQUEWHITE.svg) |
| aqua                 | #00FFFF | ![](./sample_badges/AQUA.svg) |
| aquamarine           | #7FFFD4 | ![](./sample_badges/AQUAMARINE.svg) |
| azure                | #F0FFFF | ![](./sample_badges/AZURE.svg) |
| beige                | #F5F5DC | ![](./sample_badges/BEIGE.svg) |
| bisque               | #FFE4C4 | ![](./sample_badges/BISQUE.svg) |
| black                | #000000 | ![](./sample_badges/BLACK.svg) |
| blanchedalmond       | #FFEBCD | ![](./sample_badges/BLANCHEDALMOND.svg) |
| blue                 | #0000FF | ![](./sample_badges/BLUE.svg) |
| blueviolet           | #8A2BE2 | ![](./sample_badges/BLUEVIOLET.svg) |
| bright_red           | #FF0000 | ![](./sample_badges/BRIGHT_RED.svg) |
| bright_yellow        | #FFFF00 | ![](./sample_badges/BRIGHT_YELLOW.svg) |
| brown                | #A52A2A | ![](./sample_badges/BROWN.svg) |
| burlywood            | #DEB887 | ![](./sample_badges/BURLYWOOD.svg) |
| cadetblue            | #5F9EA0 | ![](./sample_badges/CADETBLUE.svg) |
| chartreuse           | #7FFF00 | ![](./sample_badges/CHARTREUSE.svg) |
| chocolate            | #D2691E | ![](./sample_badges/CHOCOLATE.svg) |
| coral                | #FF7F50 | ![](./sample_badges/CORAL.svg) |
| cornflowerblue       | #6495ED | ![](./sample_badges/CORNFLOWERBLUE.svg) |
| cornsilk             | #FFF8DC | ![](./sample_badges/CORNSILK.svg) |
| crimson              | #DC143C | ![](./sample_badges/CRIMSON.svg) |
| darkblue             | #00008B | ![](./sample_badges/DARKBLUE.svg) |
| darkcyan             | #008B8B | ![](./sample_badges/DARKCYAN.svg) |
| darkgoldenrod        | #B8860B | ![](./sample_badges/DARKGOLDENROD.svg) |
| darkgray             | #A9A9A9 | ![](./sample_badges/DARKGRAY.svg) |
| darkgreen            | #006400 | ![](./sample_badges/DARKGREEN.svg) |
| darkkhaki            | #BDB76B | ![](./sample_badges/DARKKHAKI.svg) |
| darkmagenta          | #8B008B | ![](./sample_badges/DARKMAGENTA.svg) |
| darkolivegreen       | #556B2F | ![](./sample_badges/DARKOLIVEGREEN.svg) |
| darkorange           | #FF8C00 | ![](./sample_badges/DARKORANGE.svg) |
| darkorchid           | #9932CC | ![](./sample_badges/DARKORCHID.svg) |
| darkred              | #8B0000 | ![](./sample_badges/DARKRED.svg) |
| darksalmon           | #E9967A | ![](./sample_badges/DARKSALMON.svg) |
| darkseagreen         | #8FBC8F | ![](./sample_badges/DARKSEAGREEN.svg) |
| darkslateblue        | #483D8B | ![](./sample_badges/DARKSLATEBLUE.svg) |
| darkslategray        | #2F4F4F | ![](./sample_badges/DARKSLATEGRAY.svg) |
| darkturquoise        | #00CED1 | ![](./sample_badges/DARKTURQUOISE.svg) |
| darkviolet           | #9400D3 | ![](./sample_badges/DARKVIOLET.svg) |
| deeppink             | #FF1493 | ![](./sample_badges/DEEPPINK.svg) |
| deepskyblue          | #00BFFF | ![](./sample_badges/DEEPSKYBLUE.svg) |
| dimgray              | #696969 | ![](./sample_badges/DIMGRAY.svg) |
| dodgerblue           | #1E90FF | ![](./sample_badges/DODGERBLUE.svg) |
| firebrick            | #B22222 | ![](./sample_badges/FIREBRICK.svg) |
| floralwhite          | #FFFAF0 | ![](./sample_badges/FLORALWHITE.svg) |
| forestgreen          | #228B22 | ![](./sample_badges/FORESTGREEN.svg) |
| fuchsia              | #FF00FF | ![](./sample_badges/FUCHSIA.svg) |
| gainsboro            | #DCDCDC | ![](./sample_badges/GAINSBORO.svg) |
| ghostwhite           | #F8F8FF | ![](./sample_badges/GHOSTWHITE.svg) |
| gold                 | #FFD700 | ![](./sample_badges/GOLD.svg) |
| goldenrod            | #DAA520 | ![](./sample_badges/GOLDENROD.svg) |
| gray                 | #808080 | ![](./sample_badges/GRAY.svg) |
| green                | #4C1    | ![](./sample_badges/GREEN.svg) |
| greenyellow          | #ADFF2F | ![](./sample_badges/GREENYELLOW.svg) |
| green_2              | #008000 | ![](./sample_badges/GREEN_2.svg) |
| honeydew             | #F0FFF0 | ![](./sample_badges/HONEYDEW.svg) |
| hotpink              | #FF69B4 | ![](./sample_badges/HOTPINK.svg) |
| indianred            | #CD5C5C | ![](./sample_badges/INDIANRED.svg) |
| indigo               | #4B0082 | ![](./sample_badges/INDIGO.svg) |
| ivory                | #FFFFF0 | ![](./sample_badges/IVORY.svg) |
| khaki                | #F0E68C | ![](./sample_badges/KHAKI.svg) |
| lavender             | #E6E6FA | ![](./sample_badges/LAVENDER.svg) |
| lavenderblush        | #FFF0F5 | ![](./sample_badges/LAVENDERBLUSH.svg) |
| lawngreen            | #7CFC00 | ![](./sample_badges/LAWNGREEN.svg) |
| lemonchiffon         | #FFFACD | ![](./sample_badges/LEMONCHIFFON.svg) |
| lightblue            | #ADD8E6 | ![](./sample_badges/LIGHTBLUE.svg) |
| lightcoral           | #F08080 | ![](./sample_badges/LIGHTCORAL.svg) |
| lightcyan            | #E0FFFF | ![](./sample_badges/LIGHTCYAN.svg) |
| lightgoldenrodyellow | #FAFAD2 | ![](./sample_badges/LIGHTGOLDENRODYELLOW.svg) |
| lightgray            | #D3D3D3 | ![](./sample_badges/LIGHTGRAY.svg) |
| lightgreen           | #90EE90 | ![](./sample_badges/LIGHTGREEN.svg) |
| lightpink            | #FFB6C1 | ![](./sample_badges/LIGHTPINK.svg) |
| lightsalmon          | #FFA07A | ![](./sample_badges/LIGHTSALMON.svg) |
| lightseagreen        | #20B2AA | ![](./sample_badges/LIGHTSEAGREEN.svg) |
| lightskyblue         | #87CEFA | ![](./sample_badges/LIGHTSKYBLUE.svg) |
| lightslategray       | #778899 | ![](./sample_badges/LIGHTSLATEGRAY.svg) |
| lightsteelblue       | #B0C4DE | ![](./sample_badges/LIGHTSTEELBLUE.svg) |
| lightyellow          | #FFFFE0 | ![](./sample_badges/LIGHTYELLOW.svg) |
| light_grey           | #9F9F9F | ![](./sample_badges/LIGHT_GREY.svg) |
| lime                 | #00FF00 | ![](./sample_badges/LIME.svg) |
| limegreen            | #32CD32 | ![](./sample_badges/LIMEGREEN.svg) |
| linen                | #FAF0E6 | ![](./sample_badges/LINEN.svg) |
| maroon               | #800000 | ![](./sample_badges/MAROON.svg) |
| mediumaquamarine     | #66CDAA | ![](./sample_badges/MEDIUMAQUAMARINE.svg) |
| mediumblue           | #0000CD | ![](./sample_badges/MEDIUMBLUE.svg) |
| mediumorchid         | #BA55D3 | ![](./sample_badges/MEDIUMORCHID.svg) |
| mediumpurple         | #9370DB | ![](./sample_badges/MEDIUMPURPLE.svg) |
| mediumseagreen       | #3CB371 | ![](./sample_badges/MEDIUMSEAGREEN.svg) |
| mediumslateblue      | #7B68EE | ![](./sample_badges/MEDIUMSLATEBLUE.svg) |
| mediumspringgreen    | #00FA9A | ![](./sample_badges/MEDIUMSPRINGGREEN.svg) |
| mediumturquoise      | #48D1CC | ![](./sample_badges/MEDIUMTURQUOISE.svg) |
| mediumvioletred      | #C71585 | ![](./sample_badges/MEDIUMVIOLETRED.svg) |
| midnightblue         | #191970 | ![](./sample_badges/MIDNIGHTBLUE.svg) |
| mintcream            | #F5FFFA | ![](./sample_badges/MINTCREAM.svg) |
| mistyrose            | #FFE4E1 | ![](./sample_badges/MISTYROSE.svg) |
| moccasin             | #FFE4B5 | ![](./sample_badges/MOCCASIN.svg) |
| navajowhite          | #FFDEAD | ![](./sample_badges/NAVAJOWHITE.svg) |
| navy                 | #000080 | ![](./sample_badges/NAVY.svg) |
| oldlace              | #FDF5E6 | ![](./sample_badges/OLDLACE.svg) |
| olive                | #808000 | ![](./sample_badges/OLIVE.svg) |
| olivedrab            | #6B8E23 | ![](./sample_badges/OLIVEDRAB.svg) |
| orange               | #FE7D37 | ![](./sample_badges/ORANGE.svg) |
| orangered            | #FF4500 | ![](./sample_badges/ORANGERED.svg) |
| orange_2             | #FFA500 | ![](./sample_badges/ORANGE_2.svg) |
| orchid               | #DA70D6 | ![](./sample_badges/ORCHID.svg) |
| palegoldenrod        | #EEE8AA | ![](./sample_badges/PALEGOLDENROD.svg) |
| palegreen            | #98FB98 | ![](./sample_badges/PALEGREEN.svg) |
| paleturquoise        | #AFEEEE | ![](./sample_badges/PALETURQUOISE.svg) |
| palevioletred        | #DB7093 | ![](./sample_badges/PALEVIOLETRED.svg) |
| papayawhip           | #FFEFD5 | ![](./sample_badges/PAPAYAWHIP.svg) |
| peachpuff            | #FFDAB9 | ![](./sample_badges/PEACHPUFF.svg) |
| peru                 | #CD853F | ![](./sample_badges/PERU.svg) |
| pink                 | #FFC0CB | ![](./sample_badges/PINK.svg) |
| plum                 | #DDA0DD | ![](./sample_badges/PLUM.svg) |
| powderblue           | #B0E0E6 | ![](./sample_badges/POWDERBLUE.svg) |
| purple               | #800080 | ![](./sample_badges/PURPLE.svg) |
| rebeccapurple        | #663399 | ![](./sample_badges/REBECCAPURPLE.svg) |
| red                  | #E05D44 | ![](./sample_badges/RED.svg) |
| rosybrown            | #BC8F8F | ![](./sample_badges/ROSYBROWN.svg) |
| royalblue            | #4169E1 | ![](./sample_badges/ROYALBLUE.svg) |
| saddlebrown          | #8B4513 | ![](./sample_badges/SADDLEBROWN.svg) |
| salmon               | #FA8072 | ![](./sample_badges/SALMON.svg) |
| sandybrown           | #F4A460 | ![](./sample_badges/SANDYBROWN.svg) |
| seagreen             | #2E8B57 | ![](./sample_badges/SEAGREEN.svg) |
| seashell             | #FFF5EE | ![](./sample_badges/SEASHELL.svg) |
| sienna               | #A0522D | ![](./sample_badges/SIENNA.svg) |
| silver               | #C0C0C0 | ![](./sample_badges/SILVER.svg) |
| skyblue              | #87CEEB | ![](./sample_badges/SKYBLUE.svg) |
| slateblue            | #6A5ACD | ![](./sample_badges/SLATEBLUE.svg) |
| slategray            | #708090 | ![](./sample_badges/SLATEGRAY.svg) |
| snow                 | #FFFAFA | ![](./sample_badges/SNOW.svg) |
| springgreen          | #00FF7F | ![](./sample_badges/SPRINGGREEN.svg) |
| steelblue            | #4682B4 | ![](./sample_badges/STEELBLUE.svg) |
| tan                  | #D2B48C | ![](./sample_badges/TAN.svg) |
| teal                 | #008080 | ![](./sample_badges/TEAL.svg) |
| thistle              | #D8BFD8 | ![](./sample_badges/THISTLE.svg) |
| tomato               | #FF6347 | ![](./sample_badges/TOMATO.svg) |
| turquoise            | #40E0D0 | ![](./sample_badges/TURQUOISE.svg) |
| violet               | #EE82EE | ![](./sample_badges/VIOLET.svg) |
| wheat                | #F5DEB3 | ![](./sample_badges/WHEAT.svg) |
| white                | #FFFFFF | ![](./sample_badges/WHITE.svg) |
| whitesmoke           | #F5F5F5 | ![](./sample_badges/WHITESMOKE.svg) |
| yellow               | #DFB317 | ![](./sample_badges/YELLOW.svg) |
| yellowgreen          | #9ACD32 | ![](./sample_badges/YELLOWGREEN.svg) |
| yellow_green         | #A4A61D | ![](./sample_badges/YELLOW_GREEN.svg) |
