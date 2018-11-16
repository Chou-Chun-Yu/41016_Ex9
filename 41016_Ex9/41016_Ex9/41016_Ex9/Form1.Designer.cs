namespace _41016_Ex9
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        public void InitializeComponent()
        {
            this.Gb_type = new System.Windows.Forms.GroupBox();
            this.Rb_trapezoid = new System.Windows.Forms.RadioButton();
            this.Rb_rectangle = new System.Windows.Forms.RadioButton();
            this.Rb_triangle = new System.Windows.Forms.RadioButton();
            this.Rb_circle = new System.Windows.Forms.RadioButton();
            this.Lb_raidus = new System.Windows.Forms.Label();
            this.Tb_raidus = new System.Windows.Forms.TextBox();
            this.Tb_width = new System.Windows.Forms.TextBox();
            this.Lb_width = new System.Windows.Forms.Label();
            this.Tb_up = new System.Windows.Forms.TextBox();
            this.Lb_up = new System.Windows.Forms.Label();
            this.Bt_calculate = new System.Windows.Forms.Button();
            this.Gb_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_type
            // 
            this.Gb_type.Controls.Add(this.Rb_trapezoid);
            this.Gb_type.Controls.Add(this.Rb_rectangle);
            this.Gb_type.Controls.Add(this.Rb_triangle);
            this.Gb_type.Controls.Add(this.Rb_circle);
            this.Gb_type.Location = new System.Drawing.Point(12, 12);
            this.Gb_type.Name = "Gb_type";
            this.Gb_type.Size = new System.Drawing.Size(172, 77);
            this.Gb_type.TabIndex = 0;
            this.Gb_type.TabStop = false;
            // 
            // Rb_trapezoid
            // 
            this.Rb_trapezoid.AutoSize = true;
            this.Rb_trapezoid.Location = new System.Drawing.Point(72, 45);
            this.Rb_trapezoid.Name = "Rb_trapezoid";
            this.Rb_trapezoid.Size = new System.Drawing.Size(47, 16);
            this.Rb_trapezoid.TabIndex = 3;
            this.Rb_trapezoid.TabStop = true;
            this.Rb_trapezoid.Text = "梯形";
            this.Rb_trapezoid.UseVisualStyleBackColor = true;
            this.Rb_trapezoid.CheckedChanged += new System.EventHandler(RadioButton.Rb_trapezoid_CheckedChanged);
            // 
            // Rb_rectangle
            // 
            this.Rb_rectangle.AutoSize = true;
            this.Rb_rectangle.Location = new System.Drawing.Point(72, 21);
            this.Rb_rectangle.Name = "Rb_rectangle";
            this.Rb_rectangle.Size = new System.Drawing.Size(47, 16);
            this.Rb_rectangle.TabIndex = 2;
            this.Rb_rectangle.TabStop = true;
            this.Rb_rectangle.Text = "矩形";
            this.Rb_rectangle.UseVisualStyleBackColor = true;
            this.Rb_rectangle.CheckedChanged += new System.EventHandler(RadioButton.Rb_rectangle_CheckedChanged);
            // 
            // Rb_triangle
            // 
            this.Rb_triangle.AutoSize = true;
            this.Rb_triangle.Location = new System.Drawing.Point(7, 45);
            this.Rb_triangle.Name = "Rb_triangle";
            this.Rb_triangle.Size = new System.Drawing.Size(59, 16);
            this.Rb_triangle.TabIndex = 1;
            this.Rb_triangle.TabStop = true;
            this.Rb_triangle.Text = "三角形";
            this.Rb_triangle.UseVisualStyleBackColor = true;
            this.Rb_triangle.CheckedChanged += new System.EventHandler(RadioButton.Rb_triangle_CheckedChanged);
            // 
            // Rb_circle
            // 
            this.Rb_circle.AutoSize = true;
            this.Rb_circle.Location = new System.Drawing.Point(7, 21);
            this.Rb_circle.Name = "Rb_circle";
            this.Rb_circle.Size = new System.Drawing.Size(47, 16);
            this.Rb_circle.TabIndex = 0;
            this.Rb_circle.TabStop = true;
            this.Rb_circle.Text = "圓形";
            this.Rb_circle.UseVisualStyleBackColor = true;
            this.Rb_circle.CheckedChanged += new System.EventHandler(RadioButton.Rb_circle_CheckedChanged);
            // 
            // Lb_raidus
            // 
            this.Lb_raidus.AutoSize = true;
            this.Lb_raidus.Location = new System.Drawing.Point(10, 98);
            this.Lb_raidus.Name = "Lb_raidus";
            this.Lb_raidus.Size = new System.Drawing.Size(71, 12);
            this.Lb_raidus.TabIndex = 1;
            this.Lb_raidus.Text = "半徑/長/下底";
            // 
            // Tb_raidus
            // 
            this.Tb_raidus.Location = new System.Drawing.Point(84, 95);
            this.Tb_raidus.Name = "Tb_raidus";
            this.Tb_raidus.Size = new System.Drawing.Size(100, 22);
            this.Tb_raidus.TabIndex = 2;
            // 
            // Tb_width
            // 
            this.Tb_width.Location = new System.Drawing.Point(84, 123);
            this.Tb_width.Name = "Tb_width";
            this.Tb_width.Size = new System.Drawing.Size(100, 22);
            this.Tb_width.TabIndex = 4;
            // 
            // Lb_width
            // 
            this.Lb_width.AutoSize = true;
            this.Lb_width.Location = new System.Drawing.Point(10, 126);
            this.Lb_width.Name = "Lb_width";
            this.Lb_width.Size = new System.Drawing.Size(32, 12);
            this.Lb_width.TabIndex = 3;
            this.Lb_width.Text = "寬/高";
            // 
            // Tb_up
            // 
            this.Tb_up.Location = new System.Drawing.Point(84, 151);
            this.Tb_up.Name = "Tb_up";
            this.Tb_up.Size = new System.Drawing.Size(100, 22);
            this.Tb_up.TabIndex = 6;
            // 
            // Lb_up
            // 
            this.Lb_up.AutoSize = true;
            this.Lb_up.Location = new System.Drawing.Point(10, 154);
            this.Lb_up.Name = "Lb_up";
            this.Lb_up.Size = new System.Drawing.Size(29, 12);
            this.Lb_up.TabIndex = 5;
            this.Lb_up.Text = "上底";
            // 
            // Bt_calculate
            // 
            this.Bt_calculate.Location = new System.Drawing.Point(56, 184);
            this.Bt_calculate.Name = "Bt_calculate";
            this.Bt_calculate.Size = new System.Drawing.Size(75, 23);
            this.Bt_calculate.TabIndex = 7;
            this.Bt_calculate.Text = "計算";
            this.Bt_calculate.UseVisualStyleBackColor = true;
            this.Bt_calculate.Click += new System.EventHandler(this.Bt_calculate_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 219);
            this.Controls.Add(this.Bt_calculate);
            this.Controls.Add(this.Tb_up);
            this.Controls.Add(this.Lb_up);
            this.Controls.Add(this.Tb_width);
            this.Controls.Add(this.Lb_width);
            this.Controls.Add(this.Tb_raidus);
            this.Controls.Add(this.Lb_raidus);
            this.Controls.Add(this.Gb_type);
            this.Name = "Menu";
            this.Text = "面積計算";
            this.Gb_type.ResumeLayout(false);
            this.Gb_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox Gb_type;
        internal System.Windows.Forms.Label Lb_raidus;
        internal System.Windows.Forms.TextBox Tb_raidus;
        internal System.Windows.Forms.TextBox Tb_width;
        internal System.Windows.Forms.Label Lb_width;
        internal System.Windows.Forms.TextBox Tb_up;
        internal System.Windows.Forms.Label Lb_up;
        internal System.Windows.Forms.Button Bt_calculate;
        internal System.Windows.Forms.RadioButton Rb_trapezoid;
        internal System.Windows.Forms.RadioButton Rb_rectangle;
        internal System.Windows.Forms.RadioButton Rb_triangle;
        internal System.Windows.Forms.RadioButton Rb_circle;
    }
}

