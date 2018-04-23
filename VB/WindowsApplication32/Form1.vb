Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid

Namespace WindowsApplication32
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles toolTipController1.GetActiveObjectInfo
			If Object.ReferenceEquals(e.SelectedControl, propertyGridControl1) Then
				Dim hitInfo As VGridHitInfo = propertyGridControl1.CalcHitInfo(e.ControlMousePosition)
				If hitInfo.Row IsNot Nothing Then
					Dim pd As PropertyDescriptor = propertyGridControl1.GetPropertyDescriptor(hitInfo.Row)
					If pd IsNot Nothing Then
						Dim o As Object = pd
						Dim description As String = String.Empty
						If String.IsNullOrEmpty (pd.Description) Then
							description = "No description available"
						Else
							description = pd.Description
						End If
						e.Info = New DevExpress.Utils.ToolTipControlInfo(o, description)
					End If
				End If
			End If
		End Sub

	End Class
End Namespace