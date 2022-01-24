using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform mainTransform;
    float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {    
        //StartCoroutine("FireRoutine");
    }


    // Update is called once per frame
    void Update()
    {
        mainTransform.position += mainTransform.up * moveSpeed * Time.deltaTime;
            if(gameObject.name == "Bullet(Clone)")
            {
                Destroy(gameObject, 1.5f);
            }
    }
}
