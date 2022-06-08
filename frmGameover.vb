Public Class frmGameover
    Dim highscore As Integer
    Public count As Integer
    Private Sub btnPlayAgain_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayAgain.Click
        '****************************************************************************************************
        'Closes the current form and opens the start form
        '****************************************************************************************************

        'Hides the current form
        Me.Hide()

        'Opens the start form
        frmStart.Show()
    End Sub

    Private Sub gameover_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        '***************************************************************************************
        'Outputs the users name
        'Outputs the score from the most recent game
        '********************** *****************************************************************

        'Outputs the users name
        lblScore.Text = frmStart.userName.ToUpper & "'S SCORE:"

        'Outputs the most recent score
        txtScore.Text = frmGame.score
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        '******************************************************************************************
        'Closes all forms
        '******************************************************************************************

        'Closes all of the running forms
        Me.Close()
        frmStart.Close()
        frmGame.Close()
    End Sub

    Private Sub btnPastScores_Click(sender As System.Object, e As System.EventArgs)
        '******************************************************************************************************
        'Closes the current form
        '******************************************************************************************************

        'Closes the current form
        Me.Hide()
    End Sub
End Class

