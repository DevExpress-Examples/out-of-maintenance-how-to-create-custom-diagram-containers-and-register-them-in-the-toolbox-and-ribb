<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T466430)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF DiagramControl - Create Custom Diagram Containers

This example uses the `ContainerShapeTemplate` class to create custom diagram containers and displays these containers in the [Shapes Panel](https://docs.devexpress.com/WPF/116504/controls-and-libraries/diagram-control/diagram-designer-control/shapes-panel) and **Container**/**List** [Ribbon](https://docs.devexpress.com/WPF/116507/controls-and-libraries/diagram-control/diagram-designer-control/ribbon) galleries.

![image](https://github.com/DevExpress-Examples/wpf-diagram-create-custom-diagram-containers/assets/65009440/9440ef5a-97b3-4cbf-bfd0-f000b7918b41)

Call the `DiagramContainerGalleryRegistrator.RegisterContainerShapes` method to register custom containers in the ribbon gallery.

## Files to Review

* [CustomContainers.xaml](./CS/DXDiagram.CreateCustomContainers/CustomContainers.xaml) (VB: [CustomContainers.xaml](./VB/DXDiagram.CreateCustomContainers/CustomContainers.xaml))
* [MainWindow.xaml.cs](./CS/DXDiagram.CreateCustomContainers/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXDiagram.CreateCustomContainers/MainWindow.xaml.vb))

## Documentation

* [Use Shape Templates to Create Shapes and Containers](https://docs.devexpress.com/WPF/117037/controls-and-libraries/diagram-control/diagram-items/creating-shapes-and-containers-using-shape-templates)
* [Containers and Lists](https://docs.devexpress.com/WPF/117205/controls-and-libraries/diagram-control/diagram-items/containers)

## More Examples

* [WPF DiagramControl - Create Custom Shapes Based on Diagram Containers](https://github.com/DevExpress-Examples/wpf-diagram-create-custom-shapes-based-on-diagram-containers)
* [WPF DiagramControl - Create Rotatable Containers with Shapes](https://github.com/DevExpress-Examples/wpf-diagram-create-rotatable-containers-with-shapes)
* [WPF DiagramControl - Proportionally Resize Shapes Within the Parent Container](https://github.com/DevExpress-Examples/wpf-diagram-proportionally-resize-shapes-within-container)
