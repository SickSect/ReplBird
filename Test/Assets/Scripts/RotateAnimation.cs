using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float takeOfRotation, landingRotation;

    private float rotateZ;

    public void ApplyRotation(float velocityY)
    {
        if (rotateZ > landingRotation)
        {
            float offset = 1f;
            if (velocityY > 0.5f)
                offset = velocityY;
            offset = Mathf.Abs(offset);
            rotateZ -= rotationSpeed * Time.deltaTime / offset;
            transform.localEulerAngles = new Vector3(0, 0, rotateZ);
        }
    }

    public void StartRotation()
    {
        rotateZ = takeOfRotation;
    }
}
