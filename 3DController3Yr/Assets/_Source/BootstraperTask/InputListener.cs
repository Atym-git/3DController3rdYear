using UnityEditor.Timeline.Actions;
using UnityEngine;
namespace BootstrapperTask
{
    public class InputListener : MonoBehaviour
    {
        private Invoker _invoker;

        public void Construct(Invoker invoker)
        {
            _invoker = invoker;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _invoker.InvokeMove();
            }
        }
    }
}