using Math;
using UnityEngine;

namespace Gameplay
{
    [CreateAssetMenu(fileName = "QuestionData", menuName = "Gameplay/QuestionData", order = 0)]
    public class QuestionData : ScriptableObject
    {
        [SerializeField] private int _minRange;
        [SerializeField] private int _maxRange;

        [SerializeField] private Operation _operation;

        public Operation MathOperations => _operation;

        public int MinRange => _minRange;
        public int MaxRange => _maxRange;
    }
}