namespace WindowsFormsApplication15
{
    partial class Form1
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
            this.rbOrange = new System.Windows.Forms.CheckBox();
            this.rbPineapple = new System.Windows.Forms.CheckBox();
            this.rbMango = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frtSelection = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Location = new System.Drawing.Point(6, 19);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(61, 17);
            this.rbOrange.TabIndex = 0;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            this.rbOrange.CheckedChanged += new System.EventHandler(this.rbOrange_CheckedChanged);
            // 
            // rbPineapple
            // 
            this.rbPineapple.AutoSize = true;
            this.rbPineapple.Location = new System.Drawing.Point(6, 42);
            this.rbPineapple.Name = "rbPineapple";
            this.rbPineapple.Size = new System.Drawing.Size(73, 17);
            this.rbPineapple.TabIndex = 1;
            this.rbPineapple.Text = "Pineapple";
            this.rbPineapple.UseVisualStyleBackColor = true;
            // 
            // rbMango
            // 
            this.rbMango.AutoSize = true;
            this.rbMango.Location = new System.Drawing.Point(8, 65);
            this.rbMango.Name = "rbMango";
            this.rbMango.Size = new System.Drawing.Size(59, 17);
            this.rbMango.TabIndex = 2;
            this.rbMango.Text = "Mango";
            this.rbMango.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "please select a fruit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrange);
            this.groupBox1.Controls.Add(this.rbPineapple);
            this.groupBox1.Controls.Add(this.rbMango);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fruits";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Selection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 13);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "select extra item";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Honey";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(289, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Yogurt";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // frtSelection
            // 
            this.frtSelection.FormattingEnabled = true;
            this.frtSelection.Location = new System.Drawing.Point(543, 99);
            this.frtSelection.Name = "frtSelection";
            this.frtSelection.Size = new System.Drawing.Size(120, 95);
            this.frtSelection.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 262);
            this.Controls.Add(this.frtSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox rbOrange;
        private System.Windows.Forms.CheckBox rbPineapple;
        private System.Windows.Forms.CheckBox rbMango;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox frtSelection;
    }
}

