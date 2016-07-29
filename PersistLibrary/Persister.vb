Imports System.IO
Imports System.Threading

Public Module Persister

    Public Sub Persist(processName As String, processPath As String, Optional sleepInterval As Int32 = 100)
        While (True)
            Try
                Dim d = New List(Of String)()
                For Each p As Process In Process.GetProcesses()
                    d.Add(p.ProcessName.ToLowerInvariant())
                Next
                If Not d.Contains(processName.ToLowerInvariant()) Then
                    If File.Exists($"{processPath}\{processName}.exe")
                        Dim info As New ProcessStartInfo($"{processPath}\{processName}.exe")
                        info.UseShellExecute = True
                        info.CreateNoWindow = False
                        info.WindowStyle = ProcessWindowStyle.Normal
                        Process.Start(info)
                    End If
                End If
                d.Clear()
                Thread.Sleep(sleepInterval)
            Catch
            End Try
        End While
    End Sub
End Module
