open System
open ShootingGallery

[<EntryPoint; STAThread>]
let main argv =
    use game = new Game1 ()
    game.Run ()
    0