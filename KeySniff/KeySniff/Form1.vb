Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Text
Public Class Form1
    Dim tcp As New TcpClient
    Dim ns As NetworkStream
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tcp = New TcpClient
        Try
            tcp.Connect(TextBox1.Text, TextBox2.Text)
            ns = tcp.GetStream
            MessageBox.Show("Connect Successfly....")
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
        Catch
            MessageBox.Show("Connect Fail....")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tcp.Close()
        ns.Close()
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim com As Byte() = Encoding.ASCII.GetBytes("dump")
            ns.Write(com, 0, com.Length)
            ns.Flush()
            Dim read As Byte() = New Byte(1000) {}
            ns.Read(read, 0, read.Length)
            ns.Flush()
            Dim msg As String = Encoding.ASCII.GetString(read)
            RichTextBox1.Text += msg
            ns.Flush()
        Catch
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        TextBox3.Text = My.Computer.FileSystem.SpecialDirectories.Desktop + "\" + "log.txt"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IO.File.WriteAllText(TextBox3.Text, RichTextBox1.Text + vbCrLf)
        MessageBox.Show("Save Log Successfly Path: " + TextBox3.Text)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RichTextBox1.Text = ""
    End Sub
End Class
