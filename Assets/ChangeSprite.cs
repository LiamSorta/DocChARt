using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour {
    // Use this for initialization
	public void ChangeIt(Sprite sp) {
        GameObject.Find("ThingYes").GetComponent<Image>().sprite = sp;
    }
}
