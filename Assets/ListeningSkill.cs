using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeningSkill : MonoBehaviour
{

    public Rigidbody Cryos;
    public Transform Instantiationpoint;
    public GameObject CryosPreview;




    // Update is called once per frame
    void Update()
    {

        Cryonis cryoCheck
           = gameObject.GetComponent<Cryonis>();

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("AbilityActivated");
            CryosPreview.SetActive(true);
            if (cryoCheck.overWater == false)
            {
                {
                    Debug.Log("Unavailable");
                    CryosPreview.SetActive(false);
                }
            }
            else
            {
                CryosPreview.SetActive(false);
            }


            if (Input.GetKeyDown(KeyCode.R))
            {
                if (cryoCheck.overWater == true)
                    Debug.Log("Instantiate Ice");
               // Rigidbody CryosInstance;
              //  CryosInstance = Instantiate(Cryos, Instantiationpoint.position, Instantiationpoint.rotation);
            }


       //     if (Input.GetButtonDown("Fire1"))
            //{
              //  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
              //  RaycastHit hit;
               // if (Physics.Raycast(ray, out hit))
             //   {
                 //   if (hit.transform.name == "IcePrefab")
                  //  {
                  //      Cryonis IcePrefab
                  //   = gameObject.GetComponent<Cryonis>();
                  //      Debug.Log(hit.transform.name);
                      //  IcePrefab.Destruct();
                    }
                }

            }
      //  }
  //  }
//}


