using Assets.Scripts;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements.InputSystem;

public class SceneLoader : MonoBehaviour
{
    private GameObject camera;
    private PlayerController player;
    private GameObject map;
    private GameObject player_ui;
    public string OptionalSceneToLoad = "";
    void Start()
    {
        if(!GlobalVarsNamespace.sceneLoaded)
        {
            player = Instantiate(Resources.Load<PlayerController>("Prefabs/Player"));
            player.name="Player";
            player.transform.position = Vector3.zero;
            camera = Instantiate(Resources.Load<GameObject>("Prefabs/MainCamera"));
            camera.name = "Camera";
            map = Instantiate(Resources.Load<GameObject>($"Prefabs/Maps/{(OptionalSceneToLoad.Length>0?OptionalSceneToLoad:GlobalVarsNamespace.levelName)}"));
            map.name="Map";
            player_ui = Instantiate(Resources.Load<GameObject>("Prefabs/PlayerUI"));
            player_ui.name = "player_ui";

            GlobalVarsNamespace.sceneLoaded = true;
        }
    }
    void Update()
    {
        
    }
}
