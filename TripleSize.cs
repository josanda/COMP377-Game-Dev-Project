using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleSize : MonoBehaviour
{
    public GameObject player;
    public GameObject weapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //player.transform.localScale *= 3;

            weapon.transform.localScale *= 3;
        }
    }
}
