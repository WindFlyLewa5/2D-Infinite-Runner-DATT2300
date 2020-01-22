using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeamlessBack : MonoBehaviour
{
    public float speed;
    public float Xoffset;
    public GameObject cam;

    void start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Update()

    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x > cam.transform.position.x)
        {
            Vector3 pos = new Vector3(cam.transform.position.x - Xoffset, transform.position.y, transform.position.z);
            transform.position = pos;
        }
    }
}
