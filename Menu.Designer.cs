namespace Semana_2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            mantenimientoDeLaBDToolStripMenuItem = new ToolStripMenuItem();
            gestionarToolStripMenuItem = new ToolStripMenuItem();
            gestionarAlimentosToolStripMenuItem = new ToolStripMenuItem();
            gestionarFuentesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            controlToolStripMenuItem = new ToolStripMenuItem();
            regresarToolStripMenuItem = new ToolStripMenuItem();
            terminarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(339, 124);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 0;
            label1.Text = "Gestionar Vitaminas";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(22, 306);
            button1.Name = "button1";
            button1.Size = new Size(127, 102);
            button1.TabIndex = 1;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(661, 307);
            button2.Name = "button2";
            button2.Size = new Size(127, 102);
            button2.TabIndex = 2;
            button2.Text = "TERMINAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(42, 62);
            label2.Name = "label2";
            label2.Size = new Size(319, 22);
            label2.TabIndex = 3;
            label2.Text = "OTRAS OPCIONES DISPONIBLES";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(339, 203);
            label3.Name = "label3";
            label3.Size = new Size(180, 22);
            label3.TabIndex = 4;
            label3.Text = "Gestionar Alimentos";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(339, 277);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 5;
            label4.Text = "Gestionar Fuentes";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(339, 345);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 6;
            label5.Text = "Reportes";
            label5.Click += label5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoDeLaBDToolStripMenuItem, controlToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoDeLaBDToolStripMenuItem
            // 
            mantenimientoDeLaBDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarToolStripMenuItem, gestionarAlimentosToolStripMenuItem, gestionarFuentesToolStripMenuItem, reportesToolStripMenuItem });
            mantenimientoDeLaBDToolStripMenuItem.Name = "mantenimientoDeLaBDToolStripMenuItem";
            mantenimientoDeLaBDToolStripMenuItem.Size = new Size(147, 20);
            mantenimientoDeLaBDToolStripMenuItem.Text = "Mantenimiento de la BD";
            // 
            // gestionarToolStripMenuItem
            // 
            gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            gestionarToolStripMenuItem.Size = new Size(181, 22);
            gestionarToolStripMenuItem.Text = "Gestionar Vitaminas";
            gestionarToolStripMenuItem.Click += gestionarToolStripMenuItem_Click;
            // 
            // gestionarAlimentosToolStripMenuItem
            // 
            gestionarAlimentosToolStripMenuItem.Name = "gestionarAlimentosToolStripMenuItem";
            gestionarAlimentosToolStripMenuItem.Size = new Size(181, 22);
            gestionarAlimentosToolStripMenuItem.Text = "Gestionar Alimentos";
            gestionarAlimentosToolStripMenuItem.Click += gestionarAlimentosToolStripMenuItem_Click;
            // 
            // gestionarFuentesToolStripMenuItem
            // 
            gestionarFuentesToolStripMenuItem.Name = "gestionarFuentesToolStripMenuItem";
            gestionarFuentesToolStripMenuItem.Size = new Size(181, 22);
            gestionarFuentesToolStripMenuItem.Text = "Gestionar Fuentes";
            gestionarFuentesToolStripMenuItem.Click += gestionarFuentesToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(181, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // controlToolStripMenuItem
            // 
            controlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regresarToolStripMenuItem, terminarToolStripMenuItem });
            controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            controlToolStripMenuItem.Size = new Size(59, 20);
            controlToolStripMenuItem.Text = "Control";
            // 
            // regresarToolStripMenuItem
            // 
            regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            regresarToolStripMenuItem.Size = new Size(120, 22);
            regresarToolStripMenuItem.Text = "Regresar";
            regresarToolStripMenuItem.Click += regresarToolStripMenuItem_Click;
            // 
            // terminarToolStripMenuItem
            // 
            terminarToolStripMenuItem.Name = "terminarToolStripMenuItem";
            terminarToolStripMenuItem.Size = new Size(120, 22);
            terminarToolStripMenuItem.Text = "Terminar";
            terminarToolStripMenuItem.Click += terminarToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(814, 434);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoDeLaBDToolStripMenuItem;
        private ToolStripMenuItem controlToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private ToolStripMenuItem terminarToolStripMenuItem;
        private ToolStripMenuItem gestionarToolStripMenuItem;
        private ToolStripMenuItem gestionarAlimentosToolStripMenuItem;
        private ToolStripMenuItem gestionarFuentesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}