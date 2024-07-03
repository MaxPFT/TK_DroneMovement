using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    public Transform m_movePos;

    [Header("Axis")]
    [Tooltip("Axis pour que le puisse bouger")]
    public float m_rotateLeftNRight;

    public Vector3 m_dir;
    public float m_speedMoving = 1;
    public float m_speedRotation = 180;
    public Space m_rotateSpaceType = Space.World;

    [Header("Speed")]
    [Tooltip("Vitesse du drone")]
    public float m_forwardSpeed = 2;

    private void Reset()
    {
        m_movePos = transform;
    }
    private void Update()
    {
        m_movePos.Translate(m_dir * Time.deltaTime * m_speedMoving, Space.Self);
        m_movePos.Rotate(Vector3.up, m_rotateLeftNRight * Time.deltaTime, m_rotateSpaceType);
    }

    public void SetRotateLeftNRight(float valuePercent11)
    {
        m_rotateLeftNRight = valuePercent11;
    }
    public void SetMoveForward(float valuePercent11)
    {
        m_dir.z = valuePercent11;
    }
    public void SetMoveRight(float valuePercent11)
    {
        m_dir.x = valuePercent11;
    }
    public void SetMoveUp(float valuePercent11)
    {
        m_dir.y = valuePercent11;
    }

}
