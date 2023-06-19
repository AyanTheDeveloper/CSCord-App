Imports System.Windows.Forms

Public Class ErrorHelper
    Sub ShowMb()
        Try
            MessageBox.Show("There was an error!", "Error Helper")
        Catch ex As Exception
            Debug.Write("Unable to show MessageBox!")

        End Try


    End Sub

End Class