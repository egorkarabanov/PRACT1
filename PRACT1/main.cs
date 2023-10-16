using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace PRACT1 {
    public partial class main : Form {
        public main() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Tabul tabul = new Tabul();
                double xn, xk, h, a;
                xn = Convert.ToDouble(this.textBoxXn.Text);
                xk = Convert.ToDouble(this.textBoxtXk.Text);
                h = Convert.ToDouble(this.textBoxH.Text);
                a = Convert.ToDouble(this.textBoxA.Text);

                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();

                tabul.Calc(xn, xk, h, a);
                for (int i = 0; i < tabul.n; i++) {
                    dataGridView1.Rows.Add(Math.Round(tabul.xy[i, 0], 2).ToString(),
                        Math.Round(tabul.xy[i, 1], 3).ToString());
                    chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
                }
            } catch (Exception exception) {
                Console.WriteLine(exception);
                MessageBox.Show("Error on data types", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void singleArrayToolStripMenuItem_Click(object sender, EventArgs e) {
            singleArray form = new singleArray();
            form.Show();
            this.Hide();
        }

        private void doubleArrayToolStripMenuItem_Click(object sender, EventArgs e) {
            doubleArray form = new doubleArray();
            form.Show();
            this.Hide();
        }
    }
}