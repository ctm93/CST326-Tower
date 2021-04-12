using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public Button CustomButton;

    public GameObject go;

    void Start()
    {
        go = GameObject.Find("HordeManager");
        if (go)
        {
            Debug.Log(go.name);
        }
        else
        {
            Debug.Log("No game object called HordeManager found");
        }


    }


    void Awake()
    {
        Button btn = CustomButton.GetComponent<Button>();
        btn.onClick.AddListener(CustomButton_onClick);

    }

    //Handle the onClick event
    public void CustomButton_onClick()
    {
        go.GetComponent<HordeManager>().enabled = true;
    }


}
