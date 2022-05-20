using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{

    public float speed;
    public bool toRight;

    public GameObject baseIzq;
    public GameObject baseDer;

    public GameObject prefab1;
    public GameObject prefab2;

    int yOffSet;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
        yOffSet = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x > baseDer.transform.position.x - 1)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseDer.transform.position + new Vector3(0, yOffSet, 0);
            
            
        }
        if(transform.position.x < baseIzq.transform.position.x + 1)
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseIzq.transform.position + new Vector3(0, yOffSet, 0);

        }
    }
}
