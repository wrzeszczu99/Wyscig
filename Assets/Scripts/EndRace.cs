using System.Collections;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class EndRace : MonoBehaviour
{
    public GameObject playersCar;
    public GameObject oponentsCar;
    public GameObject endCamera;
    public GameObject viewModes;
    public GameObject levelMusic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playersCar.GetComponent<CarController>().enabled = false;
            playersCar.GetComponent<CarUserControl>().enabled = false;

            oponentsCar.GetComponent<CarAudio>().enabled = false;
            playersCar.GetComponent<CarAudio>().enabled = false;

            endCamera.SetActive(true);
            viewModes.SetActive(false);
            levelMusic.SetActive(false);

            StartCoroutine(EndingTime());
        }
    }

    IEnumerator EndingTime()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(1);
    }
}
