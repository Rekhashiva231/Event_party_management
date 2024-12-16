Imports System.Windows.Forms

Public Class MDIParent1
   


    Private Sub MDIParent1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub


    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CustomerForm.MdiParent = Me
        CustomerForm.Show()
    End Sub




    Private Sub FloristToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FoodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EventForm.MdiParent = Me
        EventForm.Show()
    End Sub



    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BookForm.MdiParent = Me
        BookForm.Show()
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CustListReport.MdiParent = Me
        CustListReport.Show()
    End Sub

    Private Sub VenueListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VenueListReport.MdiParent = Me
        VenueListReport.Show()
    End Sub

    Private Sub BookingListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BookingListReport.MdiParent = Me
        BookingListReport.Show()
    End Sub

    Private Sub CustomerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        CustomerForm.MdiParent = Me
        CustomerForm.Show()
    End Sub

    Private Sub CustEventDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustEventDetailsToolStripMenuItem.Click
        EventForm.MdiParent = Me
        EventForm.Show()
    End Sub

    Private Sub CustBookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustBookingToolStripMenuItem.Click
        BookForm.MdiParent = Me
        BookForm.Show()
    End Sub


    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ServicesForm.MdiParent = Me
        ServicesForm.Show()
    End Sub



    Private Sub FoodDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FoodForm.MdiParent = Me
        FoodForm.Show()
    End Sub



    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        PaymentForm.MdiParent = Me
        PaymentForm.Show()
    End Sub

    Private Sub CustomerListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListToolStripMenuItem1.Click
        CustListReport.MdiParent = Me
        CustListReport.Show()
    End Sub

    Private Sub CustEventListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustEventListToolStripMenuItem.Click
        CustEventListForm.MdiParent = Me
        CustEventListForm.Show()
    End Sub

    Private Sub BookingListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingListToolStripMenuItem1.Click
        BookingListReport.MdiParent = Me
        BookingListReport.Show()
    End Sub

    Private Sub PaymentListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentListToolStripMenuItem.Click
        PaymentListForm.MdiParent = Me
        PaymentListForm.Show()
    End Sub



  

    Private Sub VenueDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VenueDetailsToolStripMenuItem.Click
        VenueForm.MdiParent = Me
        VenueForm.Show()
    End Sub

    Private Sub FoodDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodDetailsToolStripMenuItem1.Click
        FoodForm.MdiParent = Me
        FoodForm.Show()
    End Sub

    Private Sub ServicesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesDetailsToolStripMenuItem.Click
        ServicesForm.MdiParent = Me
        ServicesForm.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click

    End Sub
End Class
