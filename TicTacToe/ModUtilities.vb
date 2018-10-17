'Module Themes
' \/ Theme structures in waiting
'    Public Class DefaultLightTheme

'        Public ReadOnly Property Name As String
'            Get
'                Return "Default Light" ' Font Name
'            End Get
'        End Property

'        Public Class FormStyles
'            Public ReadOnly Property ForeColour As KnownColor
'                Get
'                    Return KnownColor.ControlText ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property BackColour As KnownColor
'                Get
'                    Return KnownColor.Control ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourNoughts As Color
'                Get
'                    Return Color.DarkBlue ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourNoughtsHover As Color
'                Get
'                    Return Color.LightBlue ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourCrosses As Color
'                Get
'                    Return Color.Maroon ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourCrossesHover As Color
'                Get
'                    Return Color.Salmon ' Colour
'                End Get
'            End Property

'        End Class

'        Public Class ButtonStyles
'            Public ReadOnly Property ButtonColour As KnownColor
'                Get
'                    Return KnownColor.Control ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property ButtonTextColor As Color
'                Get
'                    Return Color.Black ' Colour
'                End Get
'            End Property

'        End Class


'        Public Class FontStyles
'            Public ReadOnly Property Colour As Color
'                Get
'                    Return Color.Black
'                End Get
'            End Property

'            Public ReadOnly Property Size As Short
'                Get
'                    Return 8.25
'                End Get
'            End Property

'            Public ReadOnly Property Name As String
'                Get
'                    Return "Microsoft Sans Serif" ' Font Name
'                End Get
'            End Property

'            Public ReadOnly Property Effects As String
'                Get
'                    Return "Regular"
'                End Get
'            End Property

'        End Class

'    End Class


'    Public Class DarkTheme

'        Public ReadOnly Property Name As String
'            Get
'                Return "Dark" ' Font Name
'            End Get
'        End Property

'        Public Class FormStyles
'            Public ReadOnly Property ForeColour As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property BackColour As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourNoughts As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourNoughtsHover As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourCrosses As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property TextColourCrossesHover As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'        End Class

'        Public Class ButtonStyles
'            Public ReadOnly Property ButtonColour As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'            Public ReadOnly Property ButtonTextColor As Color
'                Get
'                    Return ' Colour
'                End Get
'            End Property

'        End Class


'        Public Class FontStyles
'            Public ReadOnly Property Colour As Color
'                Get
'                    Return Color.Black
'                End Get
'            End Property

'            Public ReadOnly Property Size As Short
'                Get
'                    Return 8.25
'                End Get
'            End Property

'            Public ReadOnly Property Name As String
'                Get
'                    Return "Microsoft Sans Serif" ' Font Name
'                End Get
'            End Property

'            Public ReadOnly Property Effects As String
'                Get
'                    Return "Regular"
'                End Get
'            End Property

'        End Class

'    End Class
'End Module

Module ModUtilities

    ''' <summary>
    ''' Changes where the replays are saved to
    ''' </summary>
    ''' <returns>The filepath of the new folder</returns>
    Public Function ChangeSaveFolder()
        Dim FolderBrowser As FolderBrowserDialog = New FolderBrowserDialog

        FolderBrowser.Description = "Select the folder to save to"
        FolderBrowser.ShowNewFolderButton = True

        If FolderBrowser.ShowDialog() = DialogResult.OK Then
            My.Settings.SaveFolder = FolderBrowser.SelectedPath
            Return FolderBrowser.SelectedPath
        End If
        MsgBox("No folder selected, save path unchanged")
        Return My.Settings.SaveFolder
    End Function


End Module
