﻿using CsvHelper;

using QuizGame.Data;
using QuizGame.Data.Factories;
using System.Globalization;



namespace QuizGame.GUI.Import
{
    public class ImportQuestionFromCsv
    {

        public List<Question> Import(string filePath)
        {
            var streamReader = File.OpenText(filePath);
            var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);
            csvReader.GetRecords<Question>();
            List<Question> result = new();

            while (csvReader.Read())
            {
                //Walidacja zawartosci csvReader przed rozpoczeciem dodawania pytan
                var query = csvReader.GetField(0);
                var answerA = csvReader.GetField(1);
                var answerB = csvReader.GetField(2);
                var answerC = csvReader.GetField(3);
                var answerD = csvReader.GetField(4);
                var CorrectAnswer = csvReader.GetField(5);
                result.Add(new QuestionFactory().GetNew(query, CorrectAnswer, answerA, answerB, answerC, answerD));

            }

            return result;

        }
    }
}