using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickanddestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;

                if (bc != null)
                {
                    Debug.Log("it works");
                }


            }
        }
    }
}
