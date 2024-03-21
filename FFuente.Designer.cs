namespace Semana_2
{
    partial class FFuente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFuente));
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(324, 316);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 331);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de la vitamina";
            // 
            // button5
            // 
            button5.Location = new Point(70, 250);
            button5.Name = "button5";
            button5.Size = new Size(124, 44);
            button5.TabIndex = 16;
            button5.Text = "Ingresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(333, 250);
            button4.Name = "button4";
            button4.Size = new Size(124, 44);
            button4.TabIndex = 15;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(200, 250);
            button3.Name = "button3";
            button3.Size = new Size(124, 44);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(251, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 40);
            comboBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 39);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 39);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 178);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 8;
            label3.Text = "Necesidad nutricional:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 114);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 7;
            label2.Text = "Alimento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 54);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 6;
            label1.Text = "Vitamina:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(276, 19);
            label4.Name = "label4";
            label4.Size = new Size(123, 37);
            label4.TabIndex = 9;
            label4.Text = "Vitamina";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(742, 19);
            label6.Name = "label6";
            label6.Size = new Size(125, 37);
            label6.TabIndex = 11;
            label6.Text = "Alimento";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(557, 239);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Click += listView1_Click;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listView2.Location = new Point(591, 71);
            listView2.Name = "listView2";
            listView2.Size = new Size(555, 239);
            listView2.TabIndex = 14;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.Click += listView2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 541);
            button1.Name = "button1";
            button1.Size = new Size(127, 102);
            button1.TabIndex = 15;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1009, 550);
            button2.Name = "button2";
            button2.Size = new Size(126, 86);
            button2.TabIndex = 16;
            button2.Text = "TERMINAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FFuente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1158, 659);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "FFuente";
            Text = "FFuente";
            Load += FFuente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label4;
        private Label label6;
        private ListView listView1;
        private ListView listView2;
        private Button button1;
        private Button button2;
    }
}