using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    Material backGround;
    [SerializeField] float scrollSpeed = 2f;
    void Start()
    {
        backGround = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, scrollSpeed * Time.deltaTime);
        backGround.mainTextureOffset += offset;
    }
}
