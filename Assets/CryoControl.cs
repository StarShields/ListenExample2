using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CryoControl : MonoBehaviour
{
    public GameObject[] _icearray;
    public GameObject CreateImage;
    public static Texture2D cursor2;
    public GameObject DestroyImage;
    // Start is called before the first frame update
    void Start()
    {
        _icearray = GameObject.FindGameObjectsWithTag("Cryo");
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      //  float ImagePos = ray;
        Cursor.visible = true;
       // PlayerSettings.defaultCursor;
            //CreateImage.position = ray;
       
    }

   public void ShowFreeze()
    {
        CreateImage.SetActive(true);
    }
}
