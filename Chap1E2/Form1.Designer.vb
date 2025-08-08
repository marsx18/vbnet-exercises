<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EnglishButton = New System.Windows.Forms.Button()
        Me.SpanishButton = New System.Windows.Forms.Button()
        Me.FrenchButton = New System.Windows.Forms.Button()
        Me.HelloLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EnglishButton
        '
        Me.EnglishButton.Location = New System.Drawing.Point(132, 128)
        Me.EnglishButton.Name = "EnglishButton"
        Me.EnglishButton.Size = New System.Drawing.Size(89, 39)
        Me.EnglishButton.TabIndex = 0
        Me.EnglishButton.Text = "English"
        Me.EnglishButton.UseVisualStyleBackColor = True
        '
        'SpanishButton
        '
        Me.SpanishButton.Location = New System.Drawing.Point(132, 185)
        Me.SpanishButton.Name = "SpanishButton"
        Me.SpanishButton.Size = New System.Drawing.Size(89, 39)
        Me.SpanishButton.TabIndex = 1
        Me.SpanishButton.Text = "Spanish"
        Me.SpanishButton.UseVisualStyleBackColor = True
        '
        'FrenchButton
        '
        Me.FrenchButton.Location = New System.Drawing.Point(132, 243)
        Me.FrenchButton.Name = "FrenchButton"
        Me.FrenchButton.Size = New System.Drawing.Size(89, 39)
        Me.FrenchButton.TabIndex = 2
        Me.FrenchButton.Text = "French"
        Me.FrenchButton.UseVisualStyleBackColor = True
        '
        'HelloLabel
        '
        Me.HelloLabel.AutoSize = True
        Me.HelloLabel.Location = New System.Drawing.Point(288, 197)
        Me.HelloLabel.Name = "HelloLabel"
        Me.HelloLabel.Size = New System.Drawing.Size(51, 13)
        Me.HelloLabel.TabIndex = 3
        Me.HelloLabel.Text = "Translate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HelloLabel)
        Me.Controls.Add(Me.FrenchButton)
        Me.Controls.Add(Me.SpanishButton)
        Me.Controls.Add(Me.EnglishButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnglishButton As Button
    Friend WithEvents SpanishButton As Button
    Friend WithEvents FrenchButton As Button
    Friend WithEvents HelloLabel As Label
End Class
