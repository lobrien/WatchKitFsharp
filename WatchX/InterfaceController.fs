namespace WatchX

open System
open UIKit
open Foundation
open WatchKit

[<Register("InterfaceController")>]
type InterfaceController(ip : IntPtr) = 
    inherit WKInterfaceController(ip)

    let mutable label : WKInterfaceLabel = null
    let mutable button : WKInterfaceButton = null

    let mutable clickCount = 0
   
    [<Outlet>]
    member this.myLabel with get() = label
    member this.myLabel with set(v) = label <- v

    [<Outlet>]
    member this.myButton with get() = button
    member this.myButton with set(v) = button <- v

    [<Action("OnButtonPress")>]
    member this.OnButtonPush () =
        clickCount <- clickCount + 1
        sprintf "Pressed %d times" clickCount 
        |> this.myLabel.SetText 


    override this.Awake (context) = 
        System.Console.WriteLine("Hello F#")
        this.myLabel.SetText("F# |> I ♡")

