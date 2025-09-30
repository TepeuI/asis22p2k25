using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class Ejecucion_Navegador : Form
    {
        public Ejecucion_Navegador()
        {
            InitializeComponent();
            //parametros para navegador
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                ColorFondo = Color.White,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_empleados"
            };
            string[] columnas = {
                        "pelicula",
                        "id_pelicula",
                        "nombre",
                        "clasificacion",
                        "idioma",
                        "Subtitulado",
                        "genero"
                    };
            
            int ide_usuario = 10;
            int idAplicacion = 6;
            navegador1.Fk_Usuario = ide_usuario;
            navegador1.Fk_Aplicacion = idAplicacion;
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.mostrarDatos();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            CapaVista_Menu.MenuGeneral nav = new CapaVista_Menu.MenuGeneral();
            nav.ShowDialog();
        }
    }
}
