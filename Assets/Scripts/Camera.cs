using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject trackedObject;
    void Start()
    {
        trackedObject = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 position = trackedObject.transform.position;
        position.z = -10;
        transform.position = position;
        
    }

}
