using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeningSkill : MonoBehaviour
{
    public GameObject ListeningCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("now listening for enemy");
            ListeningCanvas.SetActive(true);

        }
        else
        {
            ListeningCanvas.SetActive(false);
        }
    }
}
