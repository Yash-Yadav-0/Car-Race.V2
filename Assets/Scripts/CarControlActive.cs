using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarUserControl;

    void Start()
    {
        CarUserControl.GetComponent<CarController>().enabled = true;
    }
}
