using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour
{
    public Text statusText;
    public RawImage searchingImage;
    public GameObject startObjects;
    public GameObject restartObjects;
    public GameObject buttonsObject;

    public void whenLost()
    { 
        statusText.text = "Aranıyor";
        searchingImage.gameObject.SetActive(true);
        buttonsObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void whenFound()
    {
        statusText.text = "Algılandı";
        buttonsObject.gameObject.SetActive(true);
        searchingImage.gameObject.SetActive(false) ;
    }

    public void startEvent()
    {
        startObjects.gameObject.SetActive(true);
        restartObjects.gameObject.SetActive(false);
    }
    public void restartEvent()
    {
        startObjects.gameObject.SetActive(false);
        restartObjects.gameObject.SetActive(true);
    }

}
