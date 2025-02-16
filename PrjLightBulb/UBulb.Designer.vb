<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UBulb
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UBulb))
        Me.pbLight = New System.Windows.Forms.PictureBox()
        Me.imgLoend = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLight
        '
        Me.pbLight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbLight.Location = New System.Drawing.Point(48, 160)
        Me.pbLight.Name = "pbLight"
        Me.pbLight.Size = New System.Drawing.Size(256, 240)
        Me.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbLight.TabIndex = 0
        Me.pbLight.TabStop = False
        '
        'imgLoend
        '
        Me.imgLoend.ImageStream = CType(resources.GetObject("imgLoend.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLoend.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLoend.Images.SetKeyName(0, "light-bulb.152x256 (1).png")
        Me.imgLoend.Images.SetKeyName(1, "light-bulb.152x256.png")
        '
        'UBulb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbLight)
        Me.Location = New System.Drawing.Point(25, 208)
        Me.Name = "UBulb"
        Me.Size = New System.Drawing.Size(800, 527)
        CType(Me.pbLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLight As PictureBox
    Friend WithEvents imgLoend As ImageList
End Class
