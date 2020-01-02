Imports System.Convert
Imports System.IO
Imports System.Text
Public Class Sonicwall_Functions
    Private enc8 As Encoding = Encoding.UTF8
    'Export the settings from System > Settings
    'Open the file 
    'remove the two &'s at the end of the file.
    'Run certutil -decode originalFile.exp decodedFile.txt changing out the file names With the appropriate ones.
    ' ^ This should be system.convert.frombase64string
    'You should see a message “decode command completed successfully” printed To CMD.
    'Open decoded file
    'Replace All “&” With “\n”
    Public Function read(file As String)
        Return breakUpLines(decode(readfile(file)))
    End Function
    Private Function readfile(path) As Byte()
        Return File.ReadAllBytes(path)
    End Function

    Private Function decode(bytes As Byte()) As String
        Dim strStart As String = enc8.GetString(bytes)
        strStart = strStart.Replace("&&", "")
        Dim bytDecoded As Byte() = FromBase64String(strStart)
        Dim strDecoded As String = enc8.GetString(bytDecoded)
        Return strDecoded
    End Function

    Function breakUpLines(config As String) As String
        Return config.Replace("&", vbCrLf)
    End Function
End Class
