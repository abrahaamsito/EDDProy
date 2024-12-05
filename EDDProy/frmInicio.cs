using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Algoritmos_Recursivos;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_busqueda_y_ordenamiento;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas mColas = new frmColas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void algoritmosRecursivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorialdeunnumero mFactorialdeunnumero = new frmFactorialdeunnumero();
            mFactorialdeunnumero.MdiParent = this;
            mFactorialdeunnumero.Show();
        }

        private void calculoDeUnExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculodeunexponente mCalculodeunexponente = new frmCalculodeunexponente();
            mCalculodeunexponente.MdiParent = this;
            mCalculodeunexponente.Show();
        }

        private void sumarArreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumarArreglos mSumarArreglos = new frmSumarArreglos();
            mSumarArreglos.MdiParent = this;
            mSumarArreglos.Show();
        }

        private void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci mFibonacci = new frmFibonacci();
            mFibonacci.MdiParent = this;
            mFibonacci.Show();
        }

        private void torresDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTorresDeHanoi mTorresdeHanoi = new frmTorresDeHanoi();
            mTorresdeHanoi.MdiParent = this;
            mTorresdeHanoi.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria mBusquedaBinaria = new frmBusquedaBinaria();
            mBusquedaBinaria.MdiParent = this;
            mBusquedaBinaria.Show();
        }

        private void OrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadixsort mRadixsort = new frmRadixsort();
            mRadixsort.MdiParent = this;
            mRadixsort.Show();
        }

        private void BusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuicksort mQuicksort = new frmQuicksort();
            mQuicksort.MdiParent = this;
            mQuicksort.Show();
        }


        private void radixsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadixsort mRadixsort = new frmRadixsort();
            mRadixsort.MdiParent = this;
            mRadixsort.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja mBurbuja = new frmBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void metodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void OrdenamientoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void shellsortToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmShellsort mShellsort = new frmShellsort();
            mShellsort.MdiParent = this;
            mShellsort.Show();
        }

        private void BusquedaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBusqueda mBusqueda = new frmBusqueda();
            mBusqueda.MdiParent = this;
            mBusqueda.Show();
        }
    }
}
