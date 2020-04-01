<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewTransaction
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
        Me.btn_Cash = New System.Windows.Forms.Button()
        Me.btn_Credit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.lbl_Head = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cash
        '
        Me.btn_Cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cash.Location = New System.Drawing.Point(35, 80)
        Me.btn_Cash.Name = "btn_Cash"
        Me.btn_Cash.Size = New System.Drawing.Size(169, 86)
        Me.btn_Cash.TabIndex = 0
        Me.btn_Cash.Text = "Cash"
        Me.btn_Cash.UseVisualStyleBackColor = True
        '
        'btn_Credit
        '
        Me.btn_Credit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Credit.Location = New System.Drawing.Point(220, 80)
        Me.btn_Credit.Name = "btn_Credit"
        Me.btn_Credit.Size = New System.Drawing.Size(169, 86)
        Me.btn_Credit.TabIndex = 1
        Me.btn_Credit.Text = "Credit"
        Me.btn_Credit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.lbl_Head)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 44)
        Me.Panel1.TabIndex = 8
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(384, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(45, 44)
        Me.btn_Close.TabIndex = 4
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'lbl_Head
        '
        Me.lbl_Head.AutoSize = True
        Me.lbl_Head.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Head.ForeColor = System.Drawing.Color.White
        Me.lbl_Head.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Head.Name = "lbl_Head"
        Me.lbl_Head.Size = New System.Drawing.Size(131, 24)
        Me.lbl_Head.TabIndex = 3
        Me.lbl_Head.Text = "Payment Type"
        '
        'frmNewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 197)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Credit)
        Me.Controls.Add(Me.btn_Cash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNewTransaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Cash As Button
    Friend WithEvents btn_Credit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Head As Label
    Friend WithEvents btn_Close As Button
End Class
