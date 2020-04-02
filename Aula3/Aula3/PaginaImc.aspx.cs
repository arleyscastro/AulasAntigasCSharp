using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aula3.App_Code;

namespace Aula3
{
    public partial class PaginaImc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nome, peso, altura;
            //nome = Request.Params.Get("dsNome");
            //peso = Request.Params.Get("vlPeso");
            //altura = Request.Params.Get("vlAltura");
            //nome = peso = altura = "";

            //nome = (string)Session["dsNome"];
            //peso = (string) Session["vlPeso"];
            //altura = (string) Session["vlAltura"];


            //float imc;
            //imc = (float) (float.Parse(peso) / (Math.Pow(float.Parse(altura), 2)));

            CalculoImc imc = (CalculoImc)Session["objImc"];

            lblNome.Text = imc.Nome;
            lblPeso.Text = imc.Peso.ToString();
            lblAltura.Text = imc.Altura.ToString();

            lblImc.Text = imc.Imc.ToString();

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}