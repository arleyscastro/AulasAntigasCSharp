using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2._1
{
    public partial class MinhaPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtValor.Text);
            lblResultado.Text = (x + 3).ToString();
        }

        protected void btnChamada_Click(object sender, EventArgs e)
        {
            string parametro = "sNome=" + txtNome.Text;

            parametro += "&sApelido=" + txtSobeNome.Text;

            Response.Redirect("Tela2.aspx?" + parametro);
        }
    }
}