using System;
using System.Windows.Forms;

namespace registerPeople
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double CalcularPromedio(int[] calificaciones)
        {
            double promedio = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                promedio += calificaciones[i];
            }
            return promedio / calificaciones.Length;
        }

        public double CalcularPromedioGeneral()
        {
            double promediogeneral = 0;
            for (int i = 0; i < dgvInfo.Rows.Count; i++)
            {
                promediogeneral += Convert.ToInt32(dgvInfo.Rows[i].Cells[4].Value);
            }
            return promediogeneral / (dgvInfo.Rows.Count - 1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreAlumno;
            int calif1, calif2, calif3;
            
            nombreAlumno = txtNombreAlumno.Text;
            calif1 = Convert.ToInt32(txtCalif1.Text);
            calif2 = Convert.ToInt32(txtCalif2.Text);
            calif3 = Convert.ToInt32(txtCalif3.Text);

            int[] calificaciones = { calif1, calif2, calif3 };
            dgvInfo.Rows.Add(nombreAlumno, calif1, calif2, calif3, CalcularPromedio(calificaciones));

            txtNombreAlumno.Clear();
            txtCalif1.Clear();
            txtCalif2.Clear();
            txtCalif3.Clear();
        }

        private void btnCalcularPromedioGeneral_Click(object sender, EventArgs e)
        {
            txtPromedioGeneral.Text = Convert.ToString(CalcularPromedioGeneral());
        }
    }
}
