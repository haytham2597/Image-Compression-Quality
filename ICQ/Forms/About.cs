using System.Windows.Forms;

namespace ICQ.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label1.Text = "¿Por qué desarrollaste este software?\n" +
                          "Porque no le veo sentido tener o haber imágenes cuyo tamaño es desorbitante. Si hay gente que tienen fotos de recuerdo o de alguna otra cosa y resulta que el peso es demasiado"+
                          " mi software permite que se comprima tranquilamente y sin necesidad de ser online.\n" +
                          "Además porque estaba aburrido\n" +
                          "Es gratis, sin límite ni restricciones y de código abierto\n"+
                          "By: Dimitri Isakow";
        }
    }
}
