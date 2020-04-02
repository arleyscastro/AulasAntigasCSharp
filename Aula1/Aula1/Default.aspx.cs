using System;
using System.Web.UI;

namespace Aula1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            int ano;

            if (int.TryParse(txtNome.Text, out ano))
            {
                lblTexto.Text = (2020 - ano).ToString();
            }
            else
            {
                lblTexto.Text = "Não foi possível calcular a idade";
            }

            
        }
    }
}