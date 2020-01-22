using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    public bool doublePoints;
    public bool safeMode;

    public float powerupLength;

    private PowerupManager thePowerUpManager;

    public Sprite[] powerUpSprites;

    // Start is called before the first frame update
    void Start()
    {
        thePowerUpManager = FindObjectOfType<PowerupManager>();
    }

    private void Awake()
    {
        int powerupSelector = Random.Range(0, 2);

        switch (powerupSelector)
        {
            case 0: safeMode = true;
                break;
            case 1: doublePoints = true;
                break;
        }

        GetComponent<SpriteRenderer>().sprite = powerUpSprites[powerupSelector];

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "player")
        {
            thePowerUpManager.ActivatePowerup(doublePoints, safeMode, powerupLength);
        }
        gameObject.SetActive(false);
    }
}
