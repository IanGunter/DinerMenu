<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DinerMenuForm))
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FoodPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.FoodPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SoupButton.Location = New System.Drawing.Point(12, 375)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(98, 53)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup"
        Me.ToolTip1.SetToolTip(Me.SoupButton, "Display soup of the day")
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'SaladButton
        '
        Me.SaladButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaladButton.Location = New System.Drawing.Point(179, 375)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(98, 53)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.ToolTip1.SetToolTip(Me.SaladButton, "Display Salad of the day")
        Me.SaladButton.UseVisualStyleBackColor = False
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FishButton.Location = New System.Drawing.Point(357, 375)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(98, 54)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish"
        Me.ToolTip1.SetToolTip(Me.FishButton, "Display fish of the day")
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitButton.Location = New System.Drawing.Point(676, 375)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(98, 53)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit Program")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Kozuka Mincho Pr6N R", 35.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(264, -22)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(304, 78)
        Me.DinerNameLabel.TabIndex = 5
        Me.DinerNameLabel.Text = "Hyrule Diner"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Kozuka Gothic Pro R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(353, 99)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(407, 213)
        Me.DisplaySpecialLabel.TabIndex = 6
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FoodPictureBox
        '
        Me.FoodPictureBox.Location = New System.Drawing.Point(105, 130)
        Me.FoodPictureBox.Name = "FoodPictureBox"
        Me.FoodPictureBox.Size = New System.Drawing.Size(150, 151)
        Me.FoodPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FoodPictureBox.TabIndex = 7
        Me.FoodPictureBox.TabStop = False
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FoodPictureBox)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DinerMenuForm"
        Me.Text = "Hyrule Diner"
        CType(Me.FoodPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents DisplaySpecialLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FoodPictureBox As PictureBox
End Class
