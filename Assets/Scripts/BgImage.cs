using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BgImage : MonoBehaviour
{
    private Color randomColor;
    // Start is called before the first frame update
    void Start()
    {
        randomColor = new Color(Random.Range(0.1f,1),Random.Range(0.1f,1),Random.Range(0.1f,1));
        GetComponent<SpriteRenderer>().color = randomColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
