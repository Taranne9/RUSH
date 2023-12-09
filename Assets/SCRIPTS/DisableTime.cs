using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTime : MonoBehaviour
{
    public float timeToDisable;
    public GameObject hudPanel;

    // Update is called once per frame
    void Update()
    {
        timeToDisable -= Time.deltaTime;
        if (timeToDisable <= 0)
        {
            hudPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
