using CapaDiseño;
using System;
using System.Collections.Generic;
using CapaCalculadora;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class FormDatosAgurp : Form
    {
        Diseño Diseño = new Diseño();
        string operacion = "";
        public FormDatosAgurp()
        {
            InitializeComponent();
            Diseño.DiseñoBotones(this);
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            if (operacion != "")
            {
                errorP.Clear();
                Calcula capacalcu = new Calcula(dtgDatos, operacion, txtRes);
            } else
            {
                errorP.SetError(bttnCalcular, "Le falta seleccionar la operacion que desea calcular.");
            }
        }

        private void bttnCV_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            operacion = bt.Text;  
        }

        private void mscraFre_MouseClick(object sender, MouseEventArgs e)
        {
            mscraFre.Select(0, 0);
        }
    }
}
