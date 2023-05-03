using UnityEngine;

namespace Core
{
    public class DebugLogger : MonoBehaviour
    {
        [SerializeField] private string _logText = "This function is working!";
        
        public void Working()
        {
            Debug.Log($"DEBUG.LOG: {_logText}");
        }

        public void Working(int number)
        {
            Debug.Log($"DEBUG.LOG: {number}");
        }
        
        public void Working(float number)
        {
            Debug.Log($"DEBUG.LOG: {number}");
        }
        
        public void Working(string text)
        {
            Debug.Log($"DEBUG.LOG: {text}");
        }
    }
}