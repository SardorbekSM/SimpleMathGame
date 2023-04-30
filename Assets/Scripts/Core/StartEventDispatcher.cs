using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class StartEventDispatcher : MonoBehaviour
    {
        [SerializeField] private UnityEvent _started;

        private void Start()
        {
            _started.Invoke();
        }
    }
}
