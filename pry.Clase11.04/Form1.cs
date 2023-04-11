using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.Clase11._04
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Declarar nodos en el load
            TreeNode abuelo;
            TreeNode padre;
            
            TreeNode hijo;

            //Declarar nodo raiz en el TreeView y adjuntarle el icono correspondiente
            abuelo = tv.Nodes.Add("ALIMENTOS","ALIMENTOS", 0);

            //Declarar los otros dos nodos en el TreeView
            padre = abuelo.Nodes.Add("FRUTAS", "FRUTAS", 1,2);
            //Agrego los nodos dependientes de Frutas
            hijo = padre.Nodes.Add("Uva","Uva", 3,2);
            //Darle informacion a la uva con el Tag
            hijo.Tag = "380";
            hijo = padre.Nodes.Add("Pera", "Uva", 3,2);
            hijo.Tag = "400";
            hijo = padre.Nodes.Add("Naranja", "Naranja", 3,2);
            hijo.Tag = "500";



            padre = abuelo.Nodes.Add("VERDURAS", "VERDURAS", 1);

            hijo = padre.Nodes.Add("Acelga","Acelga",3,2);
            hijo.Tag = "250";
            hijo = padre.Nodes.Add("Lechuga","Lechuga", 3,2);
            hijo.Tag = "175";
            hijo = padre.Nodes.Add("Repollo", "Repollo", 3,2);
            hijo.Tag = "200";





        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Mostrar nodo elegido
            if (e.Node.Level==2)
            {
                MessageBox.Show("EL KILO VALE $"+ ""+ e.Node.Tag.ToString());
            }

            
        }
    }
}
