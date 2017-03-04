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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.RegistrosMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.AJugarmetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EtapaL = new MetroFramework.Controls.MetroLabel();
            this.CradioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.DradioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.AradioButton = new MetroFramework.Controls.MetroRadioButton();
            this.BradioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.IdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.EquiposComboBox = new MetroFramework.Controls.MetroComboBox();
            this.pregunta = new MetroFramework.Controls.MetroLabel();
            this.NextButton = new MetroFramework.Controls.MetroButton();
            this.freshButton = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.RegistrosMetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.AJugarmetroTabPage.SuspendLayout();
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
            this.RegistrosMetroTabPage.Controls.Add(this.chart1);
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(268, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Equipos";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(702, 364);
            this.chart1.TabIndex = 6;
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
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
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
            this.metroTile3.Text = "Nuevos Preguntas";
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
            this.AJugarmetroTabPage.Controls.Add(this.metroLabel1);
            this.AJugarmetroTabPage.Controls.Add(this.EtapaL);
            this.AJugarmetroTabPage.Controls.Add(this.CradioBtn);
            this.AJugarmetroTabPage.Controls.Add(this.DradioBtn);
            this.AJugarmetroTabPage.Controls.Add(this.AradioButton);
            this.AJugarmetroTabPage.Controls.Add(this.BradioBtn);
            this.AJugarmetroTabPage.Controls.Add(this.IdTextBox);
            this.AJugarmetroTabPage.Controls.Add(this.Aceptarbutton);
            this.AJugarmetroTabPage.Controls.Add(this.EquiposComboBox);
            this.AJugarmetroTabPage.Controls.Add(this.pregunta);
            this.AJugarmetroTabPage.Controls.Add(this.NextButton);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(218, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Seleciona un Equipo";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // EtapaL
            // 
            this.EtapaL.AutoSize = true;
            this.EtapaL.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.EtapaL.Location = new System.Drawing.Point(789, 43);
            this.EtapaL.Name = "EtapaL";
            this.EtapaL.Size = new System.Drawing.Size(126, 19);
            this.EtapaL.TabIndex = 35;
            this.EtapaL.Text = "Etapa                    ";
            this.EtapaL.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // CradioBtn
            // 
            this.CradioBtn.AutoSize = true;
            this.CradioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.CradioBtn.Location = new System.Drawing.Point(73, 271);
            this.CradioBtn.Name = "CradioBtn";
            this.CradioBtn.Size = new System.Drawing.Size(16, 0);
            this.CradioBtn.TabIndex = 34;
            this.CradioBtn.UseSelectable = true;
            // 
            // DradioBtn
            // 
            this.DradioBtn.AutoSize = true;
            this.DradioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.DradioBtn.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.DradioBtn.Location = new System.Drawing.Point(76, 292);
            this.DradioBtn.Name = "DradioBtn";
            this.DradioBtn.Size = new System.Drawing.Size(16, 0);
            this.DradioBtn.TabIndex = 33;
            this.DradioBtn.UseSelectable = true;
            // 
            // AradioButton
            // 
            this.AradioButton.AutoSize = true;
            this.AradioButton.Location = new System.Drawing.Point(76, 229);
            this.AradioButton.Name = "AradioButton";
            this.AradioButton.Size = new System.Drawing.Size(16, 0);
            this.AradioButton.TabIndex = 32;
            this.AradioButton.UseSelectable = true;
            // 
            // BradioBtn
            // 
            this.BradioBtn.AutoSize = true;
            this.BradioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.BradioBtn.Location = new System.Drawing.Point(76, 250);
            this.BradioBtn.Name = "BradioBtn";
            this.BradioBtn.Size = new System.Drawing.Size(16, 0);
            this.BradioBtn.TabIndex = 31;
            this.BradioBtn.UseSelectable = true;
            // 
            // IdTextBox
            // 
            // 
            // 
            // 
            this.IdTextBox.CustomButton.Image = null;
            this.IdTextBox.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.IdTextBox.CustomButton.Name = "";
            this.IdTextBox.CustomButton.Size = new System.Drawing.Size(18, 21);
            this.IdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IdTextBox.CustomButton.TabIndex = 1;
            this.IdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IdTextBox.CustomButton.UseSelectable = true;
            this.IdTextBox.CustomButton.Visible = false;
            this.IdTextBox.Lines = new string[0];
            this.IdTextBox.Location = new System.Drawing.Point(64, 43);
            this.IdTextBox.MaxLength = 32767;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.PasswordChar = '\0';
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IdTextBox.SelectedText = "";
            this.IdTextBox.SelectionLength = 0;
            this.IdTextBox.SelectionStart = 0;
            this.IdTextBox.ShortcutsEnabled = true;
            this.IdTextBox.Size = new System.Drawing.Size(94, 23);
            this.IdTextBox.TabIndex = 30;
            this.IdTextBox.UseSelectable = true;
            this.IdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.IdTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Aceptarbutton.FlatAppearance.BorderSize = 0;
            this.Aceptarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Aceptarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Aceptarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Aceptarbutton.Image = global::BibleChallengeAPP.Properties.Resources._1453541179_ok_sign1;
            this.Aceptarbutton.Location = new System.Drawing.Point(409, 355);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(122, 54);
            this.Aceptarbutton.TabIndex = 29;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // EquiposComboBox
            // 
            this.EquiposComboBox.FormattingEnabled = true;
            this.EquiposComboBox.ItemHeight = 23;
            this.EquiposComboBox.Location = new System.Drawing.Point(367, 38);
            this.EquiposComboBox.Name = "EquiposComboBox";
            this.EquiposComboBox.Size = new System.Drawing.Size(416, 29);
            this.EquiposComboBox.TabIndex = 6;
            this.EquiposComboBox.UseSelectable = true;
            // 
            // pregunta
            // 
            this.pregunta.AutoSize = true;
            this.pregunta.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pregunta.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.pregunta.Location = new System.Drawing.Point(76, 91);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(20, 25);
            this.pregunta.Style = MetroFramework.MetroColorStyle.Black;
            this.pregunta.TabIndex = 4;
            this.pregunta.Text = "*";
            // 
            // NextButton
            // 
            this.NextButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.NextButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextButton.Location = new System.Drawing.Point(176, 38);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(36, 29);
            this.NextButton.Style = MetroFramework.MetroColorStyle.White;
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = ">|";
            this.NextButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NextButton.UseSelectable = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // freshButton
            // 
            this.freshButton.Location = new System.Drawing.Point(241, 31);
            this.freshButton.Name = "freshButton";
            this.freshButton.Size = new System.Drawing.Size(88, 23);
            this.freshButton.TabIndex = 7;
            this.freshButton.Text = "Refrescar";
            this.freshButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.freshButton.UseSelectable = true;
            this.freshButton.Click += new System.EventHandler(this.freshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 553);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.freshButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Text = "C.B.OasisSFM Beta";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.RegistrosMetroTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.AJugarmetroTabPage.ResumeLayout(false);
            this.AJugarmetroTabPage.PerformLayout();
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
        private MetroFramework.Controls.MetroComboBox EquiposComboBox;
        private MetroFramework.Controls.MetroLabel pregunta;
        private MetroFramework.Controls.MetroButton NextButton;
        private MetroFramework.Controls.MetroRadioButton CradioBtn;
        private MetroFramework.Controls.MetroRadioButton DradioBtn;
        private MetroFramework.Controls.MetroRadioButton AradioButton;
        private MetroFramework.Controls.MetroRadioButton BradioBtn;
        private MetroFramework.Controls.MetroTextBox IdTextBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private MetroFramework.Controls.MetroLabel EtapaL;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton freshButton;
    }
}

