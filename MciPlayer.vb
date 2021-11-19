Imports System.Text
Imports System.Runtime.InteropServices

Namespace VideoHandle
	Class MciPlayer
		<DllImport("winmm.dll")>
		Private Shared Function mciSendString(strCommand As [String], strReturn As StringBuilder, iReturnLength As Integer, hwndCallback As IntPtr) As Integer
		End Function
		<DllImport("winmm.dll")>
		Public Shared Function mciGetErrorString(errCode As Integer, errMsg As StringBuilder, buflen As Integer) As Integer
		End Function
		<DllImport("winmm.dll")>
		Public Shared Function mciGetDeviceID(lpszDevice As String) As Integer
		End Function

		Public Const WS_CHILD As Integer = &H40000000

		Public Sub New()
		End Sub

		Public Function MCISendString(Pcommand As String) As String
			Dim sb As New StringBuilder(1024)
			Dim ret As Integer = mciSendString(Pcommand, sb, sb.Capacity, IntPtr.Zero)
			If ret = 0 Then
				Return sb.ToString()
			Else
				mciGetErrorString(ret, sb, sb.Capacity)
				Return sb.ToString()
			End If
		End Function
	End Class
End Namespace