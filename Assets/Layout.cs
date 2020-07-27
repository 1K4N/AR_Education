using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Layout : MonoBehaviour
{
    public Texture firstOne,secondOne;

    private void Start()
    {
        InvokeRepeating("ChangeTexture", 5.0f,2.0f);
    }

    void ChangeTexture()
    {
        if (GetComponent<RawImage>().texture==firstOne)
        {
            GetComponent<RawImage>().texture = secondOne;
        }
        else
        {
            GetComponent<RawImage>().texture = firstOne;
        }
       
    }

}
