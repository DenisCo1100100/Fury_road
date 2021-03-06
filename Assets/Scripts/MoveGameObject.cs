﻿using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    [SerializeField] private Vector3 moveVector;
    [SerializeField] private float speead;
    private float timeBeforeDestroy = 10;
    
    void Start()
    {
        speead = StaticMenagerSetings.speed;

        if (gameObject.tag == "CarSpawnerPassing")
        {
            gameObject.transform.rotation = Quaternion.LookRotation(Vector3.zero);
        }

        Destroy(gameObject, timeBeforeDestroy);
    }

    void Update()
    {
        transform.Translate(moveVector * Time.deltaTime * speead, Space.World);
    }
}
