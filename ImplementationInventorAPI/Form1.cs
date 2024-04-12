
using Inventor;

namespace ImplementationInventorAPI
{
    public partial class Form1 : Form
    {


        // Accessing API of Autodesk Inventor.
        Inventor.Application inventorApplication;
        public Form1()
        {
            InitializeComponent();
        }
        // Button makes the connection to the Autodesk Inventor.
        private void connect_Click(object sender, EventArgs e)
        {
            try
            {   
                //Connecting and opening Autodesk Inventor.
                inventorApplication = (Inventor.Application)System.Activator.CreateInstance(System.Type.GetTypeFromProgID("Inventor.Application")) as Inventor.Application;
                inventorApplication.Visible = true;
                MessageBox.Show("Connected Successfully.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error connecting to Inventor: " + ex.Message);
            }

        }


        // Button add extrusion to shape that is defined.
        private void extrude_Click(object sender, EventArgs e)
        {
            // Create a document
            PartDocument docPart = (PartDocument)inventorApplication.Documents.Add(DocumentTypeEnum.kPartDocumentObject, inventorApplication.FileManager.GetTemplateFile(DocumentTypeEnum.kPartDocumentObject));
           
            // Definition of Document created
            PartComponentDefinition partDefinition = docPart.ComponentDefinition;
           
            //Adding plan
            PlanarSketch sketch = partDefinition.Sketches.Add(partDefinition.WorkPlanes[3]);
            
            //Settin up the Geometry
            TransientGeometry geometry = inventorApplication.TransientGeometry;
            
            //Defining some points
            Point2d point1 = geometry.CreatePoint2d(20, 40);
            Point2d point2 = geometry.CreatePoint2d(30,60);
            Point2d centerPoint = geometry.CreatePoint2d(50, 50);
           
            // Sketching the shape
            SketchCircle circle = sketch.SketchCircles.AddByCenterRadius(centerPoint, 10);

            Profile profile = sketch.Profiles.AddForSolid();
           
            // Defining extrusion
            ExtrudeDefinition extrudeDefinition =partDefinition.Features.ExtrudeFeatures.CreateExtrudeDefinition(profile, PartFeatureOperationEnum.kJoinOperation);

            extrudeDefinition.SetDistanceExtent(4,PartFeatureExtentDirectionEnum.kNegativeExtentDirection);
           
            // Extrude feature
            ExtrudeFeature extrudeFeature = partDefinition.Features.ExtrudeFeatures.Add(extrudeDefinition);




        
        
        
        
        }
    }
}
