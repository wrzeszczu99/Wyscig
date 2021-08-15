using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    private static int minCount;
    private static int secCount;
    private static float miliCount;
    private static string display;

    public GameObject textBox;

    private static float comparableTime;


    // Update is called once per frame
    void Update()
    {
        miliCount += Time.deltaTime * 10;
        comparableTime += Time.deltaTime;

        if(miliCount>9)
        {
            miliCount = 0;
            secCount++;
        }

        if(secCount>=60)
        {
            secCount = 0;
            minCount++;
        }

        if (minCount <= 9) display = "0" + minCount + ":";
        else display = "" + minCount + ":";

        if (secCount <= 9) display = display + "0" + secCount + ".";
        else display = display + secCount + ".";

        display = display + miliCount.ToString("F0");

        textBox.GetComponent<Text>().text = display;
    }


    public static string Display { get => display; set => display = value; }
    public static float ComparableTime { get => comparableTime; set => comparableTime = value; }

    public static void Reset()
    {
        miliCount = 0f;
        secCount = 0;
        minCount = 0;
        comparableTime = 0f;
    }
}
