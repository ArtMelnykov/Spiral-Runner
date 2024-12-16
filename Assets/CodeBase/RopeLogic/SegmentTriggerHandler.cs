using CodeBase.PlayerLogic;
using UnityEngine;

namespace CodeBase.RopeLogic
{
    public class SegmentTriggerHandler : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField]
        private PlayerRopeInteraction _playerRopeInteraction;
        [SerializeField]
        private RopeRotate _ropeRotate;
        
        private const string Player = "Player";

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag(Player))
            {
                EnableRopeRotation(true);
                _playerRopeInteraction.IsHangsOnRope = true;
            }
        }

        private void OnTriggerExit(Collider player)
        {
            if (player.CompareTag(Player))
            {
                EnableRopeRotation(false);
                _playerRopeInteraction.IsHangsOnRope = false;
            }
        }

        private void EnableRopeRotation(bool enable) => 
            _ropeRotate.enabled = enable;
    }
}