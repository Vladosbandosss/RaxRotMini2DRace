using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float speed;
   

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.y -= speed * Time.deltaTime;
        transform.position = temp;
    }
}
