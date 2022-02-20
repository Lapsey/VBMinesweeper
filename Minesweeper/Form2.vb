Imports System.ComponentModel

Public Class frmGame
    Public numCols As Short = 10
    Public numRows As Short = 10
    Public grid As New List(Of Tile)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Init tile grid
        For i As Short = 0 To numRows - 1
            For j As Short = 0 To numCols - 1
                Dim pos As New Point(i, j)
                Dim tile As New Tile(pos, Me.Size, numCols, numRows)

                grid.Add(tile)
            Next
        Next
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub
End Class