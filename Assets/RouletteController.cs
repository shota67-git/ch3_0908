using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    public TextMeshProUGUI show;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }
        transform.Rotate(0,0, rotSpeed);
        rotSpeed *= 0.96f;
        if (rotSpeed < 0.01f) rotSpeed = 0;
        if (transform.eulerAngles.z > 30 && transform.eulerAngles.z < 90)
        {
            Debug.Log("¤j¦N");
            show.text = "¤j¦N";
        }
        //Debug.Log(rotSpeed);


    }
}
