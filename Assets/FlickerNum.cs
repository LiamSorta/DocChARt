using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlickerNum : MonoBehaviour {
    Text me;
    [SerializeField]
    float min, max;

    [SerializeField]
    float minHack, maxHack;

    bool hack;
	// Use this for initialization
	void Start () {
        me = GetComponent<Text>();
        if (me.text.Contains("/"))
            hack = true;
	}
	
	// Update is called once per frame
	void Update () {
        if((int)Random.Range(0f,20f) == 10) {
            Change();
        }
	}

    void Change() {
        if(hack)
            me.text = ((int)Random.Range(min, max)).ToString() + "/" + ((int)Random.Range(minHack, maxHack)).ToString();
        else
            me.text = ((int)Random.Range(min, max)).ToString();

    }
}
