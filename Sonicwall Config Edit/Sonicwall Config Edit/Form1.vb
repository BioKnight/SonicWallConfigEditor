Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sonic As New Sonicwall_Functions
        sonic.read("C:\Users\rmiller\source\repos\SonicWallConfigEditor\Sonicwall Config Edit\Sonicwall Config Edit\BZ.qca956x.v3.9.54.9373.180914.0009.bin")
    End Sub
End Class
