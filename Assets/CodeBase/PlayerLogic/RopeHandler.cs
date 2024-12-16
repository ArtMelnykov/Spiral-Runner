using CodeBase.GUI;
using UnityEngine;

namespace CodeBase.PlayerLogic
{
    public class RopeHandler : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField]
        private PlayerRopeInteraction _playerRopeInteraction;
        [SerializeField]
        private SliderMover _sliderMover;
        
        private void OnEnable()
        {
            _playerRopeInteraction.OnPlayerHangedRope += TurnonSlider;
            
            Debug.Log("Subscribed to RopeSwing");
        }

        private void OnDisable()
        {
            _playerRopeInteraction.OnPlayerHangedRope -= TurnonSlider;
            
            Debug.Log("Unsubscribed from RopeSwing");
        }

        private void TurnonSlider() => 
            _sliderMover.enabled = true;
    }
}