using System;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Math;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Gameplay
{
    public class QuestionManager : MonoBehaviour
    {
        [SerializeField] private QuestionData _questionData;
        [SerializeField] private RandomNumberGenerator _randomizer;
        [SerializeField] private UnityStringEvent _questionText;

        private int _leftTerm;
        private int _rightTerm;
        private int _solve;

        public string GenerateQuestion()
        {
            _randomizer.SetMinMaxRange(_questionData.MinRange, _questionData.MaxRange);

            _leftTerm = _randomizer.GetUniqueRandom();
            _rightTerm = _randomizer.GetUniqueRandom();

            _solve = SolveAnswer(_leftTerm, _rightTerm, _questionData.MathOperations);
            
            return $"{_leftTerm} {GetOperationSymbol(_questionData.MathOperations)} {_rightTerm} = ?";
        }

        public int[] GenerateWrongAnswers(int rightAnswer)
        {
            var wrongAnswers = new List<int>
            {
                Random.Range(rightAnswer - 3, rightAnswer + 3),
                Random.Range(rightAnswer - 3, rightAnswer + 3),
                Random.Range(rightAnswer - 3, rightAnswer + 3)
            };

            return wrongAnswers.ToArray();
        }

        public bool CheckAnswer(int answer)
        {
            return answer == _solve;
        }

        private static int SolveAnswer(int leftTerm, int rightTerm, Operation operation)
        {
            switch (operation)
            {
                case Operation.Addition:
                    return leftTerm + rightTerm;
                case Operation.Subtraction:
                    return leftTerm - rightTerm;
                case Operation.Multiply:
                    return leftTerm * rightTerm;
                case Operation.Divide: 
                    return leftTerm / rightTerm;
                default: return 0;
            }
        }

        private static string GetOperationSymbol(Operation operation)
        {
            switch (operation)
            {
                case Operation.Addition:
                    return "+";
                case Operation.Subtraction:
                    return "-";
                case Operation.Multiply:
                    return "*";
                case Operation.Divide:
                    return ":";
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
