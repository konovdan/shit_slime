using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public new GameObject camera;
    public GameObject player;
    void Start()
    {
        Instantiate(player);
        Instantiate(camera);
    }
    void Update()
    {
        
    }
}
