using System;
using System.Windows.Forms;
using CapaDiseño;

namespace Estadistica
{
    public partial class FormEstadis : Form
    {   
        Diseño Diseño= new Diseño();
        public FormEstadis()
        {
            InitializeComponent(); 
            FormDatosAgurp formDatosAgrupados = new FormDatosAgurp();
            FormDatosD formDatosDesagru= new FormDatosD();
            try { Diseño.Diseños(this, formDatosAgrupados, formDatosDesagru,panelContenedor, panelHorizontal); }
            catch (Exception ex){MessageBox.Show($"Se produjo un error: {ex.Message}");}
        }

    }
}
