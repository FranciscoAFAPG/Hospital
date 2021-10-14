using proyecto_bases.Logica;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace proyecto_bases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desingApp();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private Form activeForm = null;
        public void abrirModulos(Form modulo)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = modulo;
            modulo.TopLevel = false;
            modulo.FormBorderStyle = FormBorderStyle.None;
            modulo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(modulo);
            panelContenido.Tag = modulo;
            modulo.BringToFront();
            modulo.Show();
        }
        private void desingApp()
        {
            subMenuPersonal.Visible = false;
            submenuGestionPacientes.Visible = false;
            submenuGestionEmpleados.Visible = false;
        }
        private void hideSubmenu()
        {
            if (subMenuPersonal.Visible == true)
                subMenuPersonal.Visible = false;
            if (submenuGestionEmpleados.Visible == true)
                submenuGestionEmpleados.Visible = false;
            if (submenuGestionPacientes.Visible == true)
                submenuGestionPacientes.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnPersonalHospital_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPersonal);
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            abrirModulos(new medicos());
            hideSubmenu();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            abrirModulos(new empleados());
            hideSubmenu();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuGestionPacientes);
        }

        private void btnListadoPacientes_Click(object sender, EventArgs e)
        {
            abrirModulos(new listadoPacientes());
            hideSubmenu();
        }

        private void btnGestionPacientes_Click(object sender, EventArgs e)
        {
            abrirModulos(new pacientes());
            hideSubmenu();
        }

        private void btnDiagnosticoPaciente_Click(object sender, EventArgs e)
        {
            abrirModulos(new diagnosticoPaciente());
            hideSubmenu();
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(submenuGestionEmpleados);
        }

        private void btnDisponibilidadMedicos_Click(object sender, EventArgs e)
        {
            abrirModulos(new disponibilidadMedicos());
            hideSubmenu();
        }

        private void btnVacacionesEmpleados_Click(object sender, EventArgs e)
        {
            abrirModulos(new vacacionesEmpleados());
            hideSubmenu();
        }

        private void btnSustitucionesEmpleado_Click(object sender, EventArgs e)
        {
            abrirModulos(new sustitucionesEmpleados());
            hideSubmenu();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarVacaciones_Click(object sender, EventArgs e)
        {
            abrirModulos(new agregarVacaciones());
            hideSubmenu();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarSustitucion_Click(object sender, EventArgs e)
        {
            abrirModulos(new agregarSustitucion());
            hideSubmenu();
        }

        private void btnAsignarHorario_Click(object sender, EventArgs e)
        {
            abrirModulos(new asignarHorario());
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirModulos(new exempleados());
        }

        private void btnAgregarDiagnostico_Click(object sender, EventArgs e)
        {
            abrirModulos(new agregarDiagnostico());
            hideSubmenu();
        }
    }
}
