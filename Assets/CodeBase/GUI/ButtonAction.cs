using CodeBase.PlayerLogic;
using UnityEngine;

namespace CodeBase.GUI
{
    public class ButtonAction : ButtonLogic
    {
        [Header("Dependencies")] 
        [SerializeField]
        private ButtonLogic _buttonLogic;
        [SerializeField]
        private SliderMover _sliderMover;
        [SerializeField] 
        private RopeJump _ropeJump;
        [SerializeField] 
        private PlayerRopeInteraction _playerRopeInteraction;

        private void OnEnable()
        {
            _buttonLogic.OnButtonClicked += TurnoffSlider;
            _buttonLogic.OnButtonClicked += Jump;
            Debug.Log("Subscibred Button");
        }

        private void OnDisable()
        {
            _buttonLogic.OnButtonClicked -= TurnoffSlider;
            _buttonLogic.OnButtonClicked -= Jump;
            Debug.Log("Unsubscribe button action");
        }

        private void TurnoffSlider() => 
            _sliderMover.enabled = false;

        private void Jump()
        {
            _ropeJump.JumpFromRope();
            _playerRopeInteraction.IsHangsOnRope = false;
        }
    }
}