using DevExpress.Diagram.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DXDiagram.CreateCustomContainers {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        const string MyContainersStencilName = "MyContainers";
        static readonly ContainerShapeDescription[] containerDescriptions;
        static MainWindow() {
            var customContainersDictionary = new ResourceDictionary() { Source = new Uri("CustomContainers.xaml", UriKind.Relative) };
            containerDescriptions = ShapeDescriptions.LoadDescriptionsFromDictionary(customContainersDictionary).OfType<ContainerShapeDescription>().ToArray();
            DiagramContainerGalleryRegistrator.RegisterContainerShapes(containerDescriptions);
        }

        public MainWindow() {
            InitializeComponent();
            var customContainersStencil = DiagramStencil.Create(MyContainersStencilName, "Custom Containers", containerDescriptions);
            diagramControl.Stencils = new DiagramStencilCollection(DiagramToolboxRegistrator.Stencils.Concat(new[] { customContainersStencil }));
            diagramControl.SelectedStencils = new StencilCollection(MyContainersStencilName, BasicShapes.StencilId);
        }
    }
}
