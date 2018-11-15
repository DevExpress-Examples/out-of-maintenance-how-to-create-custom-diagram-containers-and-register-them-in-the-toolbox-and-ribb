<!-- default file list -->
*Files to look at*:

* **[CustomContainers.xaml](./CS/DXDiagram.CreateCustomContainers/CustomContainers.xaml) (VB: [CustomContainers.xaml](./VB/DXDiagram.CreateCustomContainers/CustomContainers.xaml))**
* [MainWindow.xaml](./CS/DXDiagram.CreateCustomContainers/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXDiagram.CreateCustomContainers/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXDiagram.CreateCustomContainers/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXDiagram.CreateCustomContainers/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create custom diagram containers and register them in the toolbox and ribbon gallery


<p>In this example, we show how to create containers with custom headers and padding. <br>DiagramControl supports a special language for defining containers. The root element that contains a container description is <em>ContainerShapeTemplate</em>. This element describes a container contour and may contain several segments

* <em>Start</em>. Specifies the start point
* <em>Line</em>. Defines a line with start and end points
* <em>Arc</em>. Defines an arc with start and end points<br><br>To define a container's header editor position, use the EditorBounds property. To specify a padding, set the ActualPadding property.<br>To register custom containers in the ribbon gallery, use the DiagramContainerGalleryRegistrator.RegisterContainerShapes method.</p>

<br/>


