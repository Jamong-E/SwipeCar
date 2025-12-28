using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    bool charge = false;
    bool moved = false;
    float start;
    float end;
    float speed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !moved)
        {
            charge = true;
            start = Input.mousePosition.x;
        }
        if (Input.GetMouseButtonUp(0) && charge)
        {
            charge = false;
            moved = true;
            end = Input.mousePosition.x;
            speed = (end - start) / 500;
            if (speed < 0) { speed *= -1; }
            GetComponent<AudioSource>().Play();
        }
        if (speed > 0 && moved)
        {
            transform.Translate(speed, 0, 0);
            speed = speed * 99 / 100 - 0.0001f;
            if (speed < 0) { speed = 0; }
        }

    }
}
