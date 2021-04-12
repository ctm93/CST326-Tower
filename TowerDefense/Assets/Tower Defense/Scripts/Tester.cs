using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{

    // Update is called once per frame
    public AudioSource Enemydies;
    static public int count;
    void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
        Camera.main.transform.position.z));
            Enemydies = GetComponent<AudioSource>();
            
            

            RaycastHit[] hits;
      hits = Physics.RaycastAll(ray.origin, ray.direction, 100.0F);

      for (int i = 0; i < hits.Length; i++)
      {
        RaycastHit hit = hits[i];

        if (hit.transform.tag == "Enemy")
        {
          hit.transform.GetComponent<Enemy>().Damage();
                    count++;
                    Debug.Log($"{count} count");

                }

        if(count == 2)
                {
                    Enemydies.Play();
                    count = 0;
                }
      }

    }
  }
}
