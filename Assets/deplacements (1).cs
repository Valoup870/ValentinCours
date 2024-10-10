using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacements : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newdirection = new Vector3();


        if (Input.GetKey(KeyCode.RightArrow))
        {
            newdirection.x += 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newdirection.x -= 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newdirection.z += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newdirection.z -= 1;
        }
        if (Input.GetKey(KeyCode.Space))
            newdirection.y += 1;
        if (newdirection != Vector3.zero)
        {
            newdirection.Normalize();
            transform.position += newdirection * speed * Time.deltaTime;
        }
    }
}