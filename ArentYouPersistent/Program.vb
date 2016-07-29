Module Program

    Sub Main()
        Console.WriteLine("Hello World!")
        Console.WriteLine("Starting RandomNumberMonitor...")
        LaunchProcess("C:\projects\arent-you-persistent\RandomNumberMonitor\bin\Debug", "RandomNumberMonitor")
    End Sub

    Private Sub LaunchProcess(processPath As String, processName As String)
        Dim info As New ProcessStartInfo($"{processPath}\{processName}.exe")
        info.UseShellExecute = True
        info.CreateNoWindow = False
        info.WindowStyle = ProcessWindowStyle.Normal
        Process.Start(info)
    End Sub

End Module
