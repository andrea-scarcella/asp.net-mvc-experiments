using System;
namespace MultipleChoiceQuestions.BL
{
    public interface ITaaltestRepository
    {
        Taaltest getTest(DateTime date);
    }
}
