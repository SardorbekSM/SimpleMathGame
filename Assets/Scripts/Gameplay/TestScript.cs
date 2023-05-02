using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class TestScript : MonoBehaviour
    {
        [SerializeField] private Text _text;

        private void Update()
        {
            _text.text = Time.fixedTime.ToString(CultureInfo.InvariantCulture);
        }
    }
}