using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfazhospital
{
    public partial class Form2 : Form
    {
        private class Especialidad
        {
            public string Nombre { get; set; }
            public List<string> Doctores { get; set; }
        }

        private List<Especialidad> especialidades;

        public Form2()
        {
            InitializeComponent();

            btnAgendarCita.Enabled = false;

            especialidades = new List<Especialidad>
            {
                new Especialidad { Nombre = "Selecciona una especialidad", Doctores = new List<string> { "" } },
                new Especialidad { Nombre = "Dermatología", Doctores = new List<string> { "Dra. Ana", "Dr. Juan", "Dr. Carlos" } },
                new Especialidad { Nombre = "Cardiología", Doctores = new List<string> { "Dr. David", "Dr. Paul", "Dra. Paula" } },
                new Especialidad { Nombre = "Pediatría", Doctores = new List<string> { "Dr. Ricardo", "Dra. Guadalupe", "Dr. Samuel" } },
                new Especialidad { Nombre = "Psicología", Doctores = new List<string> { "Dr. Gonzalo", "Dr. Roberto", "Dr. Andres" } }
            };

            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.DisplayMember = "Nombre";
            cmbDoctores.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Especialidad especialidadSeleccionada = cmbEspecialidades.SelectedItem as Especialidad;

            cmbDoctores.Enabled = true;
            cmbDoctores.DataSource = especialidadSeleccionada.Doctores;
        }


        private void cmbDoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doctorSeleccionado = cmbDoctores.SelectedItem.ToString();

            List<DateTime> fechasDisponibles = new List<DateTime>
            {
                DateTime.Today.AddDays(2),
                DateTime.Today.AddDays(5),
                DateTime.Today.AddDays(10)
            };

            disponibilidadDoctores[doctorSeleccionado] = fechasDisponibles;

            ActualizarFechasDisponibles();
            btnAgendarCita.Enabled = true;
        }

        private void ActualizarFechasDisponibles()
        {
            monthCalendar1.RemoveAllBoldedDates();

            if (cmbDoctores.SelectedItem == null)
                return;

            string doctorSeleccionado = cmbDoctores.SelectedItem.ToString();

            if (disponibilidadDoctores.ContainsKey(doctorSeleccionado))
            {
                foreach (DateTime fechaDisponible in disponibilidadDoctores[doctorSeleccionado])
                {
                    monthCalendar1.AddBoldedDate(fechaDisponible);
                }
            }

            monthCalendar1.UpdateBoldedDates();
            btnAgendarCita.Enabled = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            ActualizarFechasDisponibles();
        }

        private Dictionary<string, List<DateTime>> disponibilidadDoctores = new Dictionary<string, List<DateTime>>();

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            string especialidadSeleccionada = cmbEspecialidades.SelectedItem.ToString();
            string doctorSeleccionado = cmbDoctores.SelectedItem.ToString();
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;

            string mensaje = $"Has agendado una cita con el/la {doctorSeleccionado} en {especialidadSeleccionada} el {fechaSeleccionada:d}";

            MessageBox.Show(mensaje, "Cita Agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
