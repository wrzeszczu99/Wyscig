using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public List<GameObject> cameras;

    int camMode = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Viewmode"))
        {
            camMode = (camMode + 1) % cameras.Count;

            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        cameras[camMode].SetActive(true);
        

        if (camMode == 0) cameras[cameras.Count - 1].SetActive(false);
        else cameras[camMode - 1].SetActive(false);
        
    }
}
