Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO

Module ImageFileHandler

    Public Function handleImageSelection(ByRef data As Dictionary(Of String, Object), prefix As String) As Boolean

        Dim selectedImage As New OpenFileDialog()
        selectedImage.InitialDirectory = "C:\Users\i\OneDrive\Pictures"
        selectedImage.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*"

        If selectedImage.ShowDialog() = DialogResult.Cancel Then Return 0

        Dim selectedFilePath As String = selectedImage.FileName

        Dim file_ext As String = $"{selectedImage.SafeFileName.Substring(selectedImage.SafeFileName.LastIndexOf("."))}"
        Dim destinationFolder As String = $"./images/{prefix}"
        Dim newFileName As String = $"{prefix}_{data("id")}{file_ext}"
        Dim destinationFilePath As String = $"./images/{prefix}/{newFileName}"

        'Dim log As String = $"
        '         Name: {selectedImage.SafeFileName}
        '         Size: {selectedImage.SafeFileName.Length}
        '         Path: {selectedFilePath} 
        '         Extension: {selectedImage.SafeFileName.Substring(selectedImage.SafeFileName.LastIndexOf("."))}

        '         destinationFolder: {destinationFolder}
        '         New Name: {prefix}_{data("id")}
        '         destinationFilePath: {destinationFilePath}

        '"
        'MsgBox(log)

        Try
            Using sourceStream As New FileStream(selectedFilePath, FileMode.Open, FileAccess.Read)
                Using destinationStream As New FileStream(destinationFilePath, FileMode.Create, FileAccess.Write)
                    sourceStream.CopyTo(destinationStream)
                    selectedImage.Dispose()
                End Using
            End Using
            data("image_dir") = destinationFilePath

        Catch ex As Exception
            MsgBox("Error copying and renaming the image: " & ex.Message, MsgBoxStyle.Exclamation, "Image Error")
            Return -1
        End Try
        Return 1
    End Function
End Module
