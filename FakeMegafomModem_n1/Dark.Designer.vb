<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dark
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dark))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FakeMegafonModem_n1.My.Resources.Resources.Без_названия_2
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Megafon Modem"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(74, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surf the internet!"
        Me.Label2.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.FakeMegafonModem_n1.My.Resources.Resources.close_button_normal
        Me.PictureBox2.Location = New System.Drawing.Point(234, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "？.png")
        Me.ImageList1.Images.SetKeyName(1, "01.png")
        Me.ImageList1.Images.SetKeyName(2, "border_line.png")
        Me.ImageList1.Images.SetKeyName(3, "button_disabled.png")
        Me.ImageList1.Images.SetKeyName(4, "button_focus.png")
        Me.ImageList1.Images.SetKeyName(5, "button_hover.png")
        Me.ImageList1.Images.SetKeyName(6, "button_normal.png")
        Me.ImageList1.Images.SetKeyName(7, "button_pressed.png")
        Me.ImageList1.Images.SetKeyName(8, "call_button_disable.png")
        Me.ImageList1.Images.SetKeyName(9, "call_button_hover.png")
        Me.ImageList1.Images.SetKeyName(10, "call_button_normal.png")
        Me.ImageList1.Images.SetKeyName(11, "call_button_pressed.png")
        Me.ImageList1.Images.SetKeyName(12, "call_idle_screen.png")
        Me.ImageList1.Images.SetKeyName(13, "call_slider_groove.png")
        Me.ImageList1.Images.SetKeyName(14, "call_volume_bg.png")
        Me.ImageList1.Images.SetKeyName(15, "checkbox_checked_disabled.png")
        Me.ImageList1.Images.SetKeyName(16, "checkbox_checked_hover.png")
        Me.ImageList1.Images.SetKeyName(17, "checkbox_checked_normal.png")
        Me.ImageList1.Images.SetKeyName(18, "checkbox_checked_pressed.png")
        Me.ImageList1.Images.SetKeyName(19, "close_button_disable.png")
        Me.ImageList1.Images.SetKeyName(20, "close_button_hover.png")
        Me.ImageList1.Images.SetKeyName(21, "close_button_normal.png")
        Me.ImageList1.Images.SetKeyName(22, "close_button_press.png")
        Me.ImageList1.Images.SetKeyName(23, "combobox_down_arrow_gray.png")
        Me.ImageList1.Images.SetKeyName(24, "combobox_down_arrow_hover.png")
        Me.ImageList1.Images.SetKeyName(25, "combobox_down_arrow_normal.png")
        Me.ImageList1.Images.SetKeyName(26, "combobox_down_arrow_press.png")
        Me.ImageList1.Images.SetKeyName(27, "contact.png")
        Me.ImageList1.Images.SetKeyName(28, "DeleteDetail.png")
        Me.ImageList1.Images.SetKeyName(29, "diagnostics2_bg.png")
        Me.ImageList1.Images.SetKeyName(30, "maximize_button_disable.png")
        Me.ImageList1.Images.SetKeyName(31, "maximize_button_hover.png")
        Me.ImageList1.Images.SetKeyName(32, "maximize_button_normal.png")
        Me.ImageList1.Images.SetKeyName(33, "maximize_button_press.png")
        Me.ImageList1.Images.SetKeyName(34, "menu_bar_button_hover.png")
        Me.ImageList1.Images.SetKeyName(35, "menu_bar_button_sel.png")
        Me.ImageList1.Images.SetKeyName(36, "menu_bg.png")
        Me.ImageList1.Images.SetKeyName(37, "menu_check.png")
        Me.ImageList1.Images.SetKeyName(38, "menu_expand.png")
        Me.ImageList1.Images.SetKeyName(39, "minimum_disable.png")
        Me.ImageList1.Images.SetKeyName(40, "minimum_hover.png")
        Me.ImageList1.Images.SetKeyName(41, "minimum_normal.png")
        Me.ImageList1.Images.SetKeyName(42, "minimum_press.png")
        Me.ImageList1.Images.SetKeyName(43, "MyInbox.png")
        Me.ImageList1.Images.SetKeyName(44, "plus.png")
        Me.ImageList1.Images.SetKeyName(45, "popup_controls_button_down.png")
        Me.ImageList1.Images.SetKeyName(46, "popup_controls_button_down_gray.png")
        Me.ImageList1.Images.SetKeyName(47, "popup_controls_button_down_hover.png")
        Me.ImageList1.Images.SetKeyName(48, "popup_controls_button_down_press.png")
        Me.ImageList1.Images.SetKeyName(49, "popup_controls_button_left.png")
        Me.ImageList1.Images.SetKeyName(50, "popup_controls_button_left_gray.png")
        Me.ImageList1.Images.SetKeyName(51, "popup_controls_button_left_hover.png")
        Me.ImageList1.Images.SetKeyName(52, "popup_controls_button_left_press.png")
        Me.ImageList1.Images.SetKeyName(53, "popup_controls_button_right.png")
        Me.ImageList1.Images.SetKeyName(54, "popup_controls_button_right_gray.png")
        Me.ImageList1.Images.SetKeyName(55, "popup_controls_button_right_hover.png")
        Me.ImageList1.Images.SetKeyName(56, "popup_controls_button_right_press.png")
        Me.ImageList1.Images.SetKeyName(57, "popup_controls_button_up.png")
        Me.ImageList1.Images.SetKeyName(58, "popup_controls_button_up_gray.png")
        Me.ImageList1.Images.SetKeyName(59, "popup_controls_button_up_hover.png")
        Me.ImageList1.Images.SetKeyName(60, "popup_controls_button_up_press.png")
        Me.ImageList1.Images.SetKeyName(61, "progressbar_bg.png")
        Me.ImageList1.Images.SetKeyName(62, "progressbar_bg1.png")
        Me.ImageList1.Images.SetKeyName(63, "progressbar_disabled_bg.png")
        Me.ImageList1.Images.SetKeyName(64, "radio_button_disabled.png")
        Me.ImageList1.Images.SetKeyName(65, "radio_button_hover.png")
        Me.ImageList1.Images.SetKeyName(66, "radio_button_normal.png")
        Me.ImageList1.Images.SetKeyName(67, "radio_button_pressed.png")
        Me.ImageList1.Images.SetKeyName(68, "radio_button2_disabled.png")
        Me.ImageList1.Images.SetKeyName(69, "radio_button2_hover.png")
        Me.ImageList1.Images.SetKeyName(70, "radio_button2_normal.png")
        Me.ImageList1.Images.SetKeyName(71, "radio_button2_pressed.png")
        Me.ImageList1.Images.SetKeyName(72, "radio_button3_disabled.png")
        Me.ImageList1.Images.SetKeyName(73, "radio_button3_hover.png")
        Me.ImageList1.Images.SetKeyName(74, "radio_button3_normal.png")
        Me.ImageList1.Images.SetKeyName(75, "radio_button3_pressed.png")
        Me.ImageList1.Images.SetKeyName(76, "restore_button_disable.png")
        Me.ImageList1.Images.SetKeyName(77, "restore_button_hover.png")
        Me.ImageList1.Images.SetKeyName(78, "restore_button_normal.png")
        Me.ImageList1.Images.SetKeyName(79, "restore_button_press.png")
        Me.ImageList1.Images.SetKeyName(80, "scroll_arrow_right.png")
        Me.ImageList1.Images.SetKeyName(81, "sel_button.png")
        Me.ImageList1.Images.SetKeyName(82, "sel_radio_button_disabled.png")
        Me.ImageList1.Images.SetKeyName(83, "sel_radio_button_hover.png")
        Me.ImageList1.Images.SetKeyName(84, "sel_radio_button_normal.png")
        Me.ImageList1.Images.SetKeyName(85, "sel_radio_button_pressed.png")
        Me.ImageList1.Images.SetKeyName(86, "sel_radio_button2_disabled.png")
        Me.ImageList1.Images.SetKeyName(87, "sel_radio_button2_hover.png")
        Me.ImageList1.Images.SetKeyName(88, "sel_radio_button2_normal.png")
        Me.ImageList1.Images.SetKeyName(89, "sel_radio_button2_pressed.png")
        Me.ImageList1.Images.SetKeyName(90, "sel_radio_button3_disabled.png")
        Me.ImageList1.Images.SetKeyName(91, "sel_radio_button3_hover.png")
        Me.ImageList1.Images.SetKeyName(92, "sel_radio_button3_normal.png")
        Me.ImageList1.Images.SetKeyName(93, "sel_radio_button3_pressed.png")
        Me.ImageList1.Images.SetKeyName(94, "sms_label_bkground.png")
        Me.ImageList1.Images.SetKeyName(95, "tab_unselect.png")
        Me.ImageList1.Images.SetKeyName(96, "table_header_arrow_down.png")
        Me.ImageList1.Images.SetKeyName(97, "table_header_arrow_up.png")
        Me.ImageList1.Images.SetKeyName(98, "table_header_bg.png")
        Me.ImageList1.Images.SetKeyName(99, "table_header_hover.png")
        Me.ImageList1.Images.SetKeyName(100, "table_header_l_bg.png")
        Me.ImageList1.Images.SetKeyName(101, "table_header_l_hover.png")
        Me.ImageList1.Images.SetKeyName(102, "table_header_l_press.png")
        Me.ImageList1.Images.SetKeyName(103, "table_header_lr_bg.png")
        Me.ImageList1.Images.SetKeyName(104, "table_header_lr_hover.png")
        Me.ImageList1.Images.SetKeyName(105, "table_header_lr_press.png")
        Me.ImageList1.Images.SetKeyName(106, "table_header_press.png")
        Me.ImageList1.Images.SetKeyName(107, "table_header_r_bg.png")
        Me.ImageList1.Images.SetKeyName(108, "table_header_r_hover.png")
        Me.ImageList1.Images.SetKeyName(109, "table_header_r_press.png")
        Me.ImageList1.Images.SetKeyName(110, "table_header_separator.png")
        Me.ImageList1.Images.SetKeyName(111, "title_bar.png")
        Me.ImageList1.Images.SetKeyName(112, "tool_bar_bg.png")
        Me.ImageList1.Images.SetKeyName(113, "toolbar_arrow_hover.png")
        Me.ImageList1.Images.SetKeyName(114, "toolbar_arrow_normal.png")
        Me.ImageList1.Images.SetKeyName(115, "toolbar_arrow_press.png")
        Me.ImageList1.Images.SetKeyName(116, "tree_widget_bg_line_box.png")
        Me.ImageList1.Images.SetKeyName(117, "uiplugin_netinfo_bg.png")
        Me.ImageList1.Images.SetKeyName(118, "uiplugin2_bg.png")
        Me.ImageList1.Images.SetKeyName(119, "unsel_button.png")
        Me.ImageList1.Images.SetKeyName(120, "unsel_check_box_disabled.png")
        Me.ImageList1.Images.SetKeyName(121, "unsel_check_box_hover.png")
        Me.ImageList1.Images.SetKeyName(122, "unsel_check_box_pressed.png")
        Me.ImageList1.Images.SetKeyName(123, "unsel_check_box_unchecked.png")
        '
        'Timer3
        '
        '
        'Dark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dark"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer3 As Timer
End Class
