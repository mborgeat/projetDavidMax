﻿using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageEdgeDetection
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNightFilterSize()
        {
            // Test de la méthode ApplyFilter (filtre 'Night Filter'). L'image de retour doit avoir la même taille que celle de départ.

            // Image de départ
            Bitmap nonFiltree = new Bitmap(TestMaxDavid.Properties.Resources.firefox);
            
            // Image filtrée
            Bitmap test = ImageFilters.ApplyFilter(new Bitmap(nonFiltree), 1, 1, 1, 25);

            // Test : on compare les tailles des images de départ et d'arrivée.
            Assert.AreEqual(nonFiltree.Width, test.Width);
            Assert.AreEqual(nonFiltree.Height, test.Height);
        }
        [TestMethod]
        public void TestNightFilter()
        {
            // Test de la méthode ApplyFilter pour le filtre 'Night Filter' avec images de départ et d'arrivée

            // Image de départ
            Bitmap nonFiltree = new Bitmap(TestMaxDavid.Properties.Resources.firefox);
            // Image filtrée auparavant, servant de référence
            Bitmap reference = new Bitmap(TestMaxDavid.Properties.Resources.firefox_night);
            // Utilisation de la méthode; l'image 'test' devrait être identique à l'image 'reference'
            Bitmap test = ImageFilters.ApplyFilter(new Bitmap(nonFiltree), 1, 1, 1, 25);

            // Tester la taille de l'image; si pas égale, il ne sera pas possible de boucler sur lignes et colonnes
            Assert.AreEqual(test.Size, reference.Size);

            // Boucles sur les pixels; cela a du sens puisque les deux images ont la même taille
            for (int i = 0; i < test.Width; i++)
            {
                for (int j = 0; j < test.Height; j++)
                {
                    Assert.AreEqual(reference.GetPixel(i, j), test.GetPixel(i, j));
                }
            }
        }
        [TestMethod]
        public void TestNightFilterNull()
        {
            // Test de la méthode ApplyFilter (pour le filtre 'night filter') avec une image nulle

            // Image de départ nulle
            Bitmap nonFiltree = null;

            // Test de la méthode sur une image nulle : doit renvoyer null
            Assert.AreEqual(null, ImageFilters.ApplyFilter(nonFiltree, 1, 1, 1, 25));
        }
        [TestMethod]
        public void TestPrewittSize()
        {
            // Test de la méthode Prewitt. L'image de retour doit avoir la même taille que celle de départ.

            // Image de départ
            Bitmap nonFiltree = new Bitmap(TestMaxDavid.Properties.Resources.firefox);

            // Image filtrée
            Bitmap test = nonFiltree.PrewittFilter(false);

            // Test : on compare les tailles des images de départ et d'arrivée.
            Assert.AreEqual(nonFiltree.Width, test.Width);
            Assert.AreEqual(nonFiltree.Height, test.Height);
        }

        [TestMethod]
        public void TestPrewitt()
        {
            // Test de la méthode prewittfilter avec images de départ et d'arrivée

            // Image de départ
            Bitmap nonFiltree = new Bitmap(TestMaxDavid.Properties.Resources.firefox_night);
            // Image filtrée auparavant, servant de référence
            Bitmap reference = new Bitmap(TestMaxDavid.Properties.Resources.firefox_night_prewitt);
            // Utilisation de la méthode; l'image 'test' devrait être identique à l'image 'reference'
            Bitmap test = nonFiltree.PrewittFilter(false);

            // Tester la taille de l'image. Si pas égale, il ne sera pas possible de boucler sur lignes et colonnes
            Assert.AreEqual(reference.Size, test.Size);

            // Boucles sur les pixels
            for (int i = 0; i < test.Width; i++)
                for (int j = 0; j < test.Height; j++)
                    Assert.AreEqual(reference.Size, test.Size);

        }
        
        [TestMethod]
        public void TestPrewittNull()
        {
            // Test de la méthode de détection de bords Prewitt avec une image nulle

            // Image de départ nulle;
            Bitmap nonFiltree = null;

            // Test de la méthode sur une image nulle : doit renvoyer null
            Assert.AreEqual(null, nonFiltree.PrewittFilter(false));
        }

    }
}
