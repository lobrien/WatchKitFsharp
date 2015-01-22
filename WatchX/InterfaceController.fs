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

    [<Outlet>]
    member this.myLabel with get() = label
    member this.myLabel with set(v) = label <- v

    [<Outlet>]
    member this.myButton with get() = button
    member this.myButton with set(v) = button <- v


    override this.Awake (context) = 
        System.Console.WriteLine("Hello F#")
        this.myLabel.SetText("F# |> I ♡")

