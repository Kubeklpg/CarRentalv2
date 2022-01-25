namespace CarRentalv2
{
    partial class MainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listaAutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKlientówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodawanieAutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodawanieKlientowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.wypożyczAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalkulatorFinansowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.listaAutToolStripMenuItem,
            this.listaKlientówToolStripMenuItem,
            this.dodawanieAutToolStripMenuItem,
            this.dodawanieKlientowToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Panel Administracji";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // listaAutToolStripMenuItem
            // 
            this.listaAutToolStripMenuItem.Name = "listaAutToolStripMenuItem";
            this.listaAutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listaAutToolStripMenuItem.Text = "Lista Aut";
            this.listaAutToolStripMenuItem.Click += new System.EventHandler(this.listaAutToolStripMenuItem_Click);
            // 
            // listaKlientówToolStripMenuItem
            // 
            this.listaKlientówToolStripMenuItem.Name = "listaKlientówToolStripMenuItem";
            this.listaKlientówToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listaKlientówToolStripMenuItem.Text = "Lista Klientów";
            this.listaKlientówToolStripMenuItem.Click += new System.EventHandler(this.listaKlientówToolStripMenuItem_Click);
            // 
            // dodawanieAutToolStripMenuItem
            // 
            this.dodawanieAutToolStripMenuItem.Name = "dodawanieAutToolStripMenuItem";
            this.dodawanieAutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dodawanieAutToolStripMenuItem.Text = "Dodawanie Aut";
            this.dodawanieAutToolStripMenuItem.Click += new System.EventHandler(this.dodawanieAutToolStripMenuItem_Click);
            // 
            // dodawanieKlientowToolStripMenuItem
            // 
            this.dodawanieKlientowToolStripMenuItem.Name = "dodawanieKlientowToolStripMenuItem";
            this.dodawanieKlientowToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dodawanieKlientowToolStripMenuItem.Text = "Dodawanie Klientow";
            this.dodawanieKlientowToolStripMenuItem.Click += new System.EventHandler(this.dodawanieKlientowToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wypożyczAutoToolStripMenuItem,
            this.kalkulatorFinansowyToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "Panel Użytkownika";
            // 
            // wypożyczAutoToolStripMenuItem
            // 
            this.wypożyczAutoToolStripMenuItem.Name = "wypożyczAutoToolStripMenuItem";
            this.wypożyczAutoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.wypożyczAutoToolStripMenuItem.Text = "Wypożycz Auto";
            this.wypożyczAutoToolStripMenuItem.Click += new System.EventHandler(this.wypożyczAutoToolStripMenuItem_Click);
            // 
            // kalkulatorFinansowyToolStripMenuItem
            // 
            this.kalkulatorFinansowyToolStripMenuItem.Name = "kalkulatorFinansowyToolStripMenuItem";
            this.kalkulatorFinansowyToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.kalkulatorFinansowyToolStripMenuItem.Text = "Kalkulator Finansowy";
            this.kalkulatorFinansowyToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorFinansowyToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listaAutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKlientówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodawanieAutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodawanieKlientowToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem wypożyczAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorFinansowyToolStripMenuItem;
    }
}

