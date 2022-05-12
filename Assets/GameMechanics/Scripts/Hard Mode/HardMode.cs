using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardMode : MonoBehaviour
{


    public GameObject HardModeButtons;
    public GameObject HardModeParent;


    GameObject newButton;

    Vector3 screenCenter;
    Vector3 SpawnPoint;

    bool moving = true;
    // Start is called before the first frame update
    void Start()
    {
        screenCenter = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
        SpawnPoint = new Vector3(-300f, 200f, 0);

        spawn();

    }

    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        {
            HardModeParent.transform.GetChild(0).position = Vector3.MoveTowards(HardModeButtons.transform.position, screenCenter, 0.5f);
        }

        if (HardModeParent.transform.GetChild(0).position == screenCenter)
        {
            HardModeLoss();
        }
    }

    public void HardModeLoss()
    {
        moving = false;
        Destroy(newButton);
        Destroy(HardModeButtons);
    }

    public void spawn()
    {
        newButton = Instantiate(HardModeButtons) as GameObject;
        newButton.transform.SetParent(HardModeParent.transform);
        newButton.transform.position = SpawnPoint;
    }
}
