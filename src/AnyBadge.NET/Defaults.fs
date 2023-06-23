module Defaults

let DEFAULT_FONT = "DejaVu Sans,Verdana,Geneva,sans-serif"

let DEFAULT_FONT_SIZE= 11

let NUM_PADDING_CHARS = 0.5

let DEFAULT_COLOR= "#4c1"

let DEFAULT_TEXT_COLOR = "#fff"

let MASK_ID_PREFIX = "anybadge_"

// Dictionary for looking up approx pixel widths of
// supported fonts and font sizes.
let FONT_WIDTHS = Map([
    "DejaVu Sans,Verdana,Geneva,sans-serif", Map([
        10, 9
        11, 10
        12, 11
    ]);
    "Arial, Helvetica, sans-serif", Map([
        11, 8
    ])
])
