namespace Semana_2
{
    partial class FVitamina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVitamina));
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            listView1 = new ListView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(29, 495);
            button1.Name = "button1";
            button1.Size = new Size(127, 102);
            button1.TabIndex = 2;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(1049, 511);
            button2.Name = "button2";
            button2.Size = new Size(126, 86);
            button2.TabIndex = 3;
            button2.Text = "TERMINAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(645, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 415);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de la vitamina";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(251, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 39);
            textBox3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 178);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 11;
            label4.Text = "Categoria:";
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
            label3.Location = new Point(34, 253);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 8;
            label3.Text = "Categoria:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 114);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 7;
            label2.Text = "Nombre Vitamina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 54);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 6;
            label1.Text = "Codigo:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Items.AddRange(new object[] { "HipoSolubles", "LipoSolubles" });
            listBox1.Location = new Point(251, 253);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(246, 132);
            listBox1.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(598, 402);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Click += listView1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.Location = new Point(660, 544);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 6;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.Location = new Point(793, 544);
            button4.Name = "button4";
            button4.Size = new Size(107, 40);
            button4.TabIndex = 7;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.Location = new Point(530, 544);
            button5.Name = "button5";
            button5.Size = new Size(107, 40);
            button5.TabIndex = 8;
            button5.Text = "Ingresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FVitamina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1212, 627);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FVitamina";
            Text = "FVitamina";
            Load += FVitamina_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private ListView listView1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox3;
        private Label label4;
    }
}