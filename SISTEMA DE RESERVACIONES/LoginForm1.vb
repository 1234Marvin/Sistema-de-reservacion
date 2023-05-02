Imports System.Security.Cryptography.X509Certificates

Public Class LoginForm1

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Public Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try
            Dim dts As New Datos
            Dim funciones As New Funcion
            dts.gusuario = Me.UsernameTextBox.Text
            dts.gcontrase�a = Me.PasswordTextBox.Text
            dts.gtipo = Me.ComboBox1.SelectedItem.tex

            If funciones.validar(dts) = True Then
                Dim fr As New CLIENTES
                fr.Show()
                Me.Hide()
            Else
                MessageBox.Show("datos incorrectos", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.UsernameTextBox.Clear()
                Me.PasswordTextBox.Clear()
                Me.UsernameTextBox.Focus()

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
