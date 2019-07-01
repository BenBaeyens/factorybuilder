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

    private void Update() {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position = currentPos + new Vector3(jumpDistance, 0, 0);
            currentPos = transform.position;
        }
    }

    #endregion
}
