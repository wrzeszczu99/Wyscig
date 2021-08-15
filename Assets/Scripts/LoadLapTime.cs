using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    string time;
    public GameObject bestTimeUIDisplay;

    // Start is called before the first frame update
    void Start()
    {
        time = PlayerPrefs.GetString("saved");

        bestTimeUIDisplay.GetComponent<Text>().text = time;
    }

}
