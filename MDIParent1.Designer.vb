<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.VenueDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FoodDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ServicesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustEventDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CustEventListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookingListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PaymentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(964, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.CustomerDetailsToolStripMenuItem, Me.CustEventDetailsToolStripMenuItem, Me.CustBookingToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.ReportsToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(964, 26)
        Me.MenuStrip2.TabIndex = 12
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VenueDetailsToolStripMenuItem, Me.FoodDetailsToolStripMenuItem1, Me.ServicesDetailsToolStripMenuItem})
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripMenuItem5.Text = "Main Entries"
        '
        'VenueDetailsToolStripMenuItem
        '
        Me.VenueDetailsToolStripMenuItem.Name = "VenueDetailsToolStripMenuItem"
        Me.VenueDetailsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.VenueDetailsToolStripMenuItem.Text = "Venue Details"
        '
        'FoodDetailsToolStripMenuItem1
        '
        Me.FoodDetailsToolStripMenuItem1.Name = "FoodDetailsToolStripMenuItem1"
        Me.FoodDetailsToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.FoodDetailsToolStripMenuItem1.Text = "Food Details"
        '
        'ServicesDetailsToolStripMenuItem
        '
        Me.ServicesDetailsToolStripMenuItem.Name = "ServicesDetailsToolStripMenuItem"
        Me.ServicesDetailsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ServicesDetailsToolStripMenuItem.Text = "Services Details"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'CustEventDetailsToolStripMenuItem
        '
        Me.CustEventDetailsToolStripMenuItem.Name = "CustEventDetailsToolStripMenuItem"
        Me.CustEventDetailsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CustEventDetailsToolStripMenuItem.Text = "Cust Event Details"
        '
        'CustBookingToolStripMenuItem
        '
        Me.CustBookingToolStripMenuItem.Name = "CustBookingToolStripMenuItem"
        Me.CustBookingToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CustBookingToolStripMenuItem.Text = "Cust Booking"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(86, 22)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerListToolStripMenuItem1, Me.CustEventListToolStripMenuItem, Me.BookingListToolStripMenuItem1, Me.PaymentListToolStripMenuItem})
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(78, 22)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'CustomerListToolStripMenuItem1
        '
        Me.CustomerListToolStripMenuItem1.Name = "CustomerListToolStripMenuItem1"
        Me.CustomerListToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.CustomerListToolStripMenuItem1.Text = "Customer List"
        '
        'CustEventListToolStripMenuItem
        '
        Me.CustEventListToolStripMenuItem.Name = "CustEventListToolStripMenuItem"
        Me.CustEventListToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CustEventListToolStripMenuItem.Text = "Cust Event List"
        '
        'BookingListToolStripMenuItem1
        '
        Me.BookingListToolStripMenuItem1.Name = "BookingListToolStripMenuItem1"
        Me.BookingListToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.BookingListToolStripMenuItem1.Text = "Booking List"
        '
        'PaymentListToolStripMenuItem
        '
        Me.PaymentListToolStripMenuItem.Name = "PaymentListToolStripMenuItem"
        Me.PaymentListToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PaymentListToolStripMenuItem.Text = "Payment List"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip2)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "MDIParent1"
        Me.Text = "Party  Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustEventDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustEventListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VenueDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoodDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
