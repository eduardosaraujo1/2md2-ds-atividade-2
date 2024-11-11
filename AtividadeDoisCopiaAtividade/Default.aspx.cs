using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtividadeDoisCopiaAtividade
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void radioNegrito_CheckedChanged(object sender, EventArgs e)
        {
            lblVisor.Font.Bold = true;
            lblVisor.Font.Underline = false;
            lblVisor.Font.Italic = false;
        }

        protected void radioSublinhado_CheckedChanged(object sender, EventArgs e)
        {
            lblVisor.Font.Bold = false;
            lblVisor.Font.Underline = true;
            lblVisor.Font.Italic = false;
        }

        protected void radioItalico_CheckedChanged(object sender, EventArgs e)
        {

            lblVisor.Font.Bold = false;
            lblVisor.Font.Underline = false;
            lblVisor.Font.Italic = true;
        }

        protected void radioReset_CheckedChanged(object sender, EventArgs e)
        {
            lblVisor.Font.Bold = false;
            lblVisor.Font.Underline = false;
            lblVisor.Font.Italic = false;
        }

        protected void btnSelecionar_Click(object sender, ImageClickEventArgs e)
        {
            lblVisor.Text = text.Text;
        }

        protected void btnLimpar_Click(object sender, ImageClickEventArgs e)
        {
            lblVisor.Text = "";
            text.Text = "";
        }
    }
}