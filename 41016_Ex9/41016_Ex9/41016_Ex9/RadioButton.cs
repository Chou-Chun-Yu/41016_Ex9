using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41016_Ex9 {
    class RadioButton {
        static public Menu R;

        static internal void Rb_circle_CheckedChanged(object sender, EventArgs e) {
            R.Lb_raidus.Text = "半徑";
            R.Tb_raidus.Visible = R.Rb_circle.Checked ? true : false;
            R.Lb_raidus.Visible = R.Rb_circle.Checked ? true : false;
            R.Tb_up.Visible = R.Rb_circle.Checked ? false : true;
            R.Lb_up.Visible = R.Rb_circle.Checked ? false : true;
            R.Tb_width.Visible = R.Rb_circle.Checked ? false : true;
            R.Lb_width.Visible = R.Rb_circle.Checked ? false : true;
        }

        static internal void Rb_rectangle_CheckedChanged(object sender, EventArgs e) {
            R.Lb_raidus.Text = "長";
            R.Tb_raidus.Visible = R.Rb_rectangle.Checked ? true : false;
            R.Lb_raidus.Visible = R.Rb_rectangle.Checked ? true : false;
            R.Tb_up.Visible = R.Rb_rectangle.Checked ? false : true;
            R.Lb_up.Visible = R.Rb_rectangle.Checked ? false : true;
            R.Lb_width.Text = "寬";
            R.Tb_width.Visible = R.Rb_rectangle.Checked ? true : false;
            R.Lb_width.Visible = R.Rb_rectangle.Checked ? true : false;
        }

        static internal void Rb_trapezoid_CheckedChanged(object sender, EventArgs e) {
            R.Lb_raidus.Text = "下底";
            R.Tb_raidus.Visible = R.Rb_trapezoid.Checked ? true : false;
            R.Lb_raidus.Visible = R.Rb_trapezoid.Checked ? true : false;
            R.Lb_up.Text = "上底";
            R.Tb_up.Visible = R.Rb_trapezoid.Checked ? true : false;
            R.Lb_up.Visible = R.Rb_trapezoid.Checked ? true : false;
            R.Lb_width.Text = "高";
            R.Tb_width.Visible = R.Rb_trapezoid.Checked ? true : false;
            R.Lb_width.Visible = R.Rb_trapezoid.Checked ? true : false;
        }

        static internal void Rb_triangle_CheckedChanged(object sender, EventArgs e) {
            R.Lb_raidus.Text = "底";
            R.Tb_raidus.Visible = R.Rb_triangle.Checked ? true : false;
            R.Lb_raidus.Visible = R.Rb_triangle.Checked ? true : false;
            R.Tb_up.Visible = R.Rb_triangle.Checked ? false : true;
            R.Lb_up.Visible = R.Rb_triangle.Checked ? false : true;
            R.Lb_width.Text = "高";
            R.Tb_width.Visible = R.Rb_triangle.Checked ? true : false;
            R.Lb_width.Visible = R.Rb_triangle.Checked ? true : false;
        }
    }
}
