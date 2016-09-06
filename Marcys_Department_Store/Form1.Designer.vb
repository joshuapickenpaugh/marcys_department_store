<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstItem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSecondItem = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&First item:"
        '
        'txtFirstItem
        '
        Me.txtFirstItem.Location = New System.Drawing.Point(15, 25)
        Me.txtFirstItem.Name = "txtFirstItem"
        Me.txtFirstItem.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstItem.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Second item:"
        '
        'txtSecondItem
        '
        Me.txtSecondItem.Location = New System.Drawing.Point(157, 25)
        Me.txtSecondItem.Name = "txtSecondItem"
        Me.txtSecondItem.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondItem.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(15, 133)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 27)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculator"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(157, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 27)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(83, 79)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = " "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 172)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtSecondItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstItem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcy's Department Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstItem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondItem As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
End Class
