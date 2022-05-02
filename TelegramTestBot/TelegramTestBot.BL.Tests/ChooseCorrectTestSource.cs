﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramTestBot.BL.Tests
{
    public class ChooseCorrectTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractQuestions question;
            AbstractQuestions expected_question;
            string correct_answer = "Ilya";
            question = new AbstractQuestions("Kak Tebya zovut?");
            expected_question = new AbstractQuestions("Kak Tebya zovut?");
            question.Answers = new List<string> { "Petya", "Sasha", "Ilya", "Vova" };
            expected_question.Answers = new List<string> { "Petya", "Sasha", "Ilya", "Vova" };
            question.UsersAnswers = new List<string> { "Ilya", "Vova" };
            expected_question.UsersAnswers = new List<string> { "Ilya", "Vova" };
            expected_question.CorrectAnswer = correct_answer;
            yield return new object[] {question,expected_question,correct_answer};
            correct_answer = "Kotik";
            question = new AbstractQuestions("Ti kto?");
            expected_question = new AbstractQuestions("Ti kto?");
            question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha" };
            expected_question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha" };
            question.UsersAnswers = new List<string> { "Utka", "Kotik" };
            expected_question.UsersAnswers = new List<string> { "Utka", "Kotik" };
            expected_question.CorrectAnswer = "Kotik";
            yield return new object[] {question,expected_question,correct_answer};
            correct_answer = "Pesik";
            question = new AbstractQuestions("Ti kto?");
            expected_question = new AbstractQuestions("Ti kto?");
            question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha" };
            expected_question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha" };
            question.UsersAnswers = new List<string> { "Utka", "Kotik" };
            expected_question.UsersAnswers = new List<string> { "Utka", "Kotik" };
            expected_question.CorrectAnswer = "Pesik";
            yield return new object[] { question, expected_question, correct_answer };

        }
    }
    public class AddAnswerTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            AbstractQuestions question;
            AbstractQuestions expected_question;
            string new_answer;


            new_answer = "Maksim";
            question = new AbstractQuestions("Kak Tebya zovut?");
            expected_question = new AbstractQuestions("Kak Tebya zovut?");

            question.Answers = new List<string> { "Petya", "Sasha", "Ilya", "Vova" };
            expected_question.Answers = new List<string> { "Petya", "Sasha", "Ilya", "Vova", "Maksim" };

            question.UsersAnswers = new List<string> { "Ilya", "Vova" };
            expected_question.UsersAnswers = new List<string> { "Ilya", "Vova" };
            yield return new object[] { question, expected_question, new_answer };


            new_answer = "Zaichik";
            question = new AbstractQuestions("Ti kto?");
            expected_question = new AbstractQuestions("Ti kto?");

            question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha" };
            expected_question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha", "Zaichik" };

            question.UsersAnswers = new List<string> { "Utka", "Kotik" };
            expected_question.UsersAnswers = new List<string> { "Utka", "Kotik" };

            yield return new object[] { question, expected_question, new_answer };


            new_answer = "Homyak";
            question = new AbstractQuestions("Ti kto?");
            expected_question = new AbstractQuestions("Ti kto?");

            question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha" };
            expected_question.Answers = new List<string> { "Kotik", "Pesik", "Utka", "Cherepaha", "Homyak" };

            question.UsersAnswers = new List<string> { "Utka", "Kotik" };
            expected_question.UsersAnswers = new List<string> { "Utka", "Kotik" };

            yield return new object[] { question, expected_question, new_answer };

        }
    }

}