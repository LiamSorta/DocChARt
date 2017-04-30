using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLv : MonoBehaviour {

    public Text thing;
    public void GoGo() {
        if (thing.text == "pARssword") {
            Application.LoadLevel(1);
        } else {
            thing.gameObject.transform.parent.gameObject.GetComponent<InputField>().interactable = false;
        }
    }
}
