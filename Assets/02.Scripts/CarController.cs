using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public bool charge = false;
    public bool moved = false;
    public float start;
    public float end;
    public float speed;
    public bool isMoved = false;

    public void Reset()
    {
        charge = false;
        moved = false;
        start = 0;
        end = 0;
        speed = 0;
        isMoved = false;
        transform.position = new Vector3(-7, -3.7f, 0);
    }



    // Start is called before the first frame update
    void Start()
    {
        Reset();
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
            if (speed < 0) { speed = 0; isMoved = true; }
        }

    }
}
