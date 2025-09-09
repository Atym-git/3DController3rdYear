using UnityEngine;

namespace BootstrapperTask
{
    public class Invoker
    {
        private readonly PlayerData _playerData;
        private readonly PlayerMovement _playerMovement;

        public Invoker(PlayerData playerData, PlayerMovement playerMovement)
        {
            _playerData = playerData;
            _playerMovement = playerMovement;
        }
        public void InvokeMove()
        {
            _playerMovement.Move(_playerData.PlayerRb,
                                 _playerData.moveSpeed);
        }
    }
}
