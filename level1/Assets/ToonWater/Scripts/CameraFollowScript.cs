using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    //offset camera on all three axes 
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }


}


//