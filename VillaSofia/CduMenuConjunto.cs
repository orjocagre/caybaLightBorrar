using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace VillaSofia
{
    public partial class CduMenuConjunto : UserControl
    {
        VillaSofia vs;
        int idConjunto;
        Boolean inventarioInicialGuardado;
        Boolean inventarioFinalGuardado;
        int idInventarioInicial;
        int idInventarioFinal;
        public CduMenuConjunto(VillaSofia vs, int idConjunto)
        {
            this.vs = vs;
            idInventarioInicial = idInventarioFinal = -1;
            inventarioInicialGuardado = inventarioFinalGuardado = false;
            this.idConjunto = idConjunto;
            InitializeComponent();
            buscarInventarioInicial();
            establecerTxtFecha();
            this.Dock = DockStyle.Fill;
        }
       
        public CduMenuConjunto(VillaSofia vs)
        {
            this.vs = vs;
            idInventarioInicial = idInventarioFinal = -1;
            inventarioInicialGuardado = inventarioFinalGuardado = false;
            InitializeComponent();
            establecerConjunto();
            buscarInventarioInicial();
            establecerTxtFecha();
            this.Dock = DockStyle.Fill;
        }
        void establecerTxtFecha()
        {
            ClsLogicaConjunto conjunto = new ClsLogicaConjunto();
            lblFecha.Text = conjunto.buscarFechaConjunto(idConjunto);
        }
        void establecerConjunto()
        {
            ClsLogicaConjunto conjunto = new ClsLogicaConjunto();
            idConjunto = conjunto.agregarConjunto(DateTime.Now);
            
        }
        void buscarInventarioInicial()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            idInventarioInicial = inventario.buscarInventario(idConjunto, 1);
            if (idInventarioInicial != -1)
            {
                //fechaInventario = inventario.fechaInventario(idInventarioInicial);
                inventarioInicialGuardado = true;
                buscarInventarioFinal();
            }
            else
            {
                idInventarioFinal = -1;
            }
        }
        void buscarInventarioFinal()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            idInventarioFinal = inventario.buscarInventario(idConjunto, 0);
            if (idInventarioFinal != -1)
            {
                inventarioFinalGuardado = true;
            }
        }

        private void btnInventarioInicial_Click(object sender, EventArgs e)
        {
            CduInventarioInicial inventario = new CduInventarioInicial(vs,idConjunto,1,idInventarioInicial,inventarioInicialGuardado);
            this.Dispose();
            vs.Controls.Add(inventario);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
            vs.Controls.Add(new CduMenuPrincipal(vs));

        }

        private void btnCerrarConjunto_Click(object sender, EventArgs e)
        {
            ClsLogicaConjunto conjunto = new ClsLogicaConjunto();
            conjunto.cerrarConjunto(idConjunto, DateTime.Now);

        }
    }
}
