using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.GetType().IsInstanceOfType(typeof(PlayerController)));
        if (collision != null)
        {
            IPlayer player = collision.gameObject.ConvertTo<PlayerController>();
            player.health--;
        }

    }

}
