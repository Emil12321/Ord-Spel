using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardMode : MonoBehaviour
{


    public GameObject HardModeButton;
    public GameObject Canvas;

    GameObject newButton;

    Vector3 screenCenter;
    Vector3 SpawnPoint;

    float[] speed = new float[5];

    GameObject[] buttons = new GameObject[5];

    bool moving = true;
    // Start is called before the first frame update
    void Start()
    {


        screenCenter = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);

        for (int i = 0; i < 5; i++)
        {
            speed[i] = Random.Range(0.1f, 1f);
            SpawnPoint = new Vector3(Screen.width, Random.Range(0f, 800f), 0);
            buttons[i] = Instantiate(HardModeButton, SpawnPoint, Quaternion.identity);
            buttons[i].transform.SetParent(Canvas.transform);
        }

    }

    // Update is called once per frame
    void Update()
    {
            for (int i = 0; i < 5; i++)
            {
                buttons[i].transform.position = Vector3.MoveTowards(buttons[i].transform.position, screenCenter, speed[i]);
            
                if (buttons[i].transform.position == screenCenter)
            {
                Destroy(buttons[i]);
                spawn(i);
            }

            }

       
     
    }

    public void Destroy()
    {
        Destroy(newButton);
    }

    public void spawn(int CurrentButton)
    {
        speed[CurrentButton] = Random.Range(0.1f, 1f);
        SpawnPoint = new Vector3(Screen.width, Random.Range(0f, 800f), 0);
        buttons[CurrentButton] = Instantiate(HardModeButton, SpawnPoint, Quaternion.identity);
        buttons[CurrentButton].transform.SetParent(Canvas.transform);


    }
}
