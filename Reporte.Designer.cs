namespace Semana_2
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            comboBox1 = new ComboBox();
            label1 = new Label();
            listView1 = new ListView();
            button2 = new Button();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1 - Todos las Vitaminas", "2 - Listado de todos los Alimentos", "3 - Reporte de todas la vitaminas, con necesidad nutricional y el nombre del alimento" });
            comboBox1.Location = new Point(575, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(170, 54);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el reporte requerido";
            // 
            // listView1
            // 
            listView1.Location = new Point(99, 121);
            listView1.Name = "listView1";
            listView1.Size = new Size(701, 239);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(25, 410);
            button2.Name = "button2";
            button2.Size = new Size(127, 102);
            button2.TabIndex = 16;
            button2.Text = "REGRESAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(743, 410);
            button3.Name = "button3";
            button3.Size = new Size(126, 86);
            button3.TabIndex = 17;
            button3.Text = "TERMINAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(99, 376);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(701, 17);
            progressBar1.TabIndex = 18;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(900, 524);
            Controls.Add(progressBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Reporte";
            Text = "Reporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ListView listView1;
        private Button button2;
        private Button button3;
        private ProgressBar progressBar1;
    }
}