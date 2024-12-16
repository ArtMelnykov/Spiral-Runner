using UnityEngine;

namespace CodeBase.GUI
{
    public class SliderMover : MonoBehaviour
    {
        [Header("Dependencies")]
        [SerializeField]
        private RectTransform _slider;
        
        private float _previousSliderValue = -1f;

        private const float MaxSliderValue = 100f;
        private const float MinSliderValue = 0f;

        private const float CircleDegrees = 360f;
        private const float CircleRadians = 180f;

        public float Speed = 100f;
        public float SliderValue = 0f;
        
        private bool _isMovingRightSide = true;
        
        private void Update()
        {
            MoveSlider();
            
            if (ShouldUpdateSliderRotation())
            {
                UpdateSliderRotation(SliderValue);
                _previousSliderValue = SliderValue;
            }
        }

        private void MoveSlider()
        {
            if (_isMovingRightSide)
            {
                SliderValue += Time.deltaTime * Speed;
                if (SliderValue >= MaxSliderValue)
                {
                    SliderValue = MaxSliderValue;
                    _isMovingRightSide = false;
                }
            }
            else
            {
                SliderValue -= Time.deltaTime * Speed;
                if (SliderValue <= MinSliderValue)
                {
                    SliderValue = MinSliderValue;
                    _isMovingRightSide = true;
                }
            }
        }

        private void UpdateSliderRotation(float sliderValue)
        {
            float normalizedValue = sliderValue / MaxSliderValue;
            float amount = normalizedValue * CircleRadians / CircleDegrees;

            float sliderAngle = amount * CircleDegrees;

            _slider.localRotation = Quaternion.Euler(0f, 0f, -sliderAngle);
        }

        private bool ShouldUpdateSliderRotation() => 
            !Mathf.Approximately(SliderValue, _previousSliderValue);
    }
}