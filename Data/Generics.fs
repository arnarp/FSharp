module Generics

type NamedValue<'a> =
    {name: string; value: 'a}

let namedValue = {name = "Name"; value = 1}