﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanelUpdates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsPanelUpdates))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.UpdatesTab = New System.Windows.Forms.TabPage()
        Me.UpdateBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EnableUpdates = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisableUpdates = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.UpdatesTab.SuspendLayout()
        Me.UpdateBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 14
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(248, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change update settings..."
        '
        'BackButton
        '
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Image = Global.Amino.My.Resources.Resources.Back
        Me.BackButton.Location = New System.Drawing.Point(3, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(48, 48)
        Me.BackButton.TabIndex = 15
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.UpdatesTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(417, 205)
        Me.TabControl1.TabIndex = 15
        '
        'UpdatesTab
        '
        Me.UpdatesTab.Controls.Add(Me.UpdateBox)
        Me.UpdatesTab.Location = New System.Drawing.Point(4, 22)
        Me.UpdatesTab.Name = "UpdatesTab"
        Me.UpdatesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdatesTab.Size = New System.Drawing.Size(409, 179)
        Me.UpdatesTab.TabIndex = 0
        Me.UpdatesTab.Text = "Updates"
        Me.UpdatesTab.UseVisualStyleBackColor = True
        '
        'UpdateBox
        '
        Me.UpdateBox.Controls.Add(Me.PictureBox1)
        Me.UpdateBox.Controls.Add(Me.PictureBox2)
        Me.UpdateBox.Controls.Add(Me.EnableUpdates)
        Me.UpdateBox.Controls.Add(Me.Label2)
        Me.UpdateBox.Controls.Add(Me.DisableUpdates)
        Me.UpdateBox.Controls.Add(Me.Label3)
        Me.UpdateBox.Location = New System.Drawing.Point(6, 6)
        Me.UpdateBox.Name = "UpdateBox"
        Me.UpdateBox.Size = New System.Drawing.Size(397, 113)
        Me.UpdateBox.TabIndex = 15
        Me.UpdateBox.TabStop = False
        Me.UpdateBox.Text = "Update Settings"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Amino.My.Resources.Resources.Okay
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Amino.My.Resources.Resources.ErrorIco
        Me.PictureBox2.Location = New System.Drawing.Point(6, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'EnableUpdates
        '
        Me.EnableUpdates.AutoSize = True
        Me.EnableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableUpdates.Location = New System.Drawing.Point(44, 21)
        Me.EnableUpdates.Name = "EnableUpdates"
        Me.EnableUpdates.Size = New System.Drawing.Size(159, 17)
        Me.EnableUpdates.TabIndex = 1
        Me.EnableUpdates.Text = "Enable automatic updates"
        Me.EnableUpdates.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(41, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Check for updates when starting."
        '
        'DisableUpdates
        '
        Me.DisableUpdates.AutoSize = True
        Me.DisableUpdates.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisableUpdates.Location = New System.Drawing.Point(44, 59)
        Me.DisableUpdates.Name = "DisableUpdates"
        Me.DisableUpdates.Size = New System.Drawing.Size(162, 17)
        Me.DisableUpdates.TabIndex = 2
        Me.DisableUpdates.Text = "Disable automatic updates"
        Me.DisableUpdates.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(41, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Do not check for updates."
        '
        'SettingsPanelUpdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 276)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsPanelUpdates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Updates"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.UpdatesTab.ResumeLayout(False)
        Me.UpdateBox.ResumeLayout(False)
        Me.UpdateBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UpdatesTab As TabPage
    Friend WithEvents UpdateBox As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EnableUpdates As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DisableUpdates As RadioButton
    Friend WithEvents Label3 As Label
End Class
