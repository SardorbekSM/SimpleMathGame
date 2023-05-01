using Core;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private int _step = 1;
        [SerializeField] private UnityIntEvent _scoreChanged;

        private int _score = 0;

        public int Score => _score;

        public void IncreaseScore()
        {
            _score += _step;
            _scoreChanged.Invoke(_score);
        }

        public void ResetScore()
        {
            _score = 0;
        }
    }
}