﻿Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()
        Dim i As Integer

        Do While (i <= 10)
            lstResult.Items.Add("The Perfect Square: " & i ^ 2)
            i = i + 1
        Loop


        lstResult.Items.Add("Not implemented yet")

    End Sub
End Class
