using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class TextManager : MonoBehaviour
    {
        [SerializeField] private Text _text;
        [SerializeField] private QuestionManager manager;

        public void SetNewText(string newText)
        {
            _text.text = newText;
        }

        public void SetNewTextFromMethod()
        {
            var text = manager.GenerateQuestion();

            _text.text = text;
        }
    }
}