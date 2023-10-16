using System;
using System.Windows.Forms;

namespace PRACT1 {
    public partial class singleArray : Form {
        Arrays arrays;

        public singleArray() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            var main = Application.OpenForms[0];
            main.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                dataGridView1.Rows.Clear();
                arrays.changeNegativeToZero();
                for (int i = 0; i < arrays.Length; i++) {
                    dataGridView1.Rows.Add(arrays[i].ToString());
                }
            } catch (Exception exception) {
                Console.WriteLine(exception);
                MessageBox.Show("Error on data types", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                dataGridView1.Rows.Clear();
                arrays = new Arrays(Convert.ToInt16(this.textBoxName.Text));
                for (int i = 0; i < arrays.Length; i++) {
                    dataGridView1.Rows.Add(arrays[i].ToString());
                }
            } catch (Exception exception) {
                Console.WriteLine(exception);
                MessageBox.Show("Error on data types", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
