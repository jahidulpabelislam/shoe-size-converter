Module MsgB
    Sub msg()
        'this opens the help form
        Dim oForm As Helpform
        oForm = New Helpform
        oForm.Show()
        oForm = Nothing
    End Sub
End Module
