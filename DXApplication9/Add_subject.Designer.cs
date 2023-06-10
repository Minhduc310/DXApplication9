namespace DXApplication9
{
    partial class Thêm_môn_học
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.44F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.56F)});
            this.tablePanel1.Controls.Add(this.textBox6);
            this.tablePanel1.Controls.Add(this.textBox5);
            this.tablePanel1.Controls.Add(this.textBox4);
            this.tablePanel1.Controls.Add(this.textBox3);
            this.tablePanel1.Controls.Add(this.textBox2);
            this.tablePanel1.Controls.Add(this.textBox1);
            this.tablePanel1.Location = new System.Drawing.Point(22, 32);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 28F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(277, 83);
            this.tablePanel1.TabIndex = 0;
            // 
            // textBox6
            // 
            this.tablePanel1.SetColumn(this.textBox6, 1);
            this.textBox6.Location = new System.Drawing.Point(144, 53);
            this.textBox6.Name = "textBox6";
            this.tablePanel1.SetRow(this.textBox6, 2);
            this.textBox6.Size = new System.Drawing.Size(130, 21);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.tablePanel1.SetColumn(this.textBox5, 1);
            this.textBox5.Location = new System.Drawing.Point(144, 24);
            this.textBox5.Name = "textBox5";
            this.tablePanel1.SetRow(this.textBox5, 1);
            this.textBox5.Size = new System.Drawing.Size(130, 21);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.tablePanel1.SetColumn(this.textBox4, 1);
            this.textBox4.Location = new System.Drawing.Point(144, 3);
            this.textBox4.Name = "textBox4";
            this.tablePanel1.SetRow(this.textBox4, 0);
            this.textBox4.Size = new System.Drawing.Size(130, 21);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Tên môn học";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.tablePanel1.SetColumn(this.textBox3, 0);
            this.textBox3.Location = new System.Drawing.Point(3, 53);
            this.textBox3.Name = "textBox3";
            this.tablePanel1.SetRow(this.textBox3, 2);
            this.textBox3.Size = new System.Drawing.Size(135, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.tablePanel1.SetColumn(this.textBox2, 0);
            this.textBox2.Location = new System.Drawing.Point(3, 24);
            this.textBox2.Name = "textBox2";
            this.tablePanel1.SetRow(this.textBox2, 1);
            this.textBox2.Size = new System.Drawing.Size(135, 21);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.tablePanel1.SetColumn(this.textBox1, 0);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.tablePanel1.SetRow(this.textBox1, 0);
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Mã môn học";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Thêm_môn_học
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 188);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Thêm_môn_học";
            this.Text = "Thêm_môn_học";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}