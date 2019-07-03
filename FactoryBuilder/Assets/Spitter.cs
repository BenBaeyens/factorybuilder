using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitter : MonoBehaviour
{

    [SerializeField] GameObject instantiateObjectTemp;

    #region Methods

    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, 2f);
    }

    public void SpawnObject(){
        Instantiate(instantiateObjectTemp, transform.position + Vector3.forward * 2, transform.rotation);
    }

    #endregion
}
