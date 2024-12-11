using UnityEditor.SearchService;
using UnityEngine;
using Assets.Scripts;
public class UILoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject AndroidController;
    private PlayerController trackedObject;
    private IPlayer player;
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android || true)
        {
            AndroidController = Instantiate(Resources.Load<GameObject>($"Prefabs/AndroidController"));
            AndroidController.name = "AndroidController";
            AndroidController.transform.localScale = new Vector3(0.015f, 0.015f);
            AndroidController.transform.position = new Vector3(-7.5f, -2.5f);
        }

        trackedObject = FindAnyObjectByType<PlayerController>();
        player = trackedObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = trackedObject.transform.position;
        position.z = trackedObject.transform.position.z - 10;
        transform.position = position;
    }
    private void FixedUpdate()
    {
        Debug.Log(player.health);
    }
}
