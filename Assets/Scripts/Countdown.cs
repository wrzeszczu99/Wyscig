using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{
    public GameObject countDownUI;
    public GameObject lapTimer;
   
    [Header("Music and FX")]
    public AudioSource getReady;
    public AudioSource goAudio;
    public AudioSource levelMusic; 

    [Header("Cars Controls")]
    public GameObject carControl;
    public GameObject opponentCarControl;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDownUI.GetComponent<Text>().text = "3";
        getReady.Play();
        countDownUI.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownUI.SetActive(false);
        countDownUI.GetComponent<Text>().text = "2";
        getReady.Play();
        countDownUI.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownUI.SetActive(false);
        countDownUI.GetComponent<Text>().text = "1";
        getReady.Play();
        countDownUI.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownUI.SetActive(false);
        goAudio.Play();

        lapTimer.SetActive(true);
        carControl.GetComponent<CarController>().enabled = true;
        opponentCarControl.GetComponent<CarController>().enabled = true;
        levelMusic.Play(100);


    }

}
