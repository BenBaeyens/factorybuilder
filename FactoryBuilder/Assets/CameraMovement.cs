using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    GameObject Selector;

    [SerializeField] float maxDistance;
    [SerializeField] float resetDistance;
    [SerializeField] Vector3 offset;
    [SerializeField] float followSpeed;

    float currentSpeed;

    #region Methods

    void Start()
    {
        Selector = GameObject.Find("Selector");
        currentSpeed = followSpeed;
    }

    private void Update() {
        Debug.Log(currentSpeed);
        if(Vector3.Distance(transform.position, Selector.transform.position) >= maxDistance){
            currentSpeed *= 1.05f;   
        }else if (Vector3.Distance(transform.position, Selector.transform.position) <= resetDistance)
        {
            if(currentSpeed >= followSpeed * 1.05)
            currentSpeed /= 1.02f; 
        }
    }
    private void LateUpdate() {
        
        transform.position = Vector3.Lerp(transform.position, Selector.transform.position + offset, currentSpeed * Time.deltaTime);
    }

    
    #endregion
}
