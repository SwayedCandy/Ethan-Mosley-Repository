Imports System.Collections.ObjectModel

Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim splashScreen As New SplashScreenForm()
            splashScreen.Show()
        End Sub
    End Class
End Namespace



