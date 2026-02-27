using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaCalculadora;


namespace CapaDiseño
{
    public class Diseño
    {
        #region Estilo del form de inicio
        private Form _formulario;
        private Panel _panelContenedor;
        private Form _FormDatosAgurp;
        private Form _FormDatosDesagurp;
        public void Diseños(Form formulario, Form formDatosAgrupados, Form formDatosDesagrup, Panel PanelContenedor,Panel panelHorizontal)
        {
            _formulario = formulario;
            _FormDatosAgurp = formDatosAgrupados;
            _FormDatosDesagurp = formDatosDesagrup;
            _panelContenedor = PanelContenedor;
            Button bttnDatosAgurp = formulario.Controls["bttnDatosAgurp"] as Button;
            Button bttnDatosDesagurp = formulario.Controls["bttnDatosDesagurp"] as Button;
            PictureBox picBox_Min = panelHorizontal.Controls["picBox_Min"] as PictureBox;
            PictureBox picBxCerrar = panelHorizontal.Controls["picBxCerrar"] as PictureBox;

            if (bttnDatosAgurp != null)
            {
                bttnDatosAgurp.MouseEnter += bttn_MouseEnter;
                bttnDatosAgurp.MouseLeave += bttn_MouseLeave;
                bttnDatosAgurp.MouseDown += bttn_MouseDown;
                bttnDatosAgurp.Click += bttnA_CLick;
            }
            if (bttnDatosDesagurp != null)
            {
                bttnDatosDesagurp.MouseEnter += bttn_MouseEnter;
                bttnDatosDesagurp.MouseLeave += bttn_MouseLeave;
                bttnDatosDesagurp.MouseDown += bttn_MouseDown;
                bttnDatosDesagurp.Click += bttnA_CLick;
            }
            if (picBox_Min != null) picBox_Min.Click += iconminimizar_Click;
            if (picBxCerrar != null) picBxCerrar.Click += iconcerrar_Click;
        }
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            _formulario.WindowState = FormWindowState.Minimized;
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            _formulario.Close();
        }

        #endregion
        #region AbrirForms
        private void bttnA_CLick(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            if (bttn.Name== "bttnDatosAgurp")  AbrirFormHijo(_FormDatosAgurp);
            if (bttn.Name== "bttnDatosDesagurp") AbrirFormHijo(_FormDatosDesagurp);
        }
        private void AbrirFormHijo(object formHijo)
        {
            if (_panelContenedor.Controls.Count > 0)
                _panelContenedor.Controls.RemoveAt(0);
            Form Formhijo = formHijo as Form;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            _panelContenedor.Controls.Add(Formhijo);
            _panelContenedor.Tag = Formhijo;
            Formhijo.Show();
        }
        #endregion
  
        #region Estilo del form de Datos A/D
        private Form _formAD;
        private DataGridView _dtgDatos;
        private Button _bttnElimae;
        private Label _lblResultado;
        private TextBox _txtRes;
        private Chart _chartResultA;
        private Button _bttnCalcular;
        private Button _bttnNuevo;
        Button _bttnAñade;
        MaskedTextBox _mscraFre;
        MaskedTextBox _mscraX;
        public void DiseñoBotones(Form formulario)
        {
            _formAD = formulario;
            Button bttnMedia = formulario.Controls["bttnMedia"] as Button;
            Button bttnModa = formulario.Controls["bttnModa"] as Button;
            Button bttnMediana = formulario.Controls["bttnMediana"] as Button;
            Button bttnDV = formulario.Controls["bttnDV"] as Button;
            Button bttnCV = formulario.Controls["bttnCV"] as Button;
            _bttnAñade = formulario.Controls["bttnAñade"] as Button;
            _bttnCalcular = formulario.Controls["bttnCalcular"] as Button;
            _bttnNuevo = formulario.Controls["bttnNuevo"] as Button;
            //los clickeados
            _dtgDatos = formulario.Controls["dtgDatos"] as DataGridView;
            _bttnElimae = formulario.Controls["bttnElimae"] as Button;
            _lblResultado = formulario.Controls["lblResultado"] as Label;
            _txtRes = formulario.Controls["txtRes"] as TextBox;
            _chartResultA = formulario.Controls["chartResultA"] as Chart;
            AgrupadoDesagrupado(formulario);



            botonClickeado(bttnMedia);
            botonClickeado(bttnModa);
            botonClickeado(bttnMediana);
            botonClickeado(bttnDV);
            botonClickeado(bttnCV);

           
            if (_bttnCalcular != null) _bttnCalcular.Click += bttnCalcular_Click;
            if (_bttnNuevo != null) _bttnNuevo.Click += bttnNuevo_Click;
            if (_bttnElimae != null) _bttnElimae.Click += bttnElimae_Click;

        }

        private void mensje(object sender, EventArgs e)
        {
            MaskedTextBox mscra = sender as MaskedTextBox;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Solo se puede calcular hasta el número 99999.", mscra,new Point(0, mscra.Height+2) , 2000);
        }

        private void AgrupadoDesagrupado (Form formulario)
        {
            if (formulario.Name == "FormDatosAgurp")
            {
                _mscraX = formulario.Controls["mscraX"] as MaskedTextBox;
                _mscraFre = formulario.Controls["mscraFre"] as MaskedTextBox;
                _mscraX.MouseEnter += mensje;
                _mscraFre.MouseEnter += mensje;
                if (_bttnAñade != null) _bttnAñade.Click += bttnAñadeA_Click;
            }
            else
            {
                _mscraX = formulario.Controls["mscraX"] as MaskedTextBox;
                _mscraX.MouseEnter += mensje;
                if (_bttnAñade != null) _bttnAñade.Click += bttnAñadeD_Click;
            }
        }
        private void botonClickeado (Button button)
        {
            button.Name = "button";
            if (button != null)
            {
                button.MouseEnter += bttn_MouseEnter;
                button.MouseLeave += bttn_MouseLeave;
                button.MouseDown += bttn_MouseDown;
            }
        }
        #endregion

        #region Añadir, calcula, borrar fila del datagridview
        private void bttnAñadeA_Click(object sender, EventArgs e)
        {
            if (_mscraX.Text != "" && _mscraFre.Text != "")
            {
                Calcula.Acomodador(_dtgDatos, _mscraX, _mscraFre);
                _dtgDatos.Visible = true;
                _bttnElimae.Visible = true;
                _bttnCalcular.Visible = true;
                //limpiar el MaskedTextBox después de guardar
                _mscraX.Clear();
                _mscraFre.Clear();
            }
        }
        private void bttnAñadeD_Click (object sender, EventArgs e)
        {
            if (_mscraX.Text != "")
            {
                Calcula.Acomodador(_dtgDatos, _mscraX);
                _dtgDatos.Visible = true;
                _bttnElimae.Visible = true;
                _bttnCalcular.Visible = true;
                //limpiar el MaskedTextBox después de guardar
                _mscraX.Clear();
            }
        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
            _lblResultado.Visible = true;
            _txtRes.Visible = true;
            _bttnNuevo.Visible = true;
            if (_chartResultA.ChartAreas.Count>0)
            {
                _chartResultA.ChartAreas.Clear();
                _chartResultA.Series.Clear();
            }
            // Inicializar el Chart
            _chartResultA.ChartAreas.Add(new ChartArea("Area1"));
            _chartResultA.Series.Add(new Series("Serie1"){ ChartType = SeriesChartType.Doughnut });

            // Rellenar el Chart con los valores del DataGridView
            foreach (DataGridViewRow row in _dtgDatos.Rows)
            {
                if (!row.IsNewRow) // Ignorar la fila nueva
                {
                    double ejeX = Convert.ToDouble(row.Cells[0].Value);
                    double ejeY = Convert.ToDouble(row.Cells[1].Value);
                    _chartResultA.Series["Serie1"].Points.AddXY(ejeX, ejeY);
                }
            }
            _chartResultA.Visible = true;
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            _lblResultado.Visible = false;
            _txtRes.Visible = false;
            _bttnNuevo.Visible = false;
            _chartResultA.Visible = false;
            _dtgDatos.Visible = false;
            _bttnElimae.Visible = false;
            _bttnCalcular.Visible = false;
            _dtgDatos.Rows.Clear();
        }
        private void bttnElimae_Click(object sender, EventArgs e)
        {   // Verifica si hay una fila seleccionada
            if (_dtgDatos.CurrentRow != null)  _dtgDatos.Rows.Remove(_dtgDatos.CurrentRow);
        }

        #endregion

        #region sombreado
        Panel P1 = new Panel();
        Panel P2 = new Panel();
        private void bttn_MouseEnter(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            if (bttn.Name == "button")
            {
                _formAD.Controls.Add(P1);
                P1.BackColor = Color.FromArgb(255, 255, 255);
                P1.Size = new Size(bttn.Size.Width, 5);
                P1.Location = new Point(bttn.Location.X, bttn.Location.Y + bttn.Size.Height);
            }
            else
            {
                _formulario.Controls.Add(P1);
                P1.BackColor = Color.FromArgb(255, 255, 255);
                P1.Size = new Size(bttn.Size.Width, 5);
                P1.Location = new Point(bttn.Location.X, bttn.Location.Y + bttn.Size.Height);
            }
        }
        private void bttn_MouseLeave(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            if (bttn.Name == "button") _formAD.Controls.Remove(P1);
            else  _formulario.Controls.Remove(P1);
        }
        private void bttn_MouseDown(object sender, MouseEventArgs e)
        { 
            Button bttn = sender as Button;
            if (bttn.Name == "button")
            {
                if (_formAD.Controls.Contains(P2)) _formAD.Controls.Remove(P2);
                _formAD.Controls.Add(P2);
                P2.BackColor = Color.FromArgb(255, 255, 255);
                P2.Size = new Size(bttn.Size.Width, 5);
                P2.Location = new Point(bttn.Location.X, bttn.Location.Y + bttn.Size.Height);
            }
            else
            {
             if (_formulario.Controls.Contains(P2))  _formulario.Controls.Remove(P2);
            _formulario.Controls.Add(P2);
            P2.BackColor = Color.FromArgb(255, 255, 255);
            P2.Size = new Size(bttn.Size.Width, 5);
            P2.Location = new Point(bttn.Location.X, bttn.Location.Y + bttn.Size.Height);               
            }

        }
        #endregion

    }
}
