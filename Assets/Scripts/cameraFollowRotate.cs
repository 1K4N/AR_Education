using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowRotate : MonoBehaviour
{
    public float speed = 50.0f;
    public GameObject mCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        transform.position = new Vector3(.2f, 0.0f, -0.3f) - mCamera.transform.position;

    }
}
