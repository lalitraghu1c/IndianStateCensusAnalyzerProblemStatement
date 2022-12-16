using IndianStateCensusAnalyzerProblem;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace IndianStateCensusAnalyzerTestPoblem
{
    public class Tests
    {
        public string stateCencusFilePath = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\StateCensusData.csv";
        public string stateCencusIncorrectFilePath = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\";
        public string typeIncorrectFilePath = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\DemoTxt.txt";
        public string delimeterFilePath = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\CSVStateCencusDelimeter.csv";
        public string stateCodeFilePath = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\StateCode.csv";
        public string stateCodeIncorrectFilePath = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\";
        public string typeIncorrectFilePath1 = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\DemoTxt.txt";
        public string delimeterFilePath1 = @"D:\Projects-Bridgelabz\IndianStateCensusAnalyzerProblemStatement\IndianStateCensusAnalyzerProblem\Files\CSVStateCodeDelimeter.csv";

        [Test]
        public void GivenStateCencusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            IndianCencusAnalyzer analyzerProblem = new IndianCencusAnalyzer();
            CSVStateCencus cSVState = new CSVStateCencus();
            Assert.AreEqual(cSVState.ReadStateCensusData(stateCencusFilePath), analyzerProblem.ReadStateCensusData(stateCencusFilePath));
        }
        [Test]
        public void GivenStateCencusDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(stateCencusIncorrectFilePath);
            }
            catch (StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }

        }
        [Test]
        public void GivenStateCencusDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(typeIncorrectFilePath);
            }
            catch (StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Type Incorrect");
            }
        }

        [Test]
        public void GivenStateCencusDataFileDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(delimeterFilePath);
            }
            catch (StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delimeter");
            }
        }

        [Test]
        public void GivenStateCencusDataFileHeaderIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer indianCencusAnalyzer = new IndianCencusAnalyzer();
            try
            {
                bool records = indianCencusAnalyzer.ReadStateCencusData(delimeterFilePath, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.IsTrue(records);
            }
            catch (StateCencusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
        [Test]
        public void GivenStateCodeData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            IndianCencusAnalyzer analyzerProblem = new IndianCencusAnalyzer();
            CSVStateCode cSVState = new CSVStateCode();
            Assert.AreEqual(cSVState.ReadStateCodeData(stateCodeFilePath), analyzerProblem.ReadStateCodeData(stateCodeFilePath));
        }
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCodeData(stateCodeIncorrectFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }

        }
        [Test]
        public void GivenStateCodeDataFileTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCodeData(typeIncorrectFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Type Incorrect");
            }
        }

        [Test]
        public void GivenStateCodeDataFileDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer analyzer = new IndianCencusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCodeData(delimeterFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delimeter");
            }
        }

        [Test]
        public void GivenStateCodeDataFileHeaderIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            IndianCencusAnalyzer indianCencusAnalyzer = new IndianCencusAnalyzer();
            try
            {
                bool records = indianCencusAnalyzer.ReadStateCodeData(delimeterFilePath, "SrNo, State, TIN, StateCode");
                Assert.IsTrue(records);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
    }
}