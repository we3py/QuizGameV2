namespace QuizGame.GUI.Import
{
    public class ImportQuestionFromCsv
    {
#pragma warning disable CA1822
        public List<Question> Import(string filePath)
#pragma warning restore CA1822
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                Delimiter = ";",
            };
            var streamReader = File.OpenText(filePath);
            var csvReader = new CsvReader(streamReader, csvConfig);
            csvReader.GetRecords<Question>();
            return GenerateQuestionList(csvReader);
        }

        private static List<Question> GenerateQuestionList(CsvReader csvReader)
        {
            List<Question> result = new();

            while (csvReader.Read())
            {
                if (QuestionValidation.Validate(csvReader))
                {
                    var query = csvReader.GetField(0);
                    var answerA = csvReader.GetField(1);
                    var answerB = csvReader.GetField(2);
                    var answerC = csvReader.GetField(3);
                    var answerD = csvReader.GetField(4);
                    var CorrectAnswer = csvReader.GetField(5);
                    result.Add(new QuestionFactory().GetNew(query, CorrectAnswer, answerA, answerB, answerC, answerD));
                }
            }

            return result;
        }
    }
}
