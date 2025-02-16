<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class USwitch
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USwitch))
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.pbSwitch = New System.Windows.Forms.PictureBox()
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "off-button.png")
        Me.imgList.Images.SetKeyName(1, "switch-on.png")
        '
        'pbSwitch
        '
        Me.pbSwitch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbSwitch.Location = New System.Drawing.Point(3, 770)
        Me.pbSwitch.Name = "pbSwitch"
        Me.pbSwitch.Size = New System.Drawing.Size(128, 128)
        Me.pbSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbSwitch.TabIndex = 0
        Me.pbSwitch.TabStop = False
        '
        'USwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbSwitch)
        Me.Name = "USwitch"
        Me.Size = New System.Drawing.Size(800, 901)
        CType(Me.pbSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgList As ImageList
    Friend WithEvents pbSwitch As PictureBox
End Class
