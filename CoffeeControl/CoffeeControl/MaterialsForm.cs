namespace CoffeeControl
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MaterialsForm : Form    {

        public List<Material> SelectedMaterials = new List<Material>();
        public Form1 main;

        public MaterialsForm(string type)
        {
            InitializeComponent();
            main = this.Owner as Form1;
            this.Text = "Приход расходников: " + type;

            SelectedMaterials = Data.Materials;
            flowLayoutPanelArrPcs.AutoSize = true;
            //flowLayoutPanelCurrPcs.AutoSize = true;
            foreach (Material material in SelectedMaterials)
            {
                if (material.type == type)
                {
                    Label matArrLabel = new Label();
                    matArrLabel.AutoSize = true;
                    matArrLabel.Text = material.name + ", " + material.unitName + " (В наличии: " + material.pieces.ToString() + " " + material.unitName + " ): ";
                    flowLayoutPanelArrPcs.Controls.Add(matArrLabel);
                    NumericUpDown matCounter = new NumericUpDown();
                    matCounter.Name = material.name;
                    flowLayoutPanelArrPcs.Controls.Add(matCounter);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var counter in flowLayoutPanelArrPcs.Controls.OfType<NumericUpDown>())
            {
                foreach (Material mat in SelectedMaterials)
                {
                    if (mat.name == counter.Name)
                        mat.pieces += (int)counter.Value;
                }
            }
            Data.Materials = SelectedMaterials;
            this.Close();
        }
    }
}
