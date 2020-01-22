using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_System : MonoBehaviour {
    
    //  Float for health
    [SerializeField] private float health;

    //  Get and set so I can acces the float Health
    //  in pther classes if I need it.
    public float Health {
        get { return health; }
        set { health = value; }
    }

    [SerializeField] private Text healthText;

    //  Start is called before the first frame update
    private void Start() {
        UpdateHealth();
    }

    //  Updates the health on screen
    public void UpdateHealth() {
        healthText.text = health.ToString("0");
    }
}
