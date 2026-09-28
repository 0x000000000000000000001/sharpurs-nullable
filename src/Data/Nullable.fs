let ``null`` = (Unchecked.defaultof<obj>)

let notNull = box (fun (x: obj) -> x)

let nullable = box (fun (a: obj) -> box (fun (r: obj) -> box (fun (f: obj) ->
    if isNull a then r else sharpurs_apply f a)))
