using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform PontoTransform;
    private Vector3 cameraOffset;
    [Range (0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    public bool LookAtPonto = false;
    public bool RotateAroundPonto = true;
    public float RotationsSpeed = 5.0f;
    void Start()
    {
        cameraOffset = transform.position - PontoTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(RotateAroundPonto){
            Quaternion camTurnAngle = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);
            cameraOffset = camTurnAngle * cameraOffset;
        }
        Vector3 newPos =PontoTransform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
        if(LookAtPonto || RotateAroundPonto)
        transform.LookAt(PontoTransform);
    }
}
