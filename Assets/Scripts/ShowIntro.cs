using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowIntro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    
    public void ShowIntroduction() {
        obj.SetActive(!obj.activeSelf);
    }
}
