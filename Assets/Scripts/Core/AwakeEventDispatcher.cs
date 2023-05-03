using System;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class AwakeEventDispatcher : MonoBehaviour
    {
        [SerializeField] private UnityEvent _awake;
        
        private void Awake()
        {
            _awake.Invoke();
        }
    }
}