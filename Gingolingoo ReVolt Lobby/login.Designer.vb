﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nickname = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.quit = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.lang = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'nickname
        '
        Me.nickname.AutoSize = True
        Me.nickname.Location = New System.Drawing.Point(12, 9)
        Me.nickname.Name = "nickname"
        Me.nickname.Size = New System.Drawing.Size(59, 13)
        Me.nickname.TabIndex = 0
        Me.nickname.Text = "$nickname"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 20)
        Me.TextBox1.TabIndex = 1
        '
        'quit
        '
        Me.quit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quit.Location = New System.Drawing.Point(287, 63)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(75, 23)
        Me.quit.TabIndex = 2
        Me.quit.Text = "$quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok.Location = New System.Drawing.Point(206, 63)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(75, 23)
        Me.ok.TabIndex = 3
        Me.ok.Text = "$ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'lang
        '
        Me.lang.AutoSize = True
        Me.lang.Location = New System.Drawing.Point(13, 68)
        Me.lang.Name = "lang"
        Me.lang.Size = New System.Drawing.Size(60, 13)
        Me.lang.TabIndex = 4
        Me.lang.Text = "$language:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(79, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 98)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lang)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.nickname)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nickname As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents quit As Button
    Friend WithEvents ok As Button
    Friend WithEvents lang As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
