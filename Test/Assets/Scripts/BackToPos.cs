using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToPos : MonoBehaviour
{
    public float rightX, leftX;

    private void Update()
    {
        if (transform.position.x < leftX)
            transform.position = new Vector2(rightX, transform.position.y);
    }
}
