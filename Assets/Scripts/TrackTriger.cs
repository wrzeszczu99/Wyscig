using UnityEngine;

public class TrackTriger : MonoBehaviour
{
    public GameObject thisTrigger;
    public GameObject nextTrigger;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            nextTrigger.SetActive(true);
            thisTrigger.SetActive(false);
        }
    }
}
