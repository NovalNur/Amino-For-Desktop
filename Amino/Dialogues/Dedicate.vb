﻿Public Class Dedicate

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub Dedicate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

    End Sub
End Class