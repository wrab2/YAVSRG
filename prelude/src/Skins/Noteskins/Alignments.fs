namespace Prelude.Skins.Noteskins


type AlignmentStyle =
    | DDR = 0
    | osu = 1

type AlignmentOffsets(style:AlignmentStyle, note_height:float32, tail_height:float32) =
    member this.note : float32 =
        match style with
        | AlignmentStyle.DDR -> 0f
        | AlignmentStyle.osu -> note_height * 0.5f
        | _ -> 0f

    member this.receptor : float32 =
        match style with
        | AlignmentStyle.DDR -> 0f
        | AlignmentStyle.osu -> note_height * 0.5f
        | _ -> 0f
    member this.tailClip : float32 =
        match style with
        | AlignmentStyle.DDR -> 0f
        | AlignmentStyle.osu -> note_height * 0.5f
        | _ -> 0f

    member this.tail : float32 =
        match style with
        | AlignmentStyle.DDR -> 0f
        | AlignmentStyle.osu -> tail_height - note_height * 0.5f
        | _ -> 0f