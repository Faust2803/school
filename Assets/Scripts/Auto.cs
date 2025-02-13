using System;
using UnityEngine;

public class Auto : MonoBehaviour
{
    private const int MAX_SPEED = 300;
    
    [SerializeField] float _speed;
    [SerializeField] float _turnSpeed;
    
    private string name = "Auto";
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

   
    private int Cout(int km, int n)
    {
        var i = 0;
        i = km * n;
        return i;
    }

    private void Awake()
    {
        //Debug.Log("Auto Awake");
    }

    private void Satrt()
    {
        //Debug.Log("Auto Satrt");
    }

    private void Update()
    {
        //Debug.Log("Auto Update")
    }

    private void FixedUpdate()
    {
        // if (Input.GetKey(KeyCode.W)) // Проверяем нажатие клавиши
                    // {
                    //     transform.position += transform.forward * _speed;
                    // }
                    //
                    // if (Input.GetKey(KeyCode.S)) // Проверяем нажатие клавиши
                    // {
                    //     transform.position -= transform.forward * _speed;
                    // }
                    
                    var move = Input.GetAxis("Vertical"); // Использует W/S или стрелки
                    //Debug.Log(move);
                    transform.position += transform.forward * move * _speed;
                    
                    float turn = Input.GetAxis("Horizontal") * _turnSpeed;
                    transform.Rotate(0, turn, 0);
    }
}
