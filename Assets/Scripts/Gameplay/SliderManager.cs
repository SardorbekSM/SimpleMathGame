using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class SliderManager : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private int _sliderMin = 0;
        [SerializeField] private int _sliderMax = 10;

        private void Awake()
        {
            _slider.minValue = _sliderMin;
            _slider.maxValue = _sliderMax;
        }

        public void ChangeSliderValue(int newValue)
        {
            _slider.value = newValue;
        }
    }
}