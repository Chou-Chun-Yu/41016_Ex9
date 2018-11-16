using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41016_Ex9 {
    class size {
        public Menu S;

        public string circle() {
            double result, raidus;
            string area;
            raidus = Convert.ToDouble(S.Tb_raidus.Text);
            result = Math.PI * Math.Pow(raidus,2);
            area = "圓形面積" + result.ToString("n2") + "cm^2";
            return area;
        }

        public string rect() {
            double result, length, width;
            string area;
            length = Convert.ToDouble(S.Tb_raidus.Text);
            width = Convert.ToDouble(S.Tb_width.Text);
            result = length * width;
            area = "矩形面積" + result.ToString("n2") + "cm^2";
            return area;
        }

        public string tri() {
            double result, buttom, height;
            string area;
            buttom = Convert.ToDouble(S.Tb_raidus.Text);
            height = Convert.ToDouble(S.Tb_width.Text);
            result = (buttom * height) / 2;
            area = "三角形面積" + result.ToString("n2") + "cm^2";
            return area;
        }

        public string trapezoid() {
            double result, upper, buttom, height;
            string area;
            upper = Convert.ToDouble(S.Tb_up.Text);
            buttom = Convert.ToDouble(S.Tb_raidus.Text);
            height = Convert.ToDouble(S.Tb_width.Text);
            result = (upper + buttom) * height / 2;
            area = "梯形面積" + result.ToString("n2") + "cm^2";
            return area;
        }
    }
}