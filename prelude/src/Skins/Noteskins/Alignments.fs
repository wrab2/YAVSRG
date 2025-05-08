namespace Prelude.Skins.Noteskins


type AlignmentStyle =
    | DDR = 0

type AlignmentParts =
    | Note = 0
    | Head = 1
    | Body_start = 2
    | Body_end = 3
    | Tail = 4
    | Receptor = 5

module NoteAlignments =
    let mutable style = AlignmentStyle.DDR
    let offset ( part:AlignmentParts ) ( height:float32 ) : float32 =

        match style with
        | AlignmentStyle.DDR -> 
            match part with
            | AlignmentParts.Note -> 0f
            | AlignmentParts.Head -> 0f
            | AlignmentParts.Body_start -> height * 0.5f - 1f
            | AlignmentParts.Body_end -> height * 0.5f + 1f
            | AlignmentParts.Tail -> 0f
            | AlignmentParts.Receptor -> height
            | _ -> 0f
        | _ -> 0f