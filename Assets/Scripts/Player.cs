using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Direction.North.Vector);
        Debug.Log(new Vector3(0, 1,0));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Move(Direction.North);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Move(Direction.South);
        }
    }

    public void Move(Direction direction)
    {
        transform.position += direction.Vector;
    }
}
