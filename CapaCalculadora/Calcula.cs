using System;
using System.Collections.Generic; 
using System.Windows.Forms;

namespace CapaCalculadora
{
    public class Calcula
    {
        public DataGridView dgvdatos { get; }
        public TextBox Res { get; }
        private string Operacion;

        public Calcula(DataGridView dgvDatos, string operacion, TextBox res)
        {
            dgvdatos = dgvDatos;
            Operacion = operacion;
            Res = res;
            Calculadora();
        }
        private void Calculadora()
        {
            switch (Operacion)
            {
                case "Media":
                   Res.Text= MEDIA();
                    break;
                case "Moda":
                    Res.Text = MODA();
                    break;
                case "Mediana":
                    Res.Text = MEDIANA();
                    break;
                case "DV":
                    Res.Text = DV();
                    break;
                case "CV":
                    Res.Text = CV();
                    break;
            }
        }
        private string MEDIA()
        {

            List<decimal> ListfrecAbsl;
            decimal frecAbso = 0;
            decimal valor=0; 
            for (int i = 0; i < dgvdatos.Rows.Count; i++)
            {
                valor = valor+(Convert.ToDecimal(dgvdatos.Rows[i].Cells[0].Value.ToString())) *(Convert.ToDecimal(dgvdatos.Rows[i].Cells[1].Value.ToString()));
            }
            (ListfrecAbsl, frecAbso) = FrecAbs();
            decimal media = valor/frecAbso;
            return media.ToString();
        }
        private string MODA()
        {
            decimal M;
            decimal Mmayor=0;
            List<string> resultados = new List<string>();
            for (int i = 0; i < dgvdatos.Rows.Count; i++)
            {
                M= Convert.ToDecimal(dgvdatos.Rows[i].Cells[1].Value.ToString()); 
                if (M > Mmayor)  Mmayor = M; 
            }
            for (int i = 0; i < dgvdatos.Rows.Count; i++)
            {
                M = Convert.ToDecimal(dgvdatos.Rows[i].Cells[1].Value.ToString());
                if (M == Mmayor) resultados.Add(dgvdatos.Rows[i].Cells[0].Value.ToString());
            }  
            return string.Join("- ", resultados);
        }
        private string MEDIANA()
        {

            List<decimal> ListfrecAbsl;
            decimal frecAbso = 0;
            int Mediana=0; 
            decimal s; 
            (ListfrecAbsl,frecAbso) = FrecAbs();
            decimal indice = frecAbso / 2;
            decimal diferenciaMinima = 99999;
            for (int i = 0; i < ListfrecAbsl.Count; i++)
            {
                s = Math.Abs(indice - ListfrecAbsl[i]);
                if (s < diferenciaMinima)
                {
                    diferenciaMinima = s;
                    Mediana = i;
                }
            }
           return dgvdatos.Rows[Mediana].Cells[0].Value.ToString();
        }
        private string DV()
        {
            double media;
            double valor = 0;
            List<decimal> ListfrecAbsl;
            decimal frecAbs = 0;
            (ListfrecAbsl, frecAbs) = FrecAbs();
            media = Convert.ToDouble(MEDIA());
            for (int i = 0; i < dgvdatos.Rows.Count; i++)
            {
                valor = valor + Math.Pow(Convert.ToDouble(dgvdatos.Rows[i].Cells[0].Value.ToString()) - media, 2) * (Convert.ToDouble(dgvdatos.Rows[i].Cells[1].Value.ToString()));
            }
            valor = valor / Convert.ToDouble(frecAbs);
            valor = Math.Sqrt(valor);
            return valor.ToString(); 
        }
        private string CV()
        {
            string DesV = DV();
            string Media= MEDIA();
            decimal result= Convert.ToDecimal(DesV)/Convert.ToDecimal(Media);
            return result.ToString();
        }

        private (List<decimal>, decimal) FrecAbs()
        {
            List<decimal> ListfrecA = new List<decimal>(); 
            int s;
            decimal FreAbs=0;
            for (int i = 0; i < dgvdatos.Rows.Count; i++)
            {
                s= Convert.ToInt32( dgvdatos.Rows[i].Cells[1].Value.ToString());
                FreAbs += s;
                ListfrecA.Add(FreAbs);
            }
            return (ListfrecA, FreAbs);
        }

        public static void Acomodador(DataGridView dgvDatos, MaskedTextBox valoragregado, MaskedTextBox Frecuancia = null)
        {
            if (Frecuancia == null)
            { //codigo para datos desagrupados 
                string valorX = valoragregado.Text;
                bool filaExiste = false;
                for (int i = 0; i < dgvDatos.Rows.Count; i++)
                {
                    string ContenidoCeldaX = Convert.ToString(dgvDatos.Rows[i].Cells[0].Value);
                    if (ContenidoCeldaX == valorX)
                    {
                        int ContenidoCeldaF = Convert.ToInt32(dgvDatos.Rows[i].Cells[1].Value.ToString());
                        ContenidoCeldaF = ContenidoCeldaF + 1;
                        dgvDatos.Rows[i].Cells[1].Value = ContenidoCeldaF.ToString();
                        filaExiste = true;
                        break;
                    }
                }
                if (!filaExiste)
                {
                    // Crea una nueva fila en el DataGridView
                    int nuevaFilaIndex = dgvDatos.Rows.Add(); // Agrega una nueva fila y obtiene su índice 
                    dgvDatos.Rows[nuevaFilaIndex].Cells[0].Value = valorX;
                    dgvDatos.Rows[nuevaFilaIndex].Cells[1].Value = 1;
                }
            }
            else //datos Agrupados
            {
                string valorX = valoragregado.Text;
                int frecuenciaNum = Convert.ToInt32(Frecuancia.Text);
                bool filaExiste = false;
                for (int i = 0; i < dgvDatos.Rows.Count; i++)
                {
                    string ContenidoCeldaX = Convert.ToString(dgvDatos.Rows[i].Cells[0].Value);
                    if (ContenidoCeldaX == valorX)
                    {
                        int ContenidoCeldaF = Convert.ToInt32(dgvDatos.Rows[i].Cells[1].Value.ToString());
                        frecuenciaNum = frecuenciaNum + ContenidoCeldaF;
                        dgvDatos.Rows[i].Cells[1].Value = frecuenciaNum.ToString();
                        filaExiste = true;
                        break;
                    }
                }
                if (!filaExiste)
                {
                    // Crea una nueva fila en el DataGridView
                    int nuevaFilaIndex = dgvDatos.Rows.Add(); // Agrega una nueva fila y obtiene su índice 
                    dgvDatos.Rows[nuevaFilaIndex].Cells[0].Value = valorX;
                    dgvDatos.Rows[nuevaFilaIndex].Cells[1].Value = Frecuancia.Text;
                }
            }
        }








    }
}
