using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OponentCar : MonoBehaviour
{
    public List<GameObject> waypoints;
    public int tracker = 0;


    void Update()
    {
        this.transform.position = waypoints[tracker].transform.position;
        this.transform.rotation = waypoints[tracker].transform.rotation;
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("OpponentCar"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            tracker = (tracker + 1) % waypoints.Count;

            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
