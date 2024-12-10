using Assets.Scripts;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    private GameObject camera;
    private GameObject player;
    private GameObject map;
    private GameObject AndroidController;
    void Start()
    {
        if(!GlobalVarsNamespace.sceneLoaded)
        {
            player = Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
            player.name="Player";
            camera = Instantiate(Resources.Load<GameObject>("Prefabs/MainCamera"));
            camera.name = "Camera";
            map = Instantiate(Resources.Load<GameObject>($"Prefabs/Maps/{GlobalVarsNamespace.levelName}"));
            map.name="Map";

            if(Application.platform == RuntimePlatform.Android || true)
            {
                AndroidController = Instantiate(Resources.Load<GameObject>($"Prefabs/AndroidController"));
                AndroidController.name = "AndroidController";
                AndroidController.transform.localScale=new Vector3(0.015f,0.015f);
                AndroidController.transform.position = new Vector3(-7.5f, -2.5f);
            }

            GlobalVarsNamespace.sceneLoaded = true;
        }
    }
    void Update()
    {
        
    }
}
