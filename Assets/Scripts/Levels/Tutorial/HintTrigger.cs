using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HintTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private bool once = false;
    public string text;

    private void OnEnable()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && !once)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().SetText(text);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
