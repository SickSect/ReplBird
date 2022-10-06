using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePipeClone : MonoBehaviour
{
    public float posToDelete;

    private void Update()
    {
        if (transform.position.x <= posToDelete)
            GameObject.Destroy(this.gameObject);
    }
}
