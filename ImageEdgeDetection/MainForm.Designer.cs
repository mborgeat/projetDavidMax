namespace ImageEdgeDetection
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.buttonNightFilter = new System.Windows.Forms.Button();
            this.buttonHellFilter = new System.Windows.Forms.Button();
            this.buttonMiamiFilter = new System.Windows.Forms.Button();
            this.buttonZenFilter = new System.Windows.Forms.Button();
            this.buttonBlackAndWhite = new System.Windows.Forms.Button();
            this.buttonSwapFilter = new System.Windows.Forms.Button();
            this.buttonCrazyFilter = new System.Windows.Forms.Button();
            this.buttonMegaFilterGreen = new System.Windows.Forms.Button();
            this.buttonMegaFilterOrange = new System.Windows.Forms.Button();
            this.buttonMegaFilterPink = new System.Windows.Forms.Button();
            this.buttonMegaFilterCustom = new System.Windows.Forms.Button();
            this.buttonRainbowFilter = new System.Windows.Forms.Button();
            this.buttonChoiceColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Image = global::ImageEdgeDetection.Properties.Resources.firefox;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(600, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 618);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(150, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(462, 618);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(150, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeDetection.FormattingEnabled = true;
            this.cmbEdgeDetection.Items.AddRange(new object[] {
            "None",
            "Laplacian 3x3",
            "Laplacian 3x3 Grayscale",
            "Laplacian 5x5",
            "Laplacian 5x5 Grayscale",
            "Laplacian of Gaussian",
            "Laplacian 3x3 of Gaussian 3x3",
            "Laplacian 3x3 of Gaussian 5x5 - 1",
            "Laplacian 3x3 of Gaussian 5x5 - 2",
            "Laplacian 5x5 of Gaussian 3x3",
            "Laplacian 5x5 of Gaussian 5x5 - 1",
            "Laplacian 5x5 of Gaussian 5x5 - 2",
            "Sobel 3x3",
            "Sobel 3x3 Grayscale",
            "Prewitt",
            "Prewitt Grayscale",
            "Kirsch",
            "Kirsch Grayscale"});
            this.cmbEdgeDetection.Location = new System.Drawing.Point(168, 627);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(288, 32);
            this.cmbEdgeDetection.TabIndex = 20;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.NeighbourCountValueChangedEventHandler);
            // 
            // buttonNightFilter
            // 
            this.buttonNightFilter.Location = new System.Drawing.Point(618, 58);
            this.buttonNightFilter.Name = "buttonNightFilter";
            this.buttonNightFilter.Size = new System.Drawing.Size(151, 40);
            this.buttonNightFilter.TabIndex = 22;
            this.buttonNightFilter.Text = "Night Filter";
            this.buttonNightFilter.UseVisualStyleBackColor = true;
            this.buttonNightFilter.Click += new System.EventHandler(this.buttonNightFilter_Click);
            // 
            // buttonHellFilter
            // 
            this.buttonHellFilter.Location = new System.Drawing.Point(618, 104);
            this.buttonHellFilter.Name = "buttonHellFilter";
            this.buttonHellFilter.Size = new System.Drawing.Size(151, 40);
            this.buttonHellFilter.TabIndex = 23;
            this.buttonHellFilter.Text = "Hell Filter";
            this.buttonHellFilter.UseVisualStyleBackColor = true;
            this.buttonHellFilter.Click += new System.EventHandler(this.buttonHellFilter_Click);
            // 
            // buttonMiamiFilter
            // 
            this.buttonMiamiFilter.Location = new System.Drawing.Point(618, 150);
            this.buttonMiamiFilter.Name = "buttonMiamiFilter";
            this.buttonMiamiFilter.Size = new System.Drawing.Size(151, 40);
            this.buttonMiamiFilter.TabIndex = 24;
            this.buttonMiamiFilter.Text = "Miami Filter";
            this.buttonMiamiFilter.UseVisualStyleBackColor = true;
            this.buttonMiamiFilter.Click += new System.EventHandler(this.buttonMiamiFilter_Click);
            // 
            // buttonZenFilter
            // 
            this.buttonZenFilter.Location = new System.Drawing.Point(618, 196);
            this.buttonZenFilter.Name = "buttonZenFilter";
            this.buttonZenFilter.Size = new System.Drawing.Size(151, 40);
            this.buttonZenFilter.TabIndex = 25;
            this.buttonZenFilter.Text = "Zen Filter";
            this.buttonZenFilter.UseVisualStyleBackColor = true;
            this.buttonZenFilter.Click += new System.EventHandler(this.buttonZenFilter_Click);
            // 
            // buttonBlackAndWhite
            // 
            this.buttonBlackAndWhite.Location = new System.Drawing.Point(618, 242);
            this.buttonBlackAndWhite.Name = "buttonBlackAndWhite";
            this.buttonBlackAndWhite.Size = new System.Drawing.Size(151, 40);
            this.buttonBlackAndWhite.TabIndex = 26;
            this.buttonBlackAndWhite.Text = "Black and White";
            this.buttonBlackAndWhite.UseVisualStyleBackColor = true;
            this.buttonBlackAndWhite.Click += new System.EventHandler(this.buttonBlackAndWhite_Click);
            // 
            // buttonSwapFilter
            // 
            this.buttonSwapFilter.Location = new System.Drawing.Point(618, 288);
            this.buttonSwapFilter.Name = "buttonSwapFilter";
            this.buttonSwapFilter.Size = new System.Drawing.Size(151, 40);
            this.buttonSwapFilter.TabIndex = 27;
            this.buttonSwapFilter.Text = "Swap Filter";
            this.buttonSwapFilter.UseVisualStyleBackColor = true;
            this.buttonSwapFilter.Click += new System.EventHandler(this.buttonSwapFilter_Click);
            // 
            // buttonCrazyFilter
            // 
            this.buttonCrazyFilter.Location = new System.Drawing.Point(618, 334);
            this.buttonCrazyFilter.Name = "buttonCrazyFilter";
            this.buttonCrazyFilter.Size = new System.Drawing.Size(151, 40);
            this.buttonCrazyFilter.TabIndex = 28;
            this.buttonCrazyFilter.Text = "Crazy Filter";
            this.buttonCrazyFilter.UseVisualStyleBackColor = true;
            this.buttonCrazyFilter.Click += new System.EventHandler(this.buttonCrazyFilter_Click);
            // 
            // buttonMegaFilterGreen
            // 
            this.buttonMegaFilterGreen.Location = new System.Drawing.Point(618, 380);
            this.buttonMegaFilterGreen.Name = "buttonMegaFilterGreen";
            this.buttonMegaFilterGreen.Size = new System.Drawing.Size(151, 40);
            this.buttonMegaFilterGreen.TabIndex = 29;
            this.buttonMegaFilterGreen.Text = "Mega Filter Green";
            this.buttonMegaFilterGreen.UseVisualStyleBackColor = true;
            this.buttonMegaFilterGreen.Click += new System.EventHandler(this.buttonMegaFilterGreen_Click);
            // 
            // buttonMegaFilterOrange
            // 
            this.buttonMegaFilterOrange.Location = new System.Drawing.Point(618, 426);
            this.buttonMegaFilterOrange.Name = "buttonMegaFilterOrange";
            this.buttonMegaFilterOrange.Size = new System.Drawing.Size(151, 40);
            this.buttonMegaFilterOrange.TabIndex = 30;
            this.buttonMegaFilterOrange.Text = "Mega Filter Orange";
            this.buttonMegaFilterOrange.UseVisualStyleBackColor = true;
            this.buttonMegaFilterOrange.Click += new System.EventHandler(this.buttonMegaFilterOrange_Click);
            // 
            // buttonMegaFilterPink
            // 
            this.buttonMegaFilterPink.Location = new System.Drawing.Point(618, 472);
            this.buttonMegaFilterPink.Name = "buttonMegaFilterPink";
            this.buttonMegaFilterPink.Size = new System.Drawing.Size(151, 40);
            this.buttonMegaFilterPink.TabIndex = 31;
            this.buttonMegaFilterPink.Text = "Mega Filter Pink";
            this.buttonMegaFilterPink.UseVisualStyleBackColor = true;
            this.buttonMegaFilterPink.Click += new System.EventHandler(this.buttonMegaFilterPink_Click);
            // 
            // buttonMegaFilterCustom
            // 
            this.buttonMegaFilterCustom.Location = new System.Drawing.Point(618, 518);
            this.buttonMegaFilterCustom.Name = "buttonMegaFilterCustom";
            this.buttonMegaFilterCustom.Size = new System.Drawing.Size(151, 40);
            this.buttonMegaFilterCustom.TabIndex = 32;
            this.buttonMegaFilterCustom.Text = "Mega Filter Custom";
            this.buttonMegaFilterCustom.UseVisualStyleBackColor = true;
            this.buttonMegaFilterCustom.Click += new System.EventHandler(this.buttonMegaFilterCustom_Click);
            // 
            // buttonRainbowFilter
            // 
            this.buttonRainbowFilter.Location = new System.Drawing.Point(618, 12);
            this.buttonRainbowFilter.Name = "buttonRainbowFilter";
            this.buttonRainbowFilter.Size = new System.Drawing.Size(151, 40);
            this.buttonRainbowFilter.TabIndex = 33;
            this.buttonRainbowFilter.Text = "Rainbow Filter";
            this.buttonRainbowFilter.UseVisualStyleBackColor = true;
            this.buttonRainbowFilter.Click += new System.EventHandler(this.buttonRainbowFilter_Click);
            // 
            // buttonChoiceColor
            // 
            this.buttonChoiceColor.Location = new System.Drawing.Point(618, 564);
            this.buttonChoiceColor.Name = "buttonChoiceColor";
            this.buttonChoiceColor.Size = new System.Drawing.Size(151, 100);
            this.buttonChoiceColor.TabIndex = 34;
            this.buttonChoiceColor.Text = "Choisir la couleur du filtre custom";
            this.buttonChoiceColor.UseVisualStyleBackColor = true;
            this.buttonChoiceColor.Click += new System.EventHandler(this.buttonChoiceColor_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(781, 674);
            this.Controls.Add(this.buttonChoiceColor);
            this.Controls.Add(this.buttonRainbowFilter);
            this.Controls.Add(this.buttonMegaFilterCustom);
            this.Controls.Add(this.buttonMegaFilterPink);
            this.Controls.Add(this.buttonMegaFilterOrange);
            this.Controls.Add(this.buttonMegaFilterGreen);
            this.Controls.Add(this.buttonCrazyFilter);
            this.Controls.Add(this.buttonSwapFilter);
            this.Controls.Add(this.buttonBlackAndWhite);
            this.Controls.Add(this.buttonZenFilter);
            this.Controls.Add(this.buttonMiamiFilter);
            this.Controls.Add(this.buttonHellFilter);
            this.Controls.Add(this.buttonNightFilter);
            this.Controls.Add(this.cmbEdgeDetection);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Edge Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.Button buttonNightFilter;
        private System.Windows.Forms.Button buttonHellFilter;
        private System.Windows.Forms.Button buttonMiamiFilter;
        private System.Windows.Forms.Button buttonZenFilter;
        private System.Windows.Forms.Button buttonBlackAndWhite;
        private System.Windows.Forms.Button buttonSwapFilter;
        private System.Windows.Forms.Button buttonCrazyFilter;
        private System.Windows.Forms.Button buttonMegaFilterGreen;
        private System.Windows.Forms.Button buttonMegaFilterOrange;
        private System.Windows.Forms.Button buttonMegaFilterPink;
        private System.Windows.Forms.Button buttonMegaFilterCustom;
        private System.Windows.Forms.Button buttonRainbowFilter;
        private System.Windows.Forms.Button buttonChoiceColor;
    }
}

