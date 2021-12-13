module Main


open Elmish
open Lit
open Lit.Elmish


(*
         _______                        _______
        |       |                      |       |     
        | Model |--------render------->| View  |                 
        |_______|                      |_______|                         
            A                              |                             
            |                              |                     
            |                              |                     
            |                              |                     
            |                              |                     
            |                              |                     
            |                           ___V____
            |                          |        |                                
            ---------------------------| Update |                                
                                       |________|

 _______________________
|  our little Todo app  |
|                       |
|  * Todo 1  [Remove]   |
|  * Todo 2  [Remove]   |
|                       |
|  [_input_] [Add]      |
|_______________________|
*)
























Program.mkProgram init update view
|> Program.withLit "elmish-lit"
|> Program.run
