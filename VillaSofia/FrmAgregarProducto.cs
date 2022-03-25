using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace VillaSofia
{
    public partial class FrmAgregarProducto : Form
    {
        CduProducto prod;
        Boolean extender;
        int idEditar;

        public FrmAgregarProducto(CduProducto prod, int idEditar)
        {
            this.idEditar = idEditar;
            this.prod = prod;
            contador = 0;
            extender = true;
            InitializeComponent();
            comboClasificacion();
            llenarCampos();


        }

        public FrmAgregarProducto(CduProducto prod)
        {
            this.idEditar = -1;
            this.prod = prod;
            contador = 0;
            extender = true;
            InitializeComponent();
            comboClasificacion();


        }
        int contador;


        public void comboClasificacion()
        {
            ClsLogicaTipoProducto tipo = new ClsLogicaTipoProducto();
            cmbTipoProducto.DataSource = tipo.buscarProducto();
            cmbTipoProducto.DisplayMember = "descripcion";
            cmbTipoProducto.ValueMember = "idTipoProducto";
        }

        void guardarSinonimos(int idProducto)
        {
            ClsLogicaSinonimo sinonimo = new ClsLogicaSinonimo();
            sinonimo.eliminarSinonimos(idProducto);
            sinonimo.agregarSinonimoPrincipal(idProducto, txtNombre.Text);
            sinonimo.agregarSinonimo(idProducto, txtSinonimos.Text);
        }


        Boolean validarint(String a)
        {
            if (a != "")
            {
                try
                {
                    int b = Convert.ToInt32(a);
                    return true;
                }
                catch (FormatException e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        void llenarCampos()
        {
            btnGuardar.Text = "ACTUALIZAR";
            btnCancelar.Visible = true;


            ClsLogicaProducto producto = new ClsLogicaProducto();
            DataTable DT = producto.buscarProducto(idEditar.ToString());

            txtNombre.Text = DT.Rows[0].Field<String>("Nombre");
            txtPrecio.Text = DT.Rows[0].Field<double>("Precio").ToString();
            cmbTipoProducto.SelectedValue = DT.Rows[0].Field<int>("Clasificación");

            ClsLogicaSinonimo sinonimo = new ClsLogicaSinonimo();
            txtSinonimos.Text = sinonimo.buscarSinonimos(idEditar);

            if(txtSinonimos.Text != "")
            {
                btnSinonimos.Image = global::VillaSofia.Properties.Resources.arriba94_148_255Azul32;
                extender = false;
                tempoSinonimos.Start();

            }


        }


        void editarProducto()
        {
            int posi = prod.dgvProducto.FirstDisplayedScrollingRowIndex;
            ClsLogicaProducto producto = new ClsLogicaProducto();
            int cocinaBarra, reseve;
            //if (rdbCocina.Checked)
            //{
            cocinaBarra = 1;
            //}
            //else
            //{
            //    cocinaBarra = 2;
            //}
            //if (chbRestaurante.Checked)
            //{
            reseve = 1;
            //    if (chbEventos.Checked)
            //    {
            //        reseve = 3;
            //    }
            //}
            //else if (chbEventos.Checked)
            //{
            //    reseve = 2;
            //}
            //else
            //{
            //    reseve = 4;
            //}
            String mensaje = producto.editarProducto(reseve, idEditar, txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(cmbTipoProducto.SelectedValue), cocinaBarra);
            if (mensaje == "Producto Actualizado")
            {
                guardarSinonimos(idEditar);
                MessageBox.Show("Producto Actualizado");
                prod.cargarTabla();
                prod.dgvProducto.FirstDisplayedScrollingRowIndex = posi;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje);
                chbVincular.Checked = false;
            }


        }

        int insertarProducto(int orden)
        {
            int posi = prod.dgvProducto.FirstDisplayedScrollingRowIndex;
            ClsLogicaProducto producto = new ClsLogicaProducto();
            int cocinaBarra;
            int reseve;
            //if (rdbCocina.Checked)
            //{
                cocinaBarra = 1;
            //}
            //else
            //{
            //    cocinaBarra = 2;
            //}
            //if (chbRestaurante.Checked)
            //{
            reseve = 1;
            //    if (chbEventos.Checked)
            //    {
            //        reseve = 3;
            //    }
            //}
            //else if (chbEventos.Checked)
            //{
            //    reseve = 2;
            //}
            //else
            //{
            //    reseve = 4;
            //}
            String mensaje = producto.insertarProducto(reseve, txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(cmbTipoProducto.SelectedValue), cocinaBarra, orden);
            if (validarint(mensaje))
            {
                guardarSinonimos(Convert.ToInt32(mensaje));
                MessageBox.Show("Guardado");
                prod.cargarTabla();
                prod.dgvProducto.FirstDisplayedScrollingRowIndex = posi;
                return Convert.ToInt32(mensaje);
            }
            else
            {
                MessageBox.Show(mensaje);
                chbVincular.Checked = false;
                prod.cargarTabla();
                prod.dgvProducto.FirstDisplayedScrollingRowIndex = posi;
                return -1;
            }
            

        }

        Boolean validarNombre()
        {
            if (txtNombre.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        Boolean validarPrecio()
        {
            if (txtPrecio.Text != "")
            {
                try
                {
                    double y = Convert.ToDouble(txtPrecio.Text);
                    return true;
                }
                catch (FormatException e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void tempo_Tick(object sender, EventArgs e)
        {

            contador++;
            if (!chbVincular.Checked)
            {

                

                this.Size = new Size(this.Width, this.Height - 10);
                if (contador == 10)
                {
                    tempo.Stop();
                    contador = 0;
                }
            }
            else
            {

                this.Size = new Size(this.Width, this.Height + 10);

                if (contador == 10)
                {
                    tempo.Stop();
                    contador = 0;
                }
            }

        }
       
       

        private void tempoSinonimos_Tick(object sender, EventArgs e)
        {
            //95
            if (extender)
            {
                this.Size = new Size(this.Width, this.Height - 10);
                //this.Location = new Point(this.Location.X, this.Location.Y + 10);
                txtSinonimos.Size = new Size(txtSinonimos.Size.Width, txtSinonimos.Size.Height - 10);
                lblPrecio.Location = new Point(lblPrecio.Location.X, lblPrecio.Location.Y - 10);
                lblClasificacion.Location = new Point(lblClasificacion.Location.X, lblClasificacion.Location.Y - 10);
                txtPrecio.Location = new Point(txtPrecio.Location.X, txtPrecio.Location.Y - 10);
                cmbTipoProducto.Location = new Point(cmbTipoProducto.Location.X, cmbTipoProducto.Location.Y - 10);
                btnClasificacion.Location = new Point(btnClasificacion.Location.X, btnClasificacion.Location.Y - 10);
                btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y - 10);
                btnCancelar.Location = new Point(btnCancelar.Location.X, btnCancelar.Location.Y - 10);
                chbVincular.Location = new Point(chbVincular.Location.X, chbVincular.Location.Y - 10);
                btnVincularDirecto.Location = new Point(btnVincularDirecto.Location.X, btnVincularDirecto.Location.Y - 10);
                btnMasOpciones.Location = new Point(btnMasOpciones.Location.X, btnMasOpciones.Location.Y - 10);



                if (txtSinonimos.Size.Height <= 1)
                {
                    tempoSinonimos.Stop();
                }
            }
            else
            {
                this.Size = new Size(this.Width, this.Height + 10);
                //this.Location = new Point(this.Location.X, this.Location.Y + 10);
                txtSinonimos.Size = new Size(txtSinonimos.Size.Width, txtSinonimos.Size.Height + 10);
                lblPrecio.Location = new Point(lblPrecio.Location.X, lblPrecio.Location.Y + 10);
                lblClasificacion.Location = new Point(lblClasificacion.Location.X, lblClasificacion.Location.Y + 10);
                txtPrecio.Location = new Point(txtPrecio.Location.X, txtPrecio.Location.Y + 10);
                cmbTipoProducto.Location = new Point(cmbTipoProducto.Location.X, cmbTipoProducto.Location.Y + 10);
                btnClasificacion.Location = new Point(btnClasificacion.Location.X, btnClasificacion.Location.Y + 10);
                btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y + 10);
                btnCancelar.Location = new Point(btnCancelar.Location.X, btnCancelar.Location.Y + 10);
                chbVincular.Location = new Point(chbVincular.Location.X, chbVincular.Location.Y + 10);
                btnVincularDirecto.Location = new Point(btnVincularDirecto.Location.X, btnVincularDirecto.Location.Y + 10);
                btnMasOpciones.Location = new Point(btnMasOpciones.Location.X, btnMasOpciones.Location.Y + 10);

                if (txtSinonimos.Size.Height >= 95)
                {
                    tempoSinonimos.Stop();
                }
            }
        }


       

        private void chbVincular_CheckedChanged(object sender, EventArgs e)
        {
            tempo.Start();

            if (chbVincular.Checked)
            {
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }

            //if (chbVincular.Checked)
            //{
            //    if (idEditar != -1)
            //    {
            //        if (validarNombre() && validarPrecio())
            //        {
            //            editarProducto();
            //            prod.desactivarEdicion();
            //        }
            //        else
            //        {
            //            MessageBox.Show("El nombre o el precio no es valido");
            //            chbVincular.Checked = false;
            //        }
            //    }
            //    else
            //    {
            //        if (validarNombre() && validarPrecio())
            //        {
            //            insertarProducto(-1);

            //            try
            //            {
            //                prod.dgvProducto.FirstDisplayedScrollingRowIndex = prod.dgvProducto.RowCount - 1;

            //            }
            //            catch (ArgumentOutOfRangeException) { }
            //        }
            //        else
            //        {
            //            MessageBox.Show("El nombre o el precio no es valido");
            //            chbVincular.Checked = false;
            //        }
            //    }
            //}
            
        }

        private void btnSinonimos_Click_1(object sender, EventArgs e)
        {
            if (extender)
            {
                btnSinonimos.Image = global::VillaSofia.Properties.Resources.arriba94_148_255Azul32;
                extender = false;
            }
            else
            {
                btnSinonimos.Image = global::VillaSofia.Properties.Resources.abajo94_148_255Azul32;
                extender = true;

            }
            tempoSinonimos.Start();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idEditar != -1)
            {
                if (validarNombre() && validarPrecio())
                {
                    editarProducto();
                    prod.desactivarEdicion();
                }
                else
                {
                    MessageBox.Show("El nombre o el precio no es valido");
                }
            }
            else
            {
                if (validarNombre() && validarPrecio())
                {
                    if (insertarProducto(-1) != -1)
                    {
                        this.Close();
                    }
                        

                    try
                    {
                        prod.dgvProducto.FirstDisplayedScrollingRowIndex = prod.dgvProducto.RowCount - 1;

                    }
                    catch (ArgumentOutOfRangeException) { }
                }
                else
                {
                    MessageBox.Show("El nombre o el precio no es valido");
                }
            }
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            FrmClasificacion clasi = new FrmClasificacion(this);
            clasi.Show();
        }

        private void btnVincularDirecto_Click(object sender, EventArgs e)
        {
            
            if (idEditar != -1)
            {
                if (validarNombre() && validarPrecio())
                {
                    editarProducto();
                    prod.desactivarEdicion();
                }
                else
                {
                    MessageBox.Show("El nombre o el precio no es valido");
                }
            }
            else
            {
                if (validarNombre() && validarPrecio())
                {
                    int idProd = insertarProducto(-1);
                    if (idProd != -1)
                    {
                        ClsLogicaInsumo insumo = new ClsLogicaInsumo();
                        String msj = insumo.agregarInsumo(txtNombre.Text, -1, 1, 0, 0, 0);
                        if (validarint(msj))
                        {
                            prod.cargarTablaInsumos();
                            ClsLogicaProducto producto = new ClsLogicaProducto();
                            producto.insertarProductoInsumo(idProd, Convert.ToInt32(msj), 1);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(msj);
                        }
                        
                    }
                    try
                    {
                        prod.dgvProducto.FirstDisplayedScrollingRowIndex = prod.dgvProducto.RowCount - 1;

                    }
                    catch (ArgumentOutOfRangeException) { }
                }
                else
                {
                    MessageBox.Show("El nombre o el precio no es valido");
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtNombre.Text != "")
            {
                chbVincular.Enabled = true;
                btnVincularDirecto.Text = "Agregar y vincular como '" + txtNombre.Text + " - 1 ud.'";
            }
            else
            {
                chbVincular.Enabled = false;
            }
        }

        private void btnMasOpciones_Click(object sender, EventArgs e)
        {

           


            if (idEditar != -1)
            {
                if (validarNombre() && validarPrecio())
                {
                    editarProducto();
                    prod.desactivarEdicion();
                }
                else
                {
                    MessageBox.Show("El nombre o el precio no es valido");
                }
            }
            else
            {
                if (validarNombre() && validarPrecio())
                {
                    int idProd = insertarProducto(-1);
                    if (idProd != -1)
                    {
                        FrmInsumoProducto inspro = new FrmInsumoProducto(prod, idProd, txtNombre.Text);
                        inspro.Visible = true;
                        this.Close();
                    }



                    try
                    {
                        prod.dgvProducto.FirstDisplayedScrollingRowIndex = prod.dgvProducto.RowCount - 1;

                    }
                    catch (ArgumentOutOfRangeException) { }
                }
                else
                {
                    MessageBox.Show("El nombre o el precio no es valido");
                }
            }


            
        }

        
    }
}
