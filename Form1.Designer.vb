<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.QiPan1 = New 五子棋.QiPan()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'QiPan1
        '
        Me.QiPan1.BackgroundImage = CType(resources.GetObject("QiPan1.BackgroundImage"), System.Drawing.Image)
        Me.QiPan1.Location = New System.Drawing.Point(12, 13)
        Me.QiPan1.Name = "QiPan1"
        Me.QiPan1.OnSetting = True
        Me.QiPan1.OnSettingPoint = New System.Drawing.Point(6, 6)
        Me.QiPan1.Size = New System.Drawing.Size(263, 284)
        Me.QiPan1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 313)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.QiPan1)
        Me.Name = "Form1"
        Me.Text = "five-in-a-row"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QiPan1 As 五子棋.QiPan
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
