using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0.Model
{
    public class Helpier
    {
       public void LimparTela(Form tela)
       {
            foreach (Control ctrPai in tela.Controls)
            {
                if (ctrPai is TextBox)
                {
                    (ctrPai as TextBox).Text = string.Empty;
                }
                else if (ctrPai is MaskedTextBox)
                {
                    (ctrPai as MaskedTextBox).Text = string.Empty;
                }
            }        
       }
    }
}
