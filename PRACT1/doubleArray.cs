using System;
using System.Windows.Forms;

namespace PRACT1 {
    public partial class doubleArray : Form {
        private DoubleArrays matrix;
        public doubleArray() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                DataGridViewTextBoxColumn dvage;
                matrix = new DoubleArrays(Convert.ToInt16(this.textBoxName.Text),Convert.ToInt16(this.textBoxM.Text));
                for (int i = 0; i < matrix.X_length; i++) {
                    dvage = new DataGridViewTextBoxColumn();
                    dvage.Width = 40;
                    dataGridView1.Columns.Add(dvage);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = matrix.X_length;
                dataGridView1.ColumnCount = matrix.Y_length;
                for (int i = 0; i < matrix.X_length; i++) {
                    for (int j = 0; j < matrix.Y_length; j++) {
                        dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                    }
                }

                var diagonali = matrix.diagonali();
                dataGridView2.Rows.Clear();
                int k = 0;
                foreach (var data in diagonali.Item1) {
                    dataGridView2.Rows.Add(data.ToString(), diagonali.Item2[k].ToString());
                    k++;
                }
            } catch (Exception exception) {
                Console.WriteLine(exception);
                MessageBox.Show("Error on data types", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            var main = Application.OpenForms[0];
            main.Show();
            this.Close();
        }
    }
}