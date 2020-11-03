using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cryonis : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Boost();

        }
    }

    void Boost()
    {
        Debug.Log("boost");
        float y = this.gameObject.transform.localScale.y;
        float x = this.gameObject.transform.localScale.x;
        float z = this.gameObject.transform.localScale.z;
        transform.localScale = new Vector3(x, y * Time.deltaTime, z);
    }
}
