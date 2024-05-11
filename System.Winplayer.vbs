Set objArgs = Wscript.Arguments
if (objArgs.Count = 0) then
    WScript.Quit 123
end if
Set objPlayer = createobject("Wmplayer.OCX.7")
With objPlayer  ' saves typing
    .settings.autoStart = True
    .settings.volume = 100  ' 0 - 100
    .settings.balance = 0  ' -100 to 100
    .settings.enableErrorDialogs = False
    .enableContextMenu = False
    .URL = objArgs(0)
    WScript.Sleep(140000)  ' time to load and start playing
    .Controls.Pause()  ' stop
End With
WScript.Quit