using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class SimpleAction : MonoBehaviour
    {
        [SerializeField] private UnityEvent _action;

        public void DoAction()
        {
            _action.Invoke();
            Time.timeScale = 0;
        }
    }
}
