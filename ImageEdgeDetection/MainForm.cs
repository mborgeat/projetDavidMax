﻿/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageEdgeDetection
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        System.Drawing.Image Origin;
        Color SecondPicBrush;

        public MainForm()
        {
            InitializeComponent();

            cmbEdgeDetection.SelectedIndex = 0;
            SecondPicBrush = Color.Black;
            Origin = picPreview.Image;
            previewBitmap = (Bitmap)picPreview.Image;
        }

        //action clique sur bouton load image
        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                picPreview.Image = previewBitmap;

                ApplyFilter(true);
            }
        }

        //action clique sur bouton save image
        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            ApplyFilter(false);

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //modification des filtres de format de fichiers, l'ancienne version étant buggée
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }

        //action clique sur choix de filtre de contour d'image (preview = true si on affiche, false si on enregistre)
        private void ApplyFilter(bool preview)
        {
            if (previewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }

            // Si aucun détecteur de bord n'est sélectionné (1re ligne = "None")
            if (cmbEdgeDetection.SelectedIndex == 0)
            {
                // Active tous les boutons
                ActivateFilterButtons(true);
            }
            else
            {
                // Inactive tous les boutons
                ActivateFilterButtons(false);
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            // Contrairement à la version de base, on travaille toujours sur l'image previewBitmap, pas sur originalBitmap
            selectedSource = previewBitmap;

            if (selectedSource != null)
            {
                if (cmbEdgeDetection.SelectedItem.ToString() == "None")
                {
                    bitmapResult = selectedSource;
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian3x3Filter(true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 Grayscale")
                {
                    bitmapResult = selectedSource.Laplacian5x5Filter(true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian of Gaussian")
                {
                    bitmapResult = selectedSource.LaplacianOfGaussianFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 3x3 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian3x3OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 3x3")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 1")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Laplacian 5x5 of Gaussian 5x5 - 2")
                {
                    bitmapResult = selectedSource.Laplacian5x5OfGaussian5x5Filter2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Sobel 3x3 Grayscale")
                {
                    bitmapResult = selectedSource.Sobel3x3Filter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt")
                {
                    bitmapResult = selectedSource.PrewittFilter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Prewitt Grayscale")
                {
                    bitmapResult = selectedSource.PrewittFilter();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch")
                {
                    bitmapResult = selectedSource.KirschFilter(false);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "Kirsch Grayscale")
                {
                    bitmapResult = selectedSource.KirschFilter();
                }
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    picPreview.Image = bitmapResult;
                    Origin = picPreview.Image;
                }
                else
                {
                    resultBitmap = bitmapResult;
                }
            }
        }

        private void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }


        //action clique sur bouton choix de couleur
        private void buttonChoiceColor_Click(object sender, EventArgs e)
        {
            OpenColorDialog();
        }



        #region MACHADO_ApplyFilters
        
        //action clique sur bouton Night Filter
        private void buttonNightFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            picPreview.Image = ImageFilters.ApplyFilter(new Bitmap(picPreview.Image), 1, 1, 1, 25);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Hell Filter
        private void buttonHellFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = ImageFilters.ApplyFilter(new Bitmap(picPreview.Image), 1, 1, 10, 15);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Miami Filter
        private void buttonMiamiFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            picPreview.Image = ImageFilters.ApplyFilter(new Bitmap(picPreview.Image), 1, 1, 10, 1);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Zen Filter
        private void buttonZenFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            picPreview.Image = ImageFilters.ApplyFilter(new Bitmap(picPreview.Image), 1, 10, 1, 1);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Black and white
        private void buttonBlackAndWhite_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            picPreview.Image = ImageFilters.BlackWhite(new Bitmap(picPreview.Image));
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Swap Filter
        private void buttonSwapFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            picPreview.Image = ImageFilters.ApplyFilterSwap(new Bitmap(picPreview.Image));
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Crazy Filter
        private void buttonCrazyFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            System.Drawing.Image te = ImageFilters.ApplyFilterSwapDivide(new Bitmap(picPreview.Image), 1, 1, 2, 1);
            picPreview.Image = ImageFilters.ApplyFilterSwap(new Bitmap(te));
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Filter Green
        private void buttonMegaFilterGreen_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            Color c = Color.Green;
            picPreview.Image = ImageFilters.ApplyFilterMega(new Bitmap(picPreview.Image), 230, 110, c);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Filter Orange
        private void buttonMegaFilterOrange_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            Color c = Color.Orange;
            picPreview.Image = ImageFilters.ApplyFilterMega(new Bitmap(picPreview.Image), 230, 110, c);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Filter Pink
        private void buttonMegaFilterPink_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;          // Cette ligne manque dans le programme PictureBox
            Color c = Color.Pink;
            picPreview.Image = ImageFilters.ApplyFilterMega(new Bitmap(picPreview.Image), 230, 110, c);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Filter Custom
        private void buttonMegaFilterCustom_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            picPreview.Image = ImageFilters.ApplyFilterMega(new Bitmap(picPreview.Image), 230, 110, SecondPicBrush);
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }

        //action clique sur bouton Filter Rainbow
        private void buttonRainbowFilter_Click(object sender, EventArgs e)
        {
            picPreview.Image = Origin;
            picPreview.Image = ImageFilters.RainbowFilter(new Bitmap(picPreview.Image));
            previewBitmap = (Bitmap)picPreview.Image;
            resultBitmap = previewBitmap;
        }



        #endregion

        //fonction palette de couleur pour choix
        public void OpenColorDialog()
        {
            ColorDialog CD = new ColorDialog();
            CD.ShowDialog();
            Color newC = CD.Color;
            SecondPicBrush = newC;
        }

        // Method for activate or inactivate the Filters Buttons
        public void ActivateFilterButtons(bool active)
        {
            buttonNightFilter.Enabled = active;
            buttonHellFilter.Enabled = active;
            buttonMiamiFilter.Enabled = active;
            buttonZenFilter.Enabled = active;
            buttonBlackAndWhite.Enabled = active;
            buttonSwapFilter.Enabled = active;
            buttonCrazyFilter.Enabled = active;
            buttonMegaFilterGreen.Enabled = active;
            buttonMegaFilterOrange.Enabled = active;
            buttonMegaFilterPink.Enabled = active;
            buttonMegaFilterCustom.Enabled = active;
            buttonRainbowFilter.Enabled = active;
            buttonChoiceColor.Enabled = active;
        }  
    }
}
