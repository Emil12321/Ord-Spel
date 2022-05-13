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

    float[] middle = new float[10];
    float[] speed = new float[10];

    GameObject[] buttons = new GameObject[10];

    bool moving = true;
    // Start is called before the first frame update
    void Start()
    {




        for (int i = 0; i < 5; i++)
        {
            middle[i] = Random.Range(Screen.height - Screen.height + Screen.height/3, Screen.height - Screen.height/3);
            speed[i] = Random.Range(0.1f, 1f);
            SpawnPoint = new Vector3(Screen.width, Random.Range(0f, 800f), 0);
            buttons[i] = Instantiate(HardModeButton, SpawnPoint, Quaternion.identity);
            buttons[i].transform.SetParent(Canvas.transform);
        }
        for (int i = 5; i < 10; i++)
        {
            middle[i] = Random.Range(Screen.height - Screen.height + Screen.height / 3, Screen.height - Screen.height / 3);
            speed[i] = Random.Range(0.1f, 1f);
            SpawnPoint = new Vector3(Screen.width - Screen.width, Random.Range(0f, 800f), 0);
            buttons[i] = Instantiate(HardModeButton, SpawnPoint, Quaternion.identity);
            buttons[i].transform.SetParent(Canvas.transform);
        }


    }

    // Update is called once per frame
    void Update()
    {
            for (int i = 0; i < 10; i++)
            {
                screenCenter = new Vector3(Screen.width * 0.5f, middle[i], 0);
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
        if (CurrentButton <= 4)
        {
            speed[CurrentButton] = Random.Range(0.1f, 1f);
            SpawnPoint = new Vector3(Screen.width, Random.Range(0f, 800f), 0);
            buttons[CurrentButton] = Instantiate(HardModeButton, SpawnPoint, Quaternion.identity);
            buttons[CurrentButton].transform.SetParent(Canvas.transform);
        }

        if (CurrentButton >= 5)
        {
            speed[CurrentButton] = Random.Range(0.1f, 1f);
            SpawnPoint = new Vector3(Screen.width - Screen.width, Random.Range(0f, 800f), 0);
            buttons[CurrentButton] = Instantiate(HardModeButton, SpawnPoint, Quaternion.identity);
            buttons[CurrentButton].transform.SetParent(Canvas.transform);
        }



    }
}
