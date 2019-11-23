using System;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    internal class Formulario
    {
        internal static bool Validar(Form formulario, ErrorProvider provedorErro)
        {
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;
                }

                if (controle.Tag.ToString().Contains("*") && controle.Text == string.Empty)
                {
                    provedorErro.SetError(controle, "Campo obrigatório.");
                    validacao = false;
                }
            }

            return validacao;
        }
    }
}