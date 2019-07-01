using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorController : MonoBehaviour
{

    [SerializeField] float jumpDistance;

    Vector3 currentPos;


    #region Methods

    void Start()
    {
        currentPos = transform.position;
    }

    private void Update()
    {
        MoveRight();
        MoveLeft();
        MoveUp();
        MoveDown();

    }


    private void MoveDown()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = currentPos + new Vector3(0, 0, -jumpDistance);
            currentPos = transform.position;
        }
    } 
    private void MoveUp()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = currentPos + new Vector3(0, 0, jumpDistance);
            currentPos = transform.position;
        }
    }
    private void MoveLeft()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position = currentPos + new Vector3(-jumpDistance, 0, 0);
                currentPos = transform.position;
            }
        }
    private void MoveRight()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = currentPos + new Vector3(jumpDistance, 0, 0);
            currentPos = transform.position;
        }
    }

    #endregion
}
