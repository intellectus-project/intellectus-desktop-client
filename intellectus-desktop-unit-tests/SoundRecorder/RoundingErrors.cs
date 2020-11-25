using EmotionRecognition.Wrapper;
using intellectus_desktop_client.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests.SoundRecorder
{
    [TestClass]
    public class RoundingErrors
    {

        [TestMethod]
        public void TestPerfectRounding()
        {
            CollectionAssert.AreEqual(EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 3.333, 3.334, 3.333 }, 10, 2),
                new List<double> { 3.33, 3.34, 3.33 });

            CollectionAssert.AreEqual(EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 3.33, 3.34, 3.33 }, 10, 1),
                new List<double> { 3.3, 3.4, 3.3 });

            CollectionAssert.AreEqual(EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 3.333, 3.334, 3.333 }, 10, 1),
                new List<double> { 3.3, 3.4, 3.3 });


            CollectionAssert.AreEqual(EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 13.626332, 47.989636, 9.596008, 28.788024 }, 100, 0),
                new List<double> { 14, 48, 9, 29 });
            CollectionAssert.AreEqual(EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 16.666, 16.666, 16.666, 16.666, 16.666, 16.666 }, 100, 0),
                new List<double> { 17, 17, 17, 17, 16, 16 });
            CollectionAssert.AreEqual(EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 33.333, 33.333, 33.333 }, 100, 0),
                new List<double> { 34, 33, 33 });
            CollectionAssert.AreEqual(EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 33.3, 33.3, 33.3, 0.1 }, 100, 0),
                new List<double> { 34, 33, 33, 0 });

            var result = EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 0.35155156146, 0.35664755, 0.35151, 0.51345, 0.54115 }, 1.0, 5);

            CollectionAssert.AreNotEqual(result, new List<double> { 0, 0, 0, 0, 0 });


            var result2 = EmotionsProbabilities.GetPerfectRounding(
                new List<double> { 0.5, 0.5, 0.0, 0.0, 0.0 }, 1.0, 5);

            CollectionAssert.Contains(result2, 1.0);
        }
    }
}
