using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveMaterialOffset : MonoBehaviour
{
    public Material material;
    public float currenY,speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenY += Time.deltaTime;
        material.SetTextureOffset("_MainTex", new Vector2(0f, currenY * speed)); // _MainTex for Standard shader and for LWRP use "_BaseMap"
    }

    void OnEnable()
    {
        currenY = 0f;
    }
}
