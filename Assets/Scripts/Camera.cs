using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject trackedObject;
    // Start is called before the first frame update
    void Start()
    {
        trackedObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 position = trackedObject.transform.position;
        position.z = -10;
        transform.position = position;
        
    }
    public void OnMove()
    {
        Debug.Log("Moved!");
    }
}
