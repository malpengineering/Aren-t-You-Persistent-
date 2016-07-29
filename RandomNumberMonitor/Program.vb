Imports System.Threading
Imports PersistLibrary

Module Program
    
    Dim ReadOnly _rand As New Random()

    Sub Main()
        Task.Factory.StartNew(Sub() DoWork())
        Task.Factory.StartNew(Sub() DoMonitor())
        While (True)
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub DoWork()
        Console.WriteLine("Hello from RandomNumberMonitor")
        While (true)
            Console.WriteLine(_rand.Next())
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub DoMonitor()
        Persist("RandomNumber", "C:\projects\arent-you-persistent\RandomNumber\bin\Debug")
    End Sub

End Module
