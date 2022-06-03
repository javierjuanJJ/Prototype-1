using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private Vector3 offset;


    private void Awake()
    {
        offset = new Vector3(0, 5, -7);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}