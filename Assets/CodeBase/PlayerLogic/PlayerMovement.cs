using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.Services.MovementService;
using UnityEngine;

namespace CodeBase.PlayerLogic
{
    public class PlayerMovement : MonoBehaviour
    {
        private IMovementService _movementService;
        private Rigidbody _playerRbRigidbody;
        
        private const float JumpForce = 10f;
        private const string Ground = "Ground";

        public bool IsGrounded = true;

        private void Awake()
        {
            _playerRbRigidbody = GetComponent<Rigidbody>();
            var movementService = new MovementService(_playerRbRigidbody);

            ServiceLocator.Container.RegisterSingle<IMovementService>(movementService);
            
            // Resolve service
            _movementService = ServiceLocator.Container.Single<IMovementService>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
            {
                _movementService.Jump(Vector3.up, JumpForce);
                IsGrounded = false;
            }
        }

        private void OnCollisionEnter(Collision ground)
        {
            if (ground.gameObject.CompareTag(Ground)) 
                IsGrounded = true;
        }
    }
}