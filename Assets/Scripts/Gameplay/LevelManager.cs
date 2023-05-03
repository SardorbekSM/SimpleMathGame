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
        [SerializeField] private TextManager _questionText;

        public void StatGame()
        {
            _questionManager.GenerateQuestion();
        }
    }
}