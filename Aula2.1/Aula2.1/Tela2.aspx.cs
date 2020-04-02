using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2._1
{
    public partial class Tela2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nome, sobrenome;

            nome = Request.Params.Get("sNome");
            sobrenome = Request.Params.Get("sApelido");

            lblTexto.Text = nome + ", " + sobrenome;
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MinhaPagina.aspx");
        }
    }
}