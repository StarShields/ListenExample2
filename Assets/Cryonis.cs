using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cryonis : MonoBehaviour
{
    // Update is called once per frame
   public ParticleSystem CyrosEffect;
    private Vector3 mOffset;
    private float mZCord;
    public bool overWater;
    public Transform waterCheck;
    public float waterDistance = 0.4f;
    public LayerMask waterMask;
    public GameObject showfreeze;
    
    void Update()
    {
       overWater = Physics.CheckSphere(waterCheck.position, waterDistance, waterMask);
        CryoControl cryoControl
             = gameObject.GetComponent<CryoControl>();

        ThirdPersonMove thirdpers
            = gameObject.GetComponent<ThirdPersonMove>();

        

        if (overWater)
        {
            Debug.Log("CryonisAvailable");
            showfreeze.SetActive(true);
        }
        else
        {
            showfreeze.SetActive(false);
        }

        int cryosGenerated = GameObject.FindGameObjectsWithTag("Cryo").Length;
        if (cryosGenerated > 3)
        {
           // Debug.Log("destroying earliest model");
        }
    }

    public void CheckWater()
    {
        overWater = Physics.CheckSphere(waterCheck.position, waterDistance, waterMask);
    }

    public void Destruct()
    {
        Debug.Log("Destroying Cryos");
        Destroy(gameObject);
    }
}
