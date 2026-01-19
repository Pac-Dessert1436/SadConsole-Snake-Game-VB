Imports SadConsole
Imports SadConsole.Configuration

Public Module Program
    Friend Sub Main()
        Settings.WindowTitle = "SadConsole Snake Game"

        Builder.GetBuilder().SetWindowSizeInCells(120, 40).ConfigureFonts(True).
            SetStartingScreen(Of RootScreen)().IsStartingScreenFocused(True).Run()
    End Sub
End Module