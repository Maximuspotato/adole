using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyController : MonoBehaviour
{
    private GameObject bodypart, holder;
    public GameObject female_breasts;

    public Text info;
    // Start is called before the first frame update
    void Start()
    {
        bodypart = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        if (bodypart.name == "breasts")
        {
            holder = Instantiate(female_breasts, bodypart.transform.parent);
        }
    }

    private void OnMouseExit()
    {
        Destroy(holder);
    }

    private void OnMouseDown()
    {
        if (bodypart.name == "breasts")
        {
            info.text = "Breasts develop";
        }
    }
}
