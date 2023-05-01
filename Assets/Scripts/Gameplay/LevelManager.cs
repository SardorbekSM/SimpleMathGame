using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private int _levelsCount = 5;
        [SerializeField] private int _currentLevel = 0;
        [SerializeField] private QuestionManager _questionManager;
        [SerializeField] private ScoreCounter _counter;
        [SerializeField] private SliderManager _sliderManager;
        [SerializeField] private TextManager _questionText;

        public void StatGame()
        {
            for (int i = 0; i < 5; i++)
            {
                var questionText = _questionManager.GenerateQuestion();
                
                _questionText.SetNewText(questionText);
            }
        }

        public void CheckAnswer(string answerText)
        {
            var answerInt = Int32.Parse(answerText);

            if (_questionManager.CheckAnswer(answerInt))
            {
                
            }
        }
    }
}