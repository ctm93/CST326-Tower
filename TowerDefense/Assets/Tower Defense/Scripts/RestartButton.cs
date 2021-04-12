using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class RestartButton : MonoBehaviour
{

    public int levelNumber = 0;
    public Button CustomButton;
    public GameObject go2;
    void Start()
    {
        go2 = GameObject.Find("ResetButtonEvent");
        if (go2)
        {
            Debug.Log(go2.name);
        }
        else
        {
            Debug.Log("No game object called EnemyManager found");
        }


    }

    void Awake()
    {
        Button btn2 = CustomButton.GetComponent<Button>();
        btn2.onClick.AddListener(CustomButton_onClick2);
    }

    public void CustomButton_onClick2()
    {
        SceneManager.LoadScene("TowerDefense");
    }

}
