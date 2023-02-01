using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class KeyCollect : MonoBehaviour
{
    public GameObject key;  // Anahtar prefabının referansı

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")  // Oyuncunun etiketi "Player" olmalı
        {
            key.SetActive(false);  // Anahtarı görünmez yap
            // Anahtarı oyuncunun inventarına ekleme işlemi
        }
    }
}



