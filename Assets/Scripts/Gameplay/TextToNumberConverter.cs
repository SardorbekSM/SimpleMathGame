using Core;
using UnityEngine;

namespace Gameplay
{
    public class TextToNumberConverter : MonoBehaviour
    {
        [SerializeField] private UnityIntEvent _convertedText;

        public void ConvertToNumber(string text)
        {
            _convertedText.Invoke(int.Parse(text));
        }
    }
}