using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP02_202873
{
    public partial class FrmGeral : Form
    {
        #region VARIAVEIS GLOBAIS
        string msg, título;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion

        public FrmGeral()
        {
            InitializeComponent();
        }

        #region CALCULAR
        private void BtnCalc_Click(object sender, EventArgs e)
        {
 
            double massa;
            double coeficiente;
            double forca;
            double angulo;
            double deslocamento;
            double gravidade = 9.8;
            double sin, cos, rad;
            double forcaAtrito;

            massa = double.Parse(TxtBxMassa.Text);
            coeficiente = double.Parse(TxtBxCoef.Text);
            forca = double.Parse(TxtBxF.Text);
            angulo = double.Parse(TxtBxAngulo.Text);
            deslocamento = double.Parse(TxtBxMetros.Text);

            rad = angulo * (Math.PI / 180);

            sin = Math.Sin(rad);
            cos = Math.Cos(rad);

            forcaAtrito = ((coeficiente * ((gravidade * massa) - (forca * sin))) * (deslocamento * cos));

            TxtBxAtrito.Text = forcaAtrito.ToString();

        }
        #endregion

        #region LIMPAR  
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtBxMassa.Text = "";
            TxtBxCoef.Text = "";
            TxtBxF.Text = "";
            TxtBxAngulo.Text = "";
            TxtBxMetros.Text = "";
            TxtBxAtrito.Text = "";
        }
        #endregion

        #region SAIR
        private void BtnSair_Click(object sender, EventArgs e)
        {

            msg = "Tem Certeza?";
            título = "Sair do Programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if(MessageBox.Show(msg, título, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        #endregion

        #region LIXO
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LblNewton_Click(object sender, EventArgs e)
        {

        }

        

        private void LblDesloc_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
