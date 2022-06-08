Public Class frmStart
    Public userName As String
    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        '******************************************************************************************
        'Gets the users name
        'Switches to the next form
        '******************************************************************************************


        'Switches to the next form
        frmGame.Show()

        'Hides the current form
        Me.Hide()
    End Sub

    Private Sub frmStart_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '***************************************************************************************
        'Gets the users name
        '***************************************************************************************

        'Error traps to make sure the input isn't blank and isn't numbers
        Do
            userName = InputBox("Enter your name")
        Loop Until userName <> ""
    End Sub
End Class
