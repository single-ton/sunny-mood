using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemInteraction : MonoBehaviour
{
    public AudioSource pickGemAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Destroy(gameObject);
            pickGemAudio.Play();
        }
    }
}
