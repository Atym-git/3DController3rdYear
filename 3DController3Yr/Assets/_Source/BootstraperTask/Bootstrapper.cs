using UnityEngine;

namespace BootstrapperTask
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private InputListener _inputListener;
        [SerializeField] private PlayerData _playerData;

        private void Awake()
        {
            PlayerMovement playerMovement = new();
            Invoker invoker = new(_playerData, playerMovement);
            _inputListener.Construct(invoker);
        }
    }
}
