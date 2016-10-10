using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageEdgeDetection
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNightFilter()
        {
            // Image de départ
            Bitmap nonFiltree = new Bitmap(TestMaxDavid.Properties.Resources.firefox);
            // Image filtrée auparavant, servant de référence
            Bitmap reference = new Bitmap(TestMaxDavid.Properties.Resources.firefox_night);
            // Utilisation de la méthode; l'image 'test' devrait être identique à l'image 'reference'
            Bitmap test = ImageFilters.ApplyFilter(new Bitmap(nonFiltree), 1, 1, 1, 25);

            // Tester la taille de l'image
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
        public void TestPrewitt()
        {
            // Image de départ
            Bitmap nonFiltree = new Bitmap(TestMaxDavid.Properties.Resources.firefox_night);
            // Image filtrée auparavant, servant de référence
            Bitmap reference = new Bitmap(TestMaxDavid.Properties.Resources.firefox_night_prewitt);
            // Utilisation de la méthode; l'image 'test' devrait être identique à l'image 'reference'
            Bitmap test = nonFiltree.PrewittFilter(false);

            // Tester la taille de l'image
            Assert.AreEqual(reference.Size, test.Size);

            // Boucles sur les pixels
            for (int i = 0; i < test.Width; i++)
                for (int j = 0; j < test.Height; j++)
                    Assert.AreEqual(reference.Size, test.Size);

        }
    }
}
