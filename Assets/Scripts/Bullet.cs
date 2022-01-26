using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveTime;
    private float elapsed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireRoutine());    
            IEnumerator FireRoutine()
            {
               while (elapsed <= moveTime)
               {
                    mainTransform.position += mainTransform.up * moveSpeed * Time.deltaTime;
                    elapsed += Time.deltaTime; 
                    yield return null;
                }
            Destroy(gameObject);
            }
    }


}

