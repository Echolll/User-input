using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBullet : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
