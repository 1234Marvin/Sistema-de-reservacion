Public Class CLIENTES
    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click
        Application.Exit()
    End Sub

    Private Sub Btn_minimizar_Click(sender As Object, e As EventArgs) Handles Btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class