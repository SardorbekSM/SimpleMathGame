using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay
{
    public class AnswersManager : MonoBehaviour
    {
        [SerializeField] private List<ButtonManager> _buttonManagers;
        [SerializeField] private QuestionManager _questionManager;
        [SerializeField] private UnityEvent _correctAnswer;
        [SerializeField] private UnityEvent _wrongAnswer;
        
        public void CheckAnswer(int answer)
        {
            if (_questionManager.CheckAnswer(answer))
            {
                _correctAnswer.Invoke();
            }
            else
            {
                _wrongAnswer.Invoke();
            }
        }

        public void SetAnswersText()
        {
            var answers = _questionManager.Answers.ToArray();
            
            //there should be a answers shuffler here
            int i = 0;
            
            foreach (var buttonManager in _buttonManagers)
            {
                buttonManager.SetButtonName(answers[i++].ToString());
            }
        }
    }
}