namespace Prelude.Skins.Noteskins


type AlignmentStyle =
    | DDR = 0
    | osu = 1

type AlignmentOffsets =    
    val note : float32
    val tail : float32
    val bodyStart : float32
    new(style:AlignmentStyle, note_height:float32, tail_height:float32) = {
        note =
            match style with
                | AlignmentStyle.DDR -> 0f
                | AlignmentStyle.osu -> note_height * 0.5f
                | _ -> 0f
        tail = 
            match style with
                | AlignmentStyle.DDR -> 0f
                | AlignmentStyle.osu -> tail_height - note_height * 0.5f
                | _ -> 0f
        bodyStart =
            match style with
                | AlignmentStyle.DDR -> 1f
                | AlignmentStyle.osu -> 0f
                | _ -> 0f 
    }
