using UnityEngine;

namespace CodeBase.PlayerLogic
{
    public class RopeJump : MonoBehaviour
    {
        [Header("Rope Jump Settings")]
        [SerializeField]
        private float _jumpForce = 50f;
        [SerializeField]
        private float _jumpUpForce = 2f;
        
        private Rigidbody _playerRigidbody;
        private PlayerRopeInteraction _playerRopeInteraction;

        private void Start()
        {
            _playerRopeInteraction = GetComponent<PlayerRopeInteraction>();
            _playerRigidbody = GetComponent<Rigidbody>();
        }

        public void JumpFromRope()
        {
            if (_playerRopeInteraction.IsHangsOnRope == true)
            {
                Vector3 jumpDirection = (Vector3.back + Vector3.up * _jumpUpForce).normalized;

                _playerRigidbody.AddForce(jumpDirection * _jumpForce, ForceMode.Impulse);
            }
        }
    }
}