using Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class ButtonManager : MonoBehaviour
    {
        [SerializeField] private Text _buttonText;
        [SerializeField] private UnityStringEvent _buttonPressed;

        public void SetButtonName(string buttonName)
        {
            _buttonText.text = buttonName;
        }
        
        public void PressButton()
        {
            _buttonPressed.Invoke(_buttonText.text);
        }
    }
}