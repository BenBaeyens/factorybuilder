using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    GameObject Selector;

    [SerializeField] Vector3 offset;
    [SerializeField] float followSpeed;

    #region Methods

    void Start()
    {
        Selector = GameObject.Find("Selector");
    }

    private void LateUpdate() {
        transform.position = Vector3.Lerp(transform.position, Selector.transform.position + offset, followSpeed * Time.deltaTime);
    }

    
    #endregion
}
