using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSc : MonoBehaviour
{
    public float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.name=="big-turning-floor")
        {
            transform.Rotate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
       
    }
}
