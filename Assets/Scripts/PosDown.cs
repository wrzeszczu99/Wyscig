using UnityEngine;
using UnityEngine.UI;

public class PosDown : MonoBehaviour
{

    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "PosCube") positionDisplay.GetComponent<Text>().text = "2/2";

    }

}
