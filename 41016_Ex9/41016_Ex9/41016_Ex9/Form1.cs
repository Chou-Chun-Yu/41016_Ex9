using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41016_Ex9{
    public partial class Menu : Form{
        public Menu(){
            InitializeComponent();
            RadioButton.R = this;
        }

        private void Bt_calculate_Click(object sender, EventArgs e){
            try{
                size result = new size();
                result.S = this;
                if (Rb_circle.Checked) {
                    MessageBox.Show(result.circle(),"圓形面積");
                }else if(Rb_rectangle.Checked){
                    MessageBox.Show(result.rect(), "矩形面積");
                }else if (Rb_triangle.Checked) {
                    MessageBox.Show(result.tri(), "三角形面積");
                }else if(Rb_trapezoid.Checked){
                    MessageBox.Show(result.trapezoid(), "梯形面積");
                }
            }
            catch(Exception err){
                MessageBox.Show(err.Message);
            }
        }

    }
}
