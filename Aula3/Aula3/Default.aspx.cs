using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aula3.App_Code;

namespace Aula3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculo_Click(object sender, EventArgs e)
        {
            //string param = "?";
            //param += "dsNome=" + txtNome.Text;
            //param += "&vlAltura=" + txtAltura.Text;
            //param += "&vlPeso=" + txtPeso.Text;

            //Session["dsNome"] = txtNome.Text;
            //Session["vlAltura"] = txtAltura.Text;
            //Session["vlPeso"] = txtPeso.Text;
            CalculoImc calculo = new CalculoImc();

            calculo.Nome = txtNome.Text;
            calculo.Peso = float.Parse(txtPeso.Text);
            calculo.Altura = float.Parse(txtAltura.Text);

            Session["objImc"] = calculo;

            Response.Redirect("PaginaImc.aspx");
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            Unica unic = Unica.Instancia;

            unic.Nome = "José";

            Unica unic2 = Unica.Instancia;

            unic2.Nome = unic2.Nome + " Maria";

            txtNome.Text = unic.Nome;

        }
    }
}