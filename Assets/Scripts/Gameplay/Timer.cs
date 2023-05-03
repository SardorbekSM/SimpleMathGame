using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private int _timeToRich;
        [SerializeField] private UnityIntEvent _secondsTick;
        [SerializeField] private UnityEvent _timerEnded;

        private Coroutine timerCoroutine;

        public void StartTimer()
        {
            timerCoroutine = StartCoroutine(TimerCoroutine());
        }

        [ContextMenu("ResetTimer")]
        public void ResetTimer()
        {
            StopCoroutine(TimerCoroutine());
            StartCoroutine(TimerCoroutine());
        }

        private IEnumerator TimerCoroutine()
        {
            var currentTime = _timeToRich;
            while (currentTime > 0)
            {
                _secondsTick.Invoke(currentTime);
                currentTime--;
                yield return new WaitForSeconds(1);
            }

            _secondsTick.Invoke(currentTime);
            _timerEnded.Invoke();
        }
    }
}