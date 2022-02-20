Public Class Tile
    Public lbl As Label
    Public minesAround As Integer

    Public Sub New(pos As Point, screenSize As Size, numCols As Integer, numRows As Integer)
        'SETUP LABEL
        Dim tileSize As New Size

        tileSize.Width = screenSize.Width / numCols
        tileSize.Height = screenSize.Height / numRows

        lbl = New Label
        lbl.Size = tileSize
        lbl.Left = pos.X * tileSize.Width
        lbl.Top = pos.Y * tileSize.Height

        lbl.BorderStyle = BorderStyle.FixedSingle

        'Add label to form
        frmGame.Controls.Add(lbl)
    End Sub
End Class
