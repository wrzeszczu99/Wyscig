using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

    public GameObject bestDisplay;

    public GameObject lapCounter;
    public int laps = 0;
    public int maxLaps = 1;

    public float comparableTime;

    public GameObject RaceFinnish;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            comparableTime = PlayerPrefs.GetFloat("Comparable Time");
            if (comparableTime > LapTimeManager.ComparableTime)
            {
                bestDisplay.GetComponent<Text>().text = LapTimeManager.Display;
                PlayerPrefs.SetString("saved", LapTimeManager.Display);
            }

            PlayerPrefs.SetFloat("Comparable Time", LapTimeManager.ComparableTime);

            laps++;
            lapCounter.GetComponent<Text>().text = "" + laps + "/" + maxLaps;
            if (laps == maxLaps) RaceFinnish.SetActive(true);
            //Reseting Timers
            LapTimeManager.Reset();
        }
    }
}
