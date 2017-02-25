namespace BibleChallengeAPP
{
    partial class MainForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.RegistrosMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.AJugarmetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.RegistrosMetroTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.RegistrosMetroTabPage);
            this.metroTabControl1.Controls.Add(this.AJugarmetroTabPage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(977, 473);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // RegistrosMetroTabPage
            // 
            this.RegistrosMetroTabPage.Controls.Add(this.metroTile4);
            this.RegistrosMetroTabPage.Controls.Add(this.metroTile3);
            this.RegistrosMetroTabPage.Controls.Add(this.metroTile2);
            this.RegistrosMetroTabPage.Controls.Add(this.metroTile1);
            this.RegistrosMetroTabPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrosMetroTabPage.HorizontalScrollbarBarColor = true;
            this.RegistrosMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.RegistrosMetroTabPage.HorizontalScrollbarSize = 10;
            this.RegistrosMetroTabPage.Location = new System.Drawing.Point(4, 47);
            this.RegistrosMetroTabPage.Name = "RegistrosMetroTabPage";
            this.RegistrosMetroTabPage.Size = new System.Drawing.Size(969, 422);
            this.RegistrosMetroTabPage.Style = MetroFramework.MetroColorStyle.Black;
            this.RegistrosMetroTabPage.TabIndex = 0;
            this.RegistrosMetroTabPage.Text = "Menu ";
            this.RegistrosMetroTabPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RegistrosMetroTabPage.ToolTipText = "Menu Touch";
            this.RegistrosMetroTabPage.VerticalScrollbarBarColor = true;
            this.RegistrosMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.RegistrosMetroTabPage.VerticalScrollbarSize = 3;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(4, 254);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(258, 113);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 5;
            this.metroTile4.Text = "Ver Resultados";
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(3, 3);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(259, 120);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Nuevos Retos";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(3, 127);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(113, 120);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Nuevo Equipo";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImage = global::BibleChallengeAPP.Properties.Resources._1486243192_add_user;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.ForeColor = System.Drawing.Color.Black;
            this.metroTile1.Location = new System.Drawing.Point(122, 127);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(140, 121);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Nuevo Participante";
            this.metroTile1.TileImage = global::BibleChallengeAPP.Properties.Resources._1486243192_add_user;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // AJugarmetroTabPage
            // 
            this.AJugarmetroTabPage.HorizontalScrollbarBarColor = true;
            this.AJugarmetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.AJugarmetroTabPage.HorizontalScrollbarSize = 10;
            this.AJugarmetroTabPage.Location = new System.Drawing.Point(4, 47);
            this.AJugarmetroTabPage.Name = "AJugarmetroTabPage";
            this.AJugarmetroTabPage.Size = new System.Drawing.Size(969, 422);
            this.AJugarmetroTabPage.TabIndex = 1;
            this.AJugarmetroTabPage.Text = "Competencia";
            this.AJugarmetroTabPage.ToolTipText = "A Jugar";
            this.AJugarmetroTabPage.VerticalScrollbarBarColor = true;
            this.AJugarmetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.AJugarmetroTabPage.VerticalScrollbarSize = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 553);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Text = "C.B.OasisSFM Beta";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroTabControl1.ResumeLayout(false);
            this.RegistrosMetroTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage RegistrosMetroTabPage;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTabPage AJugarmetroTabPage;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}

