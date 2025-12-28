using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text ui;
    public GameObject restartButton;


    // Start is called before the first frame update
    void Start()
    {
        restartButton.SetActive(false);
        // Button restarter = restartButton.GetComponent<Button>();
        // restarter.onClick.AddListener(clicked);
    }
    public void clicked()
    {
        /*Debug.Log("´­·È´Ù!");
        car.GetComponent<CarController>().charge = false;
        car.GetComponent<CarController>().moved = false;
        car.GetComponent<CarController>().start = 0;
        car.GetComponent<CarController>().end = 0;
        car.GetComponent<CarController>().speed = 0;
        car.GetComponent<CarController>().isMoved = false;
        car.transform.position = new Vector3(-7, -3.7f, 0);
        restartButton.SetActive(false);*/
        SceneManager.LoadScene(0);
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
        if (car.GetComponent<CarController>().isMoved)
        {
            restartButton.SetActive(true);
        }
    }
}
