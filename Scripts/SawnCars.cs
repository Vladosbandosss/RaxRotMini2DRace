using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawnCars : MonoBehaviour
{
    [SerializeField] GameObject[] cars;

    private float minX = -2.57f;
    private float maxX = 2.57f;
    [SerializeField] float repeatRate = 1f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnAuto), 1f, repeatRate);
    }

  void SpawnAuto()
    {
        int randomCar = Random.Range(0, cars.Length);
        float randomXpos = Random.Range(minX, maxX);
        Vector3 reandpos = new Vector3(randomXpos, transform.position.y, transform.position.z);
        Instantiate(cars[randomCar], reandpos, cars[randomCar].transform.rotation);
    }
}
