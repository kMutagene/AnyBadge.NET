module Globals

open System.Reflection
open System.IO

let internal assembly = Assembly.GetExecutingAssembly()

let internal getEmbeddedResource file = 
    use str = assembly.GetManifestResourceStream($"AnyBadge.NET.{file}")
    use r = new StreamReader(str)
    r.ReadToEnd()

let DEFAULT_TEMPLATE = getEmbeddedResource "templates.default.svg"

let GITLAB_SCOPED_TEMPLATE = getEmbeddedResource "templates.gitlab_scoped.svg"

let [<Literal>] BADGE_WIDTH = "{{ badge width }}"

let [<Literal>] FONT_NAME = "{{ font name }}"

let [<Literal>] FONT_SIZE = "{{ font size }}"

let [<Literal>] LABEL = "{{ label }}"

let [<Literal>] VALUE = "{{ value }}"

let [<Literal>] LABEL_ANCHOR = "{{ label anchor }}"

let [<Literal>] LABEL_ANCHOR_SHADOW = "{{ label anchor shadow }}"

let [<Literal>] VALUE_ANCHOR = "{{ value anchor }}"

let [<Literal>] VALUE_ANCHOR_SHADOW = "{{ value anchor shadow }}"

let [<Literal>] COLOR = "{{ color }}"

let [<Literal>] LABEL_TEXT_COLOR = "{{ label text color }}"

let [<Literal>] VALUE_TEXT_COLOR = "{{ value text color }}"

let [<Literal>] COLOR_SPLIT_X = "{{ color split x }}"

let [<Literal>] VALUE_WIDTH = "{{ value width }}"

let [<Literal>] MASK_ID = "{{ mask id }}"

let [<Literal>] VALUE_BOX_WIDTH = "{{ value box width }}"

let [<Literal>] ARC_START = "{{ arc start }}"