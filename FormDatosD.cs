using CapaCalculadora;
using CapaDiseño;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class FormDatosD : Form
    {
        Diseño Diseño = new Diseño();
        string operacion = "";
        public FormDatosD()
        {
            InitializeComponent();
            Diseño.DiseñoBotones(this);
        }

        private void bttnCalcular_Click(object sender, System.EventArgs e)
        {
            if (operacion != "")
            {
                errorP.Clear();
                Calcula capacalcu = new Calcula(dtgDatos, operacion, txtRes);
            }
            else errorP.SetError(bttnCalcular, "Le falta seleccionar la operacion que desea calcular.");
        }

        private void bttnCV_Click(object sender, System.EventArgs e)
        {
            Button bt = sender as Button;
            operacion = bt.Text;
        }

        private void mscraX_MouseClick(object sender, MouseEventArgs e)
        {
            mscraX.Select(0, 0);
        }
    }
}
