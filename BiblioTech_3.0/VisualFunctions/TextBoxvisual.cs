using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech_3._0.VisualFunctions
{
    class TextBoxvisual
    {
        public void TextBox_Enter(TextBox textbox, Label borda)
        {
            borda.BackColor = Color.FromArgb(92, 92, 155);
            textbox.ForeColor = Color.White;
        }

        public void MaskedTextBox_Enter(MaskedTextBox textbox, Label borda)
        {
            borda.BackColor = Color.FromArgb(92, 92, 155);
            textbox.ForeColor = Color.White;
        }

        public void TextBoxComplete_Leave(Label borda)
        {
            borda.BackColor = Color.FromArgb(92, 92, 155);
        }

        public void TextBoxDontChange_Leave(TextBox textbox, Label borda, string msg)
        {
            textbox.Text = msg;
            borda.BackColor = Color.FromArgb(92, 92, 155);
        }

        public void MaskedTextBoxDontChange_Leave(MaskedTextBox textbox, Label borda, string msg)
        {
            textbox.Text = msg;
            borda.BackColor = Color.FromArgb(92, 92, 155);
        }

        public void TextBoxIncomplete_Leave(TextBox textbox, Label borda, string msg)
        {
            textbox.Text = msg;
            borda.BackColor = Color.FromArgb(49, 48, 79);
            textbox.ForeColor = Color.FromArgb(92, 92, 155);
        }

        public void MaskedTextBoxIncomplete_Leave(MaskedTextBox textbox, Label borda, string msg)
        {
            textbox.Text = msg;
            borda.BackColor = Color.FromArgb(49, 48, 79);
            textbox.ForeColor = Color.FromArgb(92, 92, 155);
        }

        public void TextBoxInvalid_Leave(TextBox textbox, Label borda)
        {
            textbox.Text = "";
            borda.BackColor = Color.FromArgb(249, 148, 179);
        }

        public void MaskedTextBoxInvalid_Leave(MaskedTextBox textbox, Label borda)
        {
            textbox.Text = "";
            borda.BackColor = Color.FromArgb(249, 148, 179);
        }
    }
}
