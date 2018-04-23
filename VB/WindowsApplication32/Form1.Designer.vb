Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication32
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.propertyDescriptionControl1 = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(13, 13)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(100, 20)
			Me.buttonEdit1.TabIndex = 0
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Location = New System.Drawing.Point(13, 40)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.SelectedObject = Me.buttonEdit1
			Me.propertyGridControl1.Size = New System.Drawing.Size(213, 274)
			Me.propertyGridControl1.TabIndex = 1
			Me.propertyGridControl1.ToolTipController = Me.toolTipController1
			' 
			' propertyDescriptionControl1
			' 
			Me.propertyDescriptionControl1.Location = New System.Drawing.Point(13, 320)
			Me.propertyDescriptionControl1.Name = "propertyDescriptionControl1"
			Me.propertyDescriptionControl1.PropertyGrid = Me.propertyGridControl1
			Me.propertyDescriptionControl1.Size = New System.Drawing.Size(213, 53)
			Me.propertyDescriptionControl1.TabIndex = 2
			Me.propertyDescriptionControl1.TabStop = False
			' 
			' toolTipController1
			' 
'			Me.toolTipController1.GetActiveObjectInfo += New DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(Me.toolTipController1_GetActiveObjectInfo);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(595, 385)
			Me.Controls.Add(Me.propertyDescriptionControl1)
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Controls.Add(Me.buttonEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private propertyDescriptionControl1 As DevExpress.XtraVerticalGrid.PropertyDescriptionControl
		Private WithEvents toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

