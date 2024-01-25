Imports DevExpress.Diagram.Core
Imports System
Imports System.Linq
Imports System.Windows

Namespace DXDiagram.CreateCustomContainers

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Const MyContainersStencilName As String = "MyContainers"

        Private Shared ReadOnly containerDescriptions As ContainerShapeDescription()

        Shared Sub New()
            Dim customContainersDictionary = New ResourceDictionary() With {.Source = New Uri("CustomContainers.xaml", UriKind.Relative)}
            containerDescriptions = ShapeDescriptions.LoadDescriptionsFromDictionary(customContainersDictionary).OfType(Of ContainerShapeDescription)().ToArray()
            Call DiagramContainerGalleryRegistrator.RegisterContainerShapes(containerDescriptions)
        End Sub

        Public Sub New()
            Me.InitializeComponent()
            Dim customContainersStencil = DiagramStencil.Create(MyContainersStencilName, "Custom Containers", containerDescriptions)
            Me.diagramControl.Stencils = New DiagramStencilCollection(DiagramToolboxRegistrator.Stencils.Concat({customContainersStencil}))
            Me.diagramControl.SelectedStencils = New StencilCollection(MyContainersStencilName, BasicShapes.StencilId)
        End Sub
    End Class
End Namespace
