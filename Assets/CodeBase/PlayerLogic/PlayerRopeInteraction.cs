using System;
using UnityEngine;

namespace CodeBase.PlayerLogic
{
    public class PlayerRopeInteraction : MonoBehaviour
    {
        private Transform _playerTransform;

        private readonly Vector3 _offSetY = new Vector3(0, -1f, 0);
        private readonly Vector3 _offSetZ = new Vector3(0, 0, 0.63f);

        private const string Rope = "Rope";
        
        public event Action OnPlayerHangedRope;
        
        public bool IsHangsOnRope = false;
        
        private void Start() => 
            _playerTransform = GetComponent<Transform>();

        private void LateUpdate()
        {
            if (IsHangsOnRope)
            {
                SwingOnRope();
            }
        }

        private void OnTriggerEnter(Collider rope)
        {
            if (rope.CompareTag(Rope))
            {
                OnPlayerHangedRope?.Invoke();
                _playerTransform = rope.transform;
            }
        }

        private void SwingOnRope()
        {
            Vector3 playerPosition = _playerTransform.position + _offSetY + _offSetZ;
            transform.position = playerPosition;
        }
    }
}