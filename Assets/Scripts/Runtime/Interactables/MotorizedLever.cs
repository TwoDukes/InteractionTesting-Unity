using UnityEngine;

public class MotorizedLever : MonoBehaviour
{
    [SerializeField]
    private float motorSpeed = 50f;

    private HingeJoint joint;
    private JointMotor motor;
    public bool isEnabled { get { return joint.motor.targetVelocity != 0; } }

    void Awake()
    {
        joint = GetComponentInChildren<HingeJoint>();
        motor = joint.motor;
    }

    public void ModifyMotorSpeed(float newSpeed)
    {
        motorSpeed = newSpeed;
        if (isEnabled)
        {
            motor.targetVelocity = newSpeed;
        }
        joint.motor = motor;
    }

    public void ToggleMotor()
    {
        if (isEnabled)
        {
            motor.targetVelocity = 0;
            joint.motor = motor;
            return;
        }
        motor.targetVelocity = motorSpeed;
        joint.motor = motor;
    }

    public void DisableMotor()
    {
        motor.targetVelocity = 0;
        joint.motor = motor;
    }

    public void EnableMotor()
    {
        motor.targetVelocity = motorSpeed;
        joint.motor = motor;
    }
}
