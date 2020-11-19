using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 5f;
    Vector2 mousePOS;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        movementCodes();
    }
    void movementCodes()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mousePOS = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        } 
        rb.position = Vector3.Lerp(rb.position, mousePOS, 1);
    }
}
