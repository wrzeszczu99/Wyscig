using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int carType; //Red Blue Carbon Gray Yellow
    public GameObject TrackPanel;
    public GameObject TrackTitle;
    public GameObject CarTitle;


    public void RedCar()
    {
        carType = 1;
        ChangePanels();
    } 
    public void BlueCar()
    {
        carType = 2;
        ChangePanels();
    }
    public void CarbonCar()
    {
        carType = 3;
        ChangePanels();
    } 
    public void GrayCar()
    {
        carType = 4;
        ChangePanels();
    }
    public void YellowCar()
    {
        carType = 5;
        ChangePanels();
    }

    private void ChangePanels()
    {
        TrackPanel.SetActive(true);
        TrackTitle.SetActive(true);
        CarTitle.SetActive(false);
    }
}
