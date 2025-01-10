using System.Xml;
using ExerciciosESX.Exercicios;

namespace ExerciciosESxTests
{
    [TestClass]
    public sealed class ProgramaTest
    {
        [TestMethod]
        public void CheckEvenNumberTest()
        {
            ExercisesP chechEvenNumber = new ExercisesP();
            int evenNumber = 2;
            String even = "Even";
            String isEven = chechEvenNumber.checkEvenAndOddNumbers(evenNumber);
            Assert.AreEqual(isEven, even);
        }

        [TestMethod]
        public void CheckOddNumberTest()
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
            var expectedCounts = new Dictionary<char, int>
            {
                {'c', 2 },
                {'h', 1 },
                {'o', 2 },
                {'l', 1 },
                {'a', 1 },
                {'t', 1 },
                {'e', 1 }
            };

            var result = exercisesP.countChar(inputWord);
            CollectionAssert.AreEqual(expectedCounts, result, "The character count is incorrect");
        }

        [TestMethod]
        public void biggerNumberTest()
        {
            ExercisesP exercises = new ExercisesP();
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(2);
            numbers.Add(30);
            int expected = 30;
            int result = exercises.biggerNumber(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void orderingListTest()
        {
            ExercisesP exercises = new ExercisesP();
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Fulano");
            names.Add("Pepito");
            names.Add("Oscar");

            List<string> orderedNames = new List<string>();
            orderedNames.Add("Fulano");
            orderedNames.Add("John");
            orderedNames.Add("Oscar");
            orderedNames.Add("Pepito");
            List<String> result = exercises.orderingList(names);
            CollectionAssert.AreEqual(orderedNames, result);
        }
    }
}
