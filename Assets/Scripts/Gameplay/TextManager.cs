using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class TextManager : MonoBehaviour
    {
        [SerializeField] private Text _text;

        public void SetNewText(string newText)
        {
            _text.text = newText;
        }

        public void SetNewText(int newText)
        {
            _text.text = newText.ToString();
        }
    }
}