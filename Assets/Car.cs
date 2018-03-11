using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    void Update()
    {
        if (Camera.main.transform.position.z > this.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
