﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThêmSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSPToolStripMenuItem, Me.ThêmKHToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(459, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThêmSPToolStripMenuItem
        '
        Me.ThêmSPToolStripMenuItem.Name = "ThêmSPToolStripMenuItem"
        Me.ThêmSPToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ThêmSPToolStripMenuItem.Text = "Thêm SP"
        '
        'ThêmKHToolStripMenuItem
        '
        Me.ThêmKHToolStripMenuItem.Name = "ThêmKHToolStripMenuItem"
        Me.ThêmKHToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ThêmKHToolStripMenuItem.Text = "Thêm KH"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.hoangdm.My.Resources.Resources.download
        Me.ClientSize = New System.Drawing.Size(459, 187)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ThêmSPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
