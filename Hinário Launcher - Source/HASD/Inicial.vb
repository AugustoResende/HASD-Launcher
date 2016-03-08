Public Class Inicial
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    Private Sub Inicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NumeroHino.MaxLength = 3
    End Sub

    Private Sub Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abrir.Click
        If String.IsNullOrWhiteSpace(NumeroHino.Text) Then
        Else
            Dim hinoformatado As String
            Dim hino As Integer
            hino = NumeroHino.Text
            hinoformatado = hino.ToString("D3")
            If My.Computer.FileSystem.FileExists(hinoformatado + ".exe") Then
                Process.Start(hinoformatado + ".exe")
            End If
            NumeroHino.Text = ""
        End If
        NumeroHino.Focus()
    End Sub
    Private Sub NumeroHino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumeroHino.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(NumeroHino.Text) Then
            Else
                Dim hinoformatado As String
                Dim hino As Integer
                hino = NumeroHino.Text
                hinoformatado = hino.ToString("D3")
                If My.Computer.FileSystem.FileExists(hinoformatado + ".exe") Then
                    Process.Start(hinoformatado + ".exe")
                ElseIf My.Computer.FileSystem.FileExists(hinoformatado + ".pps") Then
                    Process.Start(hinoformatado + ".pps")
                ElseIf My.Computer.FileSystem.FileExists(hinoformatado + ".ppsx") Then
                    Process.Start(hinoformatado + ".ppsx")
                End If
                NumeroHino.Text = ""
            End If
            e.SuppressKeyPress = True
        End If
    End Sub
End Class



