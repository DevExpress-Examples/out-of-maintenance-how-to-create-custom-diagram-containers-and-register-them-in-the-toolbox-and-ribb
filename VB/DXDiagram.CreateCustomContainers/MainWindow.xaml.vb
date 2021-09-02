Imports DevExpress.Diagram.Core
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace DXDiagram.CreateCustomContainers
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Private Const MyContainersStencilName As String = "MyContainers"
		Private Shared ReadOnly containerDescriptions() As ContainerShapeDescription
		Shared Sub New()
			Dim customContainersDictionary = New ResourceDictionary() With {.Source = New Uri("CustomContainers.xaml", UriKind.Relative)}
			containerDescriptions = ShapeDescriptions.LoadDescriptionsFromDictionary(customContainersDictionary).OfType(Of ContainerShapeDescription)().ToArray()
			DiagramContainerGalleryRegistrator.RegisterContainerShapes(containerDescriptions)
		End Sub

		Public Sub New()
			InitializeComponent()
			Dim customContainersStencil = DiagramStencil.Create(MyContainersStencilName, "Custom Containers", containerDescriptions)
			diagramControl.Stencils = New DiagramStencilCollection(DiagramToolboxRegistrator.Stencils.Concat( { customContainersStencil }))
			diagramControl.SelectedStencils = New StencilCollection(MyContainersStencilName, BasicShapes.StencilId)
		End Sub
	End Class
End Namespace
