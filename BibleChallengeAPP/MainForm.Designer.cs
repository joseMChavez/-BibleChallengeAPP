﻿namespace BibleChallengeAPP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.RegistrosMetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ResultadosmetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.VerResultadosButton = new MetroFramework.Controls.MetroButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AJugarmetroTabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.RegistrosMetroTabPage.SuspendLayout();
            this.ResultadosmetroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.RegistrosMetroTabPage);
            this.metroTabControl1.Controls.Add(this.ResultadosmetroTabPage);
            this.metroTabControl1.Controls.Add(this.AJugarmetroTabPage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
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
            this.RegistrosMetroTabPage.Controls.Add(this.metroTile3);
            this.RegistrosMetroTabPage.Controls.Add(this.metroTile2);
            this.RegistrosMetroTabPage.Controls.Add(this.metroTile1);
            this.RegistrosMetroTabPage.HorizontalScrollbarBarColor = true;
            this.RegistrosMetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.RegistrosMetroTabPage.HorizontalScrollbarSize = 10;
            this.RegistrosMetroTabPage.Location = new System.Drawing.Point(4, 47);
            this.RegistrosMetroTabPage.Name = "RegistrosMetroTabPage";
            this.RegistrosMetroTabPage.Size = new System.Drawing.Size(969, 422);
            this.RegistrosMetroTabPage.TabIndex = 0;
            this.RegistrosMetroTabPage.Text = "Registros";
            this.RegistrosMetroTabPage.VerticalScrollbarBarColor = true;
            this.RegistrosMetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.RegistrosMetroTabPage.VerticalScrollbarSize = 6;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.Highlight;
            this.metroTile3.Location = new System.Drawing.Point(122, 127);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(140, 120);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Nuevos Retos";
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.metroTile1.Location = new System.Drawing.Point(3, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(259, 121);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Nuevo Participante";
            this.metroTile1.TileImage = global::BibleChallengeAPP.Properties.Resources._1486243192_add_user;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ResultadosmetroTabPage
            // 
            this.ResultadosmetroTabPage.Controls.Add(this.VerResultadosButton);
            this.ResultadosmetroTabPage.Controls.Add(this.chart1);
            this.ResultadosmetroTabPage.HorizontalScrollbarBarColor = true;
            this.ResultadosmetroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ResultadosmetroTabPage.HorizontalScrollbarSize = 10;
            this.ResultadosmetroTabPage.Location = new System.Drawing.Point(4, 47);
            this.ResultadosmetroTabPage.Name = "ResultadosmetroTabPage";
            this.ResultadosmetroTabPage.Size = new System.Drawing.Size(969, 422);
            this.ResultadosmetroTabPage.TabIndex = 2;
            this.ResultadosmetroTabPage.Text = "Resultados";
            this.ResultadosmetroTabPage.VerticalScrollbarBarColor = true;
            this.ResultadosmetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ResultadosmetroTabPage.VerticalScrollbarSize = 6;
            // 
            // VerResultadosButton
            // 
            this.VerResultadosButton.Location = new System.Drawing.Point(51, 43);
            this.VerResultadosButton.Name = "VerResultadosButton";
            this.VerResultadosButton.Size = new System.Drawing.Size(93, 23);
            this.VerResultadosButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VerResultadosButton.TabIndex = 3;
            this.VerResultadosButton.Text = "Ver Resultados";
            this.VerResultadosButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VerResultadosButton.UseSelectable = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(272, 3);
            this.chart1.Name = "chart1";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(717, 404);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "Resultados";
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
            this.AJugarmetroTabPage.Text = "A Jugar";
            this.AJugarmetroTabPage.VerticalScrollbarBarColor = true;
            this.AJugarmetroTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.AJugarmetroTabPage.VerticalScrollbarSize = 6;
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
            this.ResultadosmetroTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage RegistrosMetroTabPage;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTabPage AJugarmetroTabPage;
        private MetroFramework.Controls.MetroTabPage ResultadosmetroTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton VerResultadosButton;
    }
}

