using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitscreen_Test_Script_P1 : MonoBehaviour {

    [SerializeField]
    private Camera cam;

    //  Start is called before the first frame update
    void Start() {
        //cam = Camera.current;
    }

    //  Update is called once per frame
    void Update() {
        cam.rect = new Rect(0f, 0f, 0.5f, 1f);
    }
}
