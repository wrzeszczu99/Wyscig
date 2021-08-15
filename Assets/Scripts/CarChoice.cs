using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public List<GameObject> bodies;
    public GameObject playersCarBody;
    public GameObject playersCar;
    public GameObject oponentsCarBody;
    public GameObject oponentsCar;
    public int carChoice;

    // Start is called before the first frame update
    void Start()
    {
        carChoice = GlobalCar.carType -1;
        playersCarBody.SetActive(false);
        Destroy(playersCarBody);
        Instantiate(bodies[carChoice], playersCar.transform);
        int random = carChoice;
        while (random == carChoice) random = Random.Range(0, 5);
        oponentsCarBody.SetActive(false);
        Destroy(oponentsCarBody);
        Instantiate(bodies[random], oponentsCar.transform).SetActive(true);
    }
}
