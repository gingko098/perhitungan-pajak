Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdhasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhasil.Click
        Const penghasilan As Double = 0.05
        Dim harga As Single

        harga = txtGAJIBRUTO.Text
        txtPAJAK.Text = 0.05 * txtGAJIBRUTO.Text
        txtTOTAL.Text = txtGAJIBRUTO.Text * penghasilan
        txtPAJAKBULAN.Text = penghasilan
        txtPAJAKTAHUN.Text = txtPAJAKBULAN.Text * 12

    End Sub


    Private Sub txtASURANSIPENSIUN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtASURANSIPENSIUN.TextChanged
        txtGAJIBRUTO.Text = Val(txtGAJISEBULAN.Text) + Val(txtASURANSIKECELAKAAN.Text) + Val(txtASURANSIKEMATIAN.Text) + Val(txtASURANSIPENSIUN.Text)
    End Sub

    Private Sub cmdhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhapus.Click
        MsgBox("Hapus data")
        txtALAMAT.Text = ""
        txtNPWP.Text = ""
        txtNAMA.Text = ""
        txtGAJISEBULAN.Text = ""
        txtASURANSIKECELAKAAN.Text = ""
        txtASURANSIKEMATIAN.Text = ""
        txtASURANSIPENSIUN.Text = ""
        txtGAJIBRUTO.Text = ""
        txtPAJAK.Text = ""
        txtTOTAL.Text = ""
        txtPAJAKBULAN.Text = ""
        txtPAJAKTAHUN.Text = ""
    End Sub
End Class

