using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public void rotateDisplay(float speed)
    {
        transform.Rotate(new Vector3(0, .5f, 0), speed);
    }
}
