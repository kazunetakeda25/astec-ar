using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveRockMat2 : MonoBehaviour
{
    public Material material;
    public float currenX,speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenX += Time.deltaTime;
        material.SetTextureOffset("_MainTex", new Vector2( currenX * speed,0f)); // _MainTex for Standard shader and for LWRP use "_BaseMap" //BaseColorMap
    }

    void OnEnable()
    {
        currenX = 0f;
    }
}
