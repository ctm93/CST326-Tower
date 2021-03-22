using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
  public Path route;
  private Waypoint[] myPathThroughLife;
  public int coinWorth;
  public int coinPurse;
  public float health;
  public float speed = .25f;
  private int index = 0;
  private Vector3 nextWaypoint;
  private bool stop = false;

  void Awake()
  {
    myPathThroughLife = route.path;
    transform.position = myPathThroughLife[index].transform.position;
    Recalculate();
  }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            if ((transform.position - myPathThroughLife[index + 1].transform.position).magnitude < .1f)
            {
                index = index + 1;
                Recalculate();
            }

                Vector3 moveThisFrame = nextWaypoint * Time.deltaTime * speed;
                transform.Translate(moveThisFrame);
        }

        if (Input.GetMouseButtonDown(0))
        {

            if (gameObject.tag == "BigGuy")
            {
                health--;
                Debug.Log(health);
                if (health == 0)
                {
                    Destroy(gameObject);
                    coinPurse = coinPurse + coinWorth;
                    Debug.Log("BigGuy is dead");
                    Debug.Log("CoinPurse Total: ");
                    Debug.Log(coinPurse);
                }

            }
        }



    }




void Recalculate()
    {
        if (index < myPathThroughLife.Length -1)
        {
            nextWaypoint = (myPathThroughLife[index + 1].transform.position - myPathThroughLife[index].transform.position).normalized;
        }

        else
        {
            stop = true;
        }
    }




}
