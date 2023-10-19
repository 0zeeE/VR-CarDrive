using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public HingeJoint steeringWheel;
        public HingeJoint speedLever;
        public float maxTurnAngle = 180;
        public float maxSpeedAngle = 30;



        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!

            //XR Control
            //float h = Mathf.Clamp(steeringWheel.angle /maxTurnAngle,-1,1);
            //float v = Mathf.Clamp(speedLever.angle / maxSpeedAngle,-1,1);
            //if(Mathf.Abs(v) < 0.1f)
            //{
            //    v = 0;
            //}

            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
           


#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
