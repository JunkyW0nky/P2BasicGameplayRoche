using System.Collections;
using System.Collections.Generic;
using UnityEngine;








public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void onTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
