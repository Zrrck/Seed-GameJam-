using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{

    public bool isFiring;

    public WaterBaloon waterBaloonShot;
    public float baloonSpeed;
    public float timeBeetweenShots;
    public float shotCounter;
    
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;

            if (shotCounter < 0)
            {
                shotCounter = timeBeetweenShots;
                WaterBaloon newWaterBaloon = Instantiate(waterBaloonShot, firePoint.position, firePoint.rotation) as WaterBaloon;
                newWaterBaloon.bulletSpeed = baloonSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
    }
}
