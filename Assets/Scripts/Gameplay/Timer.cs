using System;
using System.Collections;
using UnityEngine;

namespace Gameplay
{
    public class Timer : MonoBehaviour
    {
        public void StartTimer()
        {
            StartCoroutine(TimerCoroutine());
        }

        private static IEnumerator TimerCoroutine()
        {
            Debug.Log($"Current time: {Time.time}");

            yield return new WaitForSeconds(3);
            
            Debug.Log($"Current time: {Time.time}");
        }
    }
}
