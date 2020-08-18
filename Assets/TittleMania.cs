using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TittleMania : MonoBehaviour
{

    public List<Sprite> myTittles = new List<Sprite>();
        public Image titleImage;

    
    // Start is called before the first frame update
    public void HideTittle()
    {
        titleImage.GetComponent<Image>().sprite = myTittles[myTittles.Count-1];
    }

    // Update is called once per frame
    public void ShowTittle(int tittled)
    {
        titleImage.GetComponent<Image>().sprite = myTittles[tittled];
    }
}
