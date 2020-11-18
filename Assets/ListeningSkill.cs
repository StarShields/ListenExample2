using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeningSkill : MonoBehaviour
{

    public GameObject CryosInstance;
    public Transform Instantiationpoint;
    public GameObject CryosPreview;

    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        //check for the cryonis effect script
        Cryonis cryoCheck
          = FindObjectOfType<Cryonis>();
        //set preview gameobject active if it is over water
        if (Input.GetKey(KeyCode.Space) && cryoCheck.overWater == true)
        {
            Debug.Log("AbilityActivated");
            CryosPreview.SetActive(true);
        }
        else
        {
            Debug.Log("Inactive");
            CryosPreview.SetActive(false);
        }

        //use script to check if the instantiation point is over water
    if (Input.GetKeyDown(KeyCode.R) && (cryoCheck.overWater == true))
        {
            Debug.Log("Instantiate Successful");
            GameObject IceCube;
            IceCube = Instantiate(CryosInstance, Instantiationpoint.position, Instantiationpoint.rotation);
            CryosPreview.SetActive(false);
        }
        else
        {
            Debug.Log("cannot instantiate");
        }
       
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
                

            
      //  }
  //  }
//}


   