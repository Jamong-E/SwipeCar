using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text ui;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float displacement = flag.transform.position.x - car.transform.position.x;
        if (displacement >= 0)
        {
            ui.text = "±ê¹ß±îÁö °Å¸® : " + displacement.ToString("F2") + "m";
        }
        else
        {
            ui.text = "À¸¾Ç";
        }
    }
}
