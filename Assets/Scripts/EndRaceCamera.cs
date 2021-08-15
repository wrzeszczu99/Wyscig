using UnityEngine;

public class EndRaceCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.1f, 0, Space.World);
    }
}
