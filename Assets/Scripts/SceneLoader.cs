using Assets.Scripts;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;
    private GameObject map;
    void Start()
    {
        if(!GlobalVarsNamespace.sceneLoaded)
        {
            Instantiate(player);
            Instantiate(camera);
            map = PrefabUtility.LoadPrefabContents("Assets/Prefabs/Maps/map.prefab"); // Dangerous shit! Causes infinite reload
            Instantiate(map);
            GlobalVarsNamespace.sceneLoaded = true;
        }
    }
    void Update()
    {
        
    }
}
