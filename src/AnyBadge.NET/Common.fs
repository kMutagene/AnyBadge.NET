module Common

// Based on the following SO answer: https://stackoverflow.com/a/16008023/6252525
//<summary>
//Get the approximate width of a string using a specific average font width.
//
//Args:
//    text(str): Text string to calculate width of.
//    font_width(int): Average width of font characters.
//    fixed_width(bool): Indicates that the font is fixed width.
//
//Returns:
//    int: Width of string in pixels.
//
//Examples:
//
//    Call the function with a string and the maximum character width of the font you are using:
//
//        >>> int(_get_approx_string_width('hello', 10))
//        29
//
//    This example shows the comparison of simplistic calculation based on a fixed width.
//    Given a test string and a fixed font width of 10, we can calculate the width
//    by multiplying the length and the font character with:
//
//        >>> test_string = 'GOOGLE|ijkl'
//        >>> _get_approx_string_width(test_string, 10, fixed_width=True)
//        110
//
//    Since some characters in the string are thinner than others we expect that the
//    apporximate text width will be narrower than the fixed width calculation:
//
//        >>> _get_approx_string_width(test_string, 10)
//        77
//
// </summary>
let getApproxStringWidth (text:string) (fontWidth:int) (fixedWidth:bool) =
    if fixedWidth then
        text.Length * fontWidth
    else

    let mutable size = 0.0

    // A dictionary containing percentages that relate to how wide
    // each character will be represented in a variable width font.
    // These percentages can be calculated using the ``_get_character_percentage_dict`` function.
    let char_width_percentages = 
        Map([
            "lij|' ", 40.0
            "![]fI.,:;/\\t", 50.0
            "`-(){}r\"", 60.0
            "*^zcsJkvxy", 70.0
            "aebdhnopqug#$L+<>=?_~FZT0123456789", 70.0
            "BSPEAKVXY&UwNRCHD", 70.0
            "QGOMm%W@", 100.0
        ])

    for c in text do
        let mutable percentage = 100.0
        for k in char_width_percentages.Keys do
            if k.Contains(c) then
                percentage <- char_width_percentages[k]
            size <- size + (percentage / 100.0) * float(fontWidth)

    int(size)