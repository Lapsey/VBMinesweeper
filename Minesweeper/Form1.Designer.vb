<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMinesweeper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpDifficulty = New System.Windows.Forms.GroupBox()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.grpDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(223, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(396, 68)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "MINESWEEPER"
        '
        'grpDifficulty
        '
        Me.grpDifficulty.Controls.Add(Me.radHard)
        Me.grpDifficulty.Controls.Add(Me.radMedium)
        Me.grpDifficulty.Controls.Add(Me.radEasy)
        Me.grpDifficulty.Location = New System.Drawing.Point(278, 167)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.Size = New System.Drawing.Size(273, 125)
        Me.grpDifficulty.TabIndex = 1
        Me.grpDifficulty.TabStop = False
        Me.grpDifficulty.Text = "Select a Difficulty"
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Location = New System.Drawing.Point(48, 58)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(48, 19)
        Me.radEasy.TabIndex = 0
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(102, 58)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(70, 19)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(178, 58)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(51, 19)
        Me.radHard.TabIndex = 2
        Me.radHard.TabStop = True
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(380, 318)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'frmMinesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.grpDifficulty)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMinesweeper"
        Me.Text = "Minesweeper"
        Me.grpDifficulty.ResumeLayout(False)
        Me.grpDifficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpDifficulty As GroupBox
    Friend WithEvents radHard As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radEasy As RadioButton
    Friend WithEvents btnPlay As Button
End Class
