using EmotionRecognition.Wrapper;
using intellectus_desktop_unit_tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suggestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_unit_tests.Suggestions
{
    [TestClass]
    public class BaseGraph
    {
        [TestMethod]
        public void SuggestionsMatchForNormalGraph()
        {
            List<Suggestion> output = new List<Suggestion>();

            var system = new MockedSuggestionsSystem();

            var listener = new OutputListener((s) => output.Add(s));
            system.Subscribe(listener);

            var probabilities = new EmotionsProbabilities();
            probabilities.Happiness = 0.6;
            var result = Generate(probabilities);

            var probabilities2 = new EmotionsProbabilities();
            probabilities2.Happiness = 0.2;
            var result2 = Generate(probabilities2);

            system.ExtractionAvailable(result);
            system.ExtractionAvailable(result2);

            Assert.IsTrue(Enumerable.SequenceEqual(output, MockedSuggestionsSystem.Suggestions.Take(2)));
        }

        [TestMethod]
        public void SuggestionsAreNotRepeated()
        {
            List<Suggestion> output = new List<Suggestion>();

            var system = new MockedSuggestionsSystem();

            var listener = new OutputListener((s) => output.Add(s));
            system.Subscribe(listener);

            var probabilities = new EmotionsProbabilities();
            probabilities.Happiness = 0.6;
            var result = Generate(probabilities);

            var probabilities2 = new EmotionsProbabilities();
            probabilities2.Happiness = 0.9;
            var result2 = Generate(probabilities2);

            system.ExtractionAvailable(result);
            system.ExtractionAvailable(result2);

            var suggestionsAreNotTheSame = !Enumerable.SequenceEqual(output, MockedSuggestionsSystem.Suggestions);
            var suggestionsCount = output.Count == 1;
            Assert.IsTrue(suggestionsAreNotTheSame && suggestionsCount);
        }

        [TestMethod]
        public void LastVerticesMatch()
        {
            List<Suggestion> output = new List<Suggestion>();

            var system = new MockedSuggestionsSystem();

            var listener = new OutputListener((s) => output.Add(s));
            system.Subscribe(listener);

            var probabilities = new EmotionsProbabilities();
            probabilities.Happiness = 0.6;
            var result = Generate(probabilities);

            var probabilities2 = new EmotionsProbabilities();
            probabilities2.Happiness = 0.1;
            var result2 = Generate(probabilities2);

            var probabilities3 = new EmotionsProbabilities();
            probabilities3.Happiness = 0.9;
            probabilities3.Fear = 0.2;
            var result3 = Generate(probabilities3);

            system.ExtractionAvailable(result);
            system.ExtractionAvailable(result2);
            system.ExtractionAvailable(result3);
            system.ExtractionAvailable(result3);

            Assert.IsTrue(Enumerable.SequenceEqual(output, MockedSuggestionsSystem.Suggestions));
        }


        private VoiceFeatureExtractionResult Generate(EmotionsProbabilities probabilities)
        {
            return new VoiceFeatureExtractionResult(new ExtractionQuality(), probabilities);
        }

        public class OutputListener : ISuggestionsListener
        {
            private Action<Suggestion> action;

            public OutputListener(Action<Suggestion> action)
            {
                this.action = action;
            }

            public void SuggestionAvailable(Suggestion suggestion)
            {
                action.Invoke(suggestion);
            }
        }

    }
}
