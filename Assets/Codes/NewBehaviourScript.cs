using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    
    [SerializeField] float bulletTimeInterval = 3f, hajoo = 3f;
    
    float bulletTime = 0;
    


    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {

        CreateBullet();
    
          
    }

    void CreateBullet()
    {
        if (bulletTime <=0f)
        {
            //GameObject newObject = Instantiate(bullet, transform.position, transform.rotation);
            GameObject newObject = Instantiate(bullet,transform.position, Quaternion.Euler(0,0,90));
            bulletTime = bulletTimeInterval;
            Destroy(newObject, hajoo);
        }
        bulletTime -= Time.deltaTime;
    }
}
