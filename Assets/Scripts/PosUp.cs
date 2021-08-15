using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour
{

    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "PosCube") positionDisplay.GetComponent<Text>().text = "1/2";

    }

}
