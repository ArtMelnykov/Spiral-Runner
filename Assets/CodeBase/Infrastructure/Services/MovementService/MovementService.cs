using UnityEngine;

namespace CodeBase.Infrastructure.Services.MovementService
{
    public class MovementService : IMovementService
    {
        private readonly Rigidbody _playerRigidbody;

        public MovementService(Rigidbody playerRigidbody)
        {
            _playerRigidbody = playerRigidbody;
        }
        
        public void Jump(Vector3 jumpDirection, float jumpForce) => 
            _playerRigidbody.AddForce(jumpDirection * jumpForce, ForceMode.Impulse);
    }
}