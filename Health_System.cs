using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_System : MonoBehaviour {
    
    [SerializeField] private float health;
    public float Health {
        get { return health; }
        set { health = value; }
    }
    [SerializeField] private Text healthText;

    private void Start() {
        UpdateHealth();
    }

    public void UpdateHealth() {
        healthText.text = health.ToString("0");
    }
}
