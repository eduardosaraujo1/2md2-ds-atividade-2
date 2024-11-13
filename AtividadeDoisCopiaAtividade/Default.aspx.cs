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

        protected void refreshFontAndImage(object sender, EventArgs e)
        {
            // reset
            lblVisor.Font.Bold = false;
            lblVisor.Font.Underline = false;
            lblVisor.Font.Italic = false;
            imgFormat.ImageUrl = "";

            // if text is empty, leave
            if (lblVisor.Text == "")
            {
                return;
            }
            
            // else
            if (radioItalico.Checked)
            {
                lblVisor.Font.Italic = true;
                imgFormat.ImageUrl = "~/Imagens/Italico.png";
            }
            else if (radioNegrito.Checked)
            {
                lblVisor.Font.Bold = true;
                imgFormat.ImageUrl = "~/Imagens/Negrito.png";
            }
            else if (radioSublinhado.Checked)
            {
                lblVisor.Font.Underline = true;
                imgFormat.ImageUrl = "~/Imagens/Sublinhado.png";
            }
        }

        protected void btnSelecionar_Click(object sender, ImageClickEventArgs e)
        {
            // Set visor to text
            lblVisor.Text = text.Text;
            refreshFontAndImage(sender, e);
        }

        protected void btnLimpar_Click(object sender, ImageClickEventArgs e)
        {
            // clear lbl text
            lblVisor.Text = "";
            text.Text = "";

            // define radio selection
            radioNegrito.Checked = false;
            radioItalico.Checked = false;
            radioSublinhado.Checked = false;
            radioReset.Checked = true;

            // reset
            refreshFontAndImage(sender, e);
        }
    }
}