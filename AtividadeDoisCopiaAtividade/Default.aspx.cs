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

        protected bool isDisplaying()
        {
            return lblVisor.Text != "";
        }

        protected void radioNegrito_CheckedChanged(object sender, EventArgs e)
        {
            if (!isDisplaying()) return;
            lblVisor.Font.Bold = true;
            lblVisor.Font.Underline = false;
            lblVisor.Font.Italic = false;
            imgFormat.ImageUrl = "~/Imagens/Negrito.png";
        }

        protected void radioSublinhado_CheckedChanged(object sender, EventArgs e)
        {
            if (!isDisplaying()) return;
            lblVisor.Font.Bold = false;
            lblVisor.Font.Underline = true;
            lblVisor.Font.Italic = false;
            imgFormat.ImageUrl = "~/Imagens/Sublinhado.png";
        }

        protected void radioItalico_CheckedChanged(object sender, EventArgs e)
        {
            if (!isDisplaying()) return;
            lblVisor.Font.Bold = false;
            lblVisor.Font.Underline = false;
            lblVisor.Font.Italic = true;
            imgFormat.ImageUrl = "~/Imagens/Italico.png";
        }

        protected void radioReset_CheckedChanged(object sender, EventArgs e)
        {
            lblVisor.Font.Bold = false;
            lblVisor.Font.Underline = false;
            lblVisor.Font.Italic = false;
            imgFormat.ImageUrl = "";
        }

        protected void btnSelecionar_Click(object sender, ImageClickEventArgs e)
        {
            lblVisor.Text = text.Text;
            radioNegrito.Checked = false;
            radioItalico.Checked = false;
            radioSublinhado.Checked = false;
            radioReset.Checked = true;
            this.radioReset_CheckedChanged(sender, e);
        }

        protected void btnLimpar_Click(object sender, ImageClickEventArgs e)
        {
            lblVisor.Text = "";
            text.Text = "";
            radioNegrito.Checked = false;
            radioItalico.Checked = false;
            radioSublinhado.Checked = false;
            radioReset.Checked = true;
            this.radioReset_CheckedChanged(sender, e);
        }
    }
}