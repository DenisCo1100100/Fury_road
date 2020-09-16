using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControll : MonoBehaviour
{
    public Transform target;
    public Vector3 moveLeftVector;
    public Vector3 moveRightVector;
    public float speed;

    void Start()
    {    
    }

    void Update()
    {
        Vector3 movePositions = new Vector3(target.position.x, 1.18f, -5.70f);

        if (Input.GetKey(KeyCode.A))
        {
            if (target.transform.position.x > -2.8f)
            {
                target.transform.Translate(moveLeftVector * Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (target.transform.position.x < 2.8f)
            {
                target.transform.Translate(moveRightVector * Time.deltaTime * speed);
            }
        }

        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, movePositions, Time.deltaTime * (speed - 0.5f));
    }
}
