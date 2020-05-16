using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBaloon : MonoBehaviour
{

    public float bulletSpeed;

    public float lifeTime;

    public int damageToGive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

        lifeTime -= Time.deltaTime;

        if (lifeTime < 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Baby")
        {
            other.gameObject.GetComponent<BabyHealtManager>().HurtBaby(damageToGive);
            Debug.Log("Collution");
        }
    }
}
