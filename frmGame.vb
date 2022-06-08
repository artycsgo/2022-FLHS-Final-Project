Public Class frmGame
    'Martin Bassett, 5/24/2022
    'Period #7, Final Project 2022, All Hail Mr. Glebas
    'Balloon Popping Game! Pop the balloons as they float up and gain points, user can select difficulty and look at previous scores
    'Aproved for no function
    Dim timerCounter As Integer = 60
    Dim randomNum As New Random
    Dim x As Integer
    Public score As Integer = 0
    Private Sub frmGame_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        '**************************************************************************************
        'Enables countdown timer
        'Changes the balloon timer's interval according to the users selected difficulty
        'Enables the balloon timer
        'Resets the balloons location
        '**************************************************************************************

        'Enables the main timer
        tmrTimer.Enabled = True

        'Checks the difficulty that the user selects and changes the interval accordingly
        If frmStart.radHard.Checked = True Then
            tmrBalloon.Interval = 16
        ElseIf frmStart.radMedium.Checked = True Then
            tmrBalloon.Interval = 20
        ElseIf frmStart.radEasy.Checked = True Then
            tmrBalloon.Interval = 25
        End If

        'Enables the balloon timer
        tmrBalloon.Enabled = True

        'Resets the balloons location
        reset()
    End Sub

    Private Sub tmrTimer_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTimer.Tick
        '******************************************************************************************
        'Updates the textbox to display the time
        'Updates the time
        'Ends the program when time has ran out
        '******************************************************************************************

        'Updates the textbox which displays the time left for the user
        txtTimeRemaining.Text = timerCounter

        'Subtracts one from the counter, which is the time
        timerCounter -= 1

        'Checks if the time has run out, if it has it ends the game and switches to another form
        If timerCounter < 0 Then
            gameover()
            tmrTimer.Stop()
        End If
    End Sub

    Private Sub tmrBalloon_Tick(sender As System.Object, e As System.EventArgs) Handles tmrBalloon.Tick
        '**********************************************************************************************
        'Location of the balloon is updated each time the timer ticks
        'Checks if the balloon has ran off the screen; if it does, the location of the balloon is reset
        '**********************************************************************************************

        'Updates the location of the balloon
        picBalloon.Top -= 10

        'Declares the X-value of the balloon
        picBalloon.Left = x

        'Checks if the balloon has ran off of the screen, resets location if it does
        If picBalloon.Bottom < 0 Then
            reset()
        End If
    End Sub

    Private Sub picBalloon_Click(sender As System.Object, e As System.EventArgs) Handles picBalloon.Click
        '************************************************************************************************
        'Updates the user's score each time they pop the balloon
        'Resets the balloons location each time they pop it
        '************************************************************************************************

        'Updates the score
        score += 1

        'Resets the location of the balloon
        reset()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles menustripClose.Click
        '************************************************************************************************************************
        'Shuts down the program
        '************************************************************************************************************************

        'Closes the current form
        Me.Close()

        'Closes the start form
        frmStart.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles menustripReset.Click
        '**************************************************************************************************************************
        'Resets the entire game
        '**************************************************************************************************************************

        'Resets the location of the balloon
        reset()

        'Resets the score
        score = 0

        'Resets the time
        timerCounter = 60
    End Sub

    Sub gameover()
        '**************************************
        'Ends the timer
        'Closes current form and opens next one
        '**************************************

        'Stops the timer for the balloon
        tmrBalloon.Enabled = False

        'Switches to the next form
        frmGameover.Show()

        'Closes the current form
        Me.Close()
    End Sub

    Sub reset()
        '*******************************************
        'Resets the location of the balloon
        '*******************************************

        'Assigns a new random X-value to the balloon
        x = randomNum.Next(50, Me.Width - 50)

        'Updates the Y-value of the balloon
        picBalloon.Top = Me.Height
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Click on the balloons to pop them! Try to pop as many balloons as you can in 60 seconds, good luck!")
    End Sub
End Class
