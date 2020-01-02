Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sonic As New Sonicwall_Functions
        TextBox1.Text = sonic.read("C:\Users\rmiller\source\repos\SonicWallConfigEditor\Sonicwall Config Edit\Sonicwall Config Edit\Sonicwall configs\SW TZ500 Base Config.exp")
    End Sub
End Class
