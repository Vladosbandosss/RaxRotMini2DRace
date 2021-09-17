using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    [SerializeField] float speed;
    private float minX = -2.57f;
    private float maxX = 2.57f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CarMoveMent();
    }

    void CarMoveMent()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)//право
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;

            if (temp.x > maxX)
            {
                temp.x = maxX;
            }

            transform.position = temp;
           
        }
        if (Input.GetAxisRaw("Horizontal") < 0)//лево
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;

            if (temp.x <minX)
            {
                temp.x = minX;
            }

            transform.position = temp;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
