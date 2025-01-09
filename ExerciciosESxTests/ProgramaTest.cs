using System.Xml;
using ExerciciosESX.Exercicios;

namespace ExerciciosESxTests
{
    [TestClass]
    public sealed class ProgramaTest
    {
        [TestMethod]
        public void CheckEvenTestNumber()
        {
            ExercisesP chechEvenNumber = new ExercisesP();
            int evenNumber = 2;
            String even = "Even";
            String isEven = chechEvenNumber.checkEvenAndOddNumbers(evenNumber);
            Assert.AreEqual(isEven, even);
        }

        [TestMethod]
        public void CheckOddTestNumber()
        {
            ExercisesP chechOddNumber = new ExercisesP();
            int oddNumber = 3;
            String odd = "Odd";
            String isOdd = chechOddNumber.checkEvenAndOddNumbers(oddNumber);
            Assert.AreEqual(isOdd, odd);
        }

        [TestMethod]
        public void CheckPrimeNumberTest()
        {
            ExercisesP checkPrime = new ExercisesP();
            bool isPrime = checkPrime.checkPrimeNumber(10);
            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void InvertWordTest()
        {
            ExercisesP invertWord = new ExercisesP();
            String word = invertWord.invertWord("Omar");
            String InvertedWord = "ramO";
            Assert.AreEqual(word, InvertedWord);
        }
        [TestMethod]
        public void InsertionSortTest()
        {
            ExercisesP array = new ExercisesP();
            int[] numbers = { 7, 3, 21, 4 };
            array.insertionSort(numbers);
            int[] result = { 3, 4, 7, 21 };

            CollectionAssert.AreEqual(numbers, result);
        }
        [TestMethod]
        public void ShowVectorTest()
        {
            ExercisesP array = new ExercisesP();
            int[] numbers = { 3, 90, 20, 5 };
            String result = "[ 3 ][ 90 ][ 20 ][ 5 ]";

            var output = new StringWriter();
            Console.SetOut(output);

            array.showVector(numbers);

            Assert.AreEqual(result, output.ToString().Trim());

        }
        [TestMethod]
        public void CountCharTest()
        {
            ExercisesP exercisesP = new ExercisesP();
            string inputWord = "Chocolate";
            string expectedOutput = "\n[c][2]\n[h][1]\n[o][2]\n[l][1]\n[a][1]\n[t][1]\n[e][1]\n";

            var output = new StringWriter();
            Console.SetOut(output);

            exercisesP.countChar(inputWord);

            Assert.AreEqual(expectedOutput, output.ToString());

        }
    }
}
