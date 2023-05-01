using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class SliderBehaviour : MonoBehaviour
    {
        [SerializeField] private Slider _slider;

        public void ChangeSliderValue()
        {
            if (_slider.value <= 10 && _slider.value > 0)
            {
                _slider.value--;
            }
        }
        
        private void SetSettings()
        {
            _slider.minValue = 0;
            _slider.maxValue = 10;
            _slider.wholeNumbers = true;
        }
    }
}
