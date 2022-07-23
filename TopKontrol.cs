using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    [SerializeField] int hiz, objeSayisi;
    [SerializeField] Text puanYazisi, oyunBittiYazisi;
    int puan = 0;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float yatayHareket = Input.GetAxis("Horizontal");
        float dikeyHareket = Input.GetAxis("Vertical");

        Vector3 vektor = new Vector3(yatayHareket, 0f, dikeyHareket);

        fizik.AddForce(vektor * hiz);
    }

    void OnTriggerEnter(Collider temas)
    {
        temas.gameObject.SetActive(false);
        puan++;
        puanYazisi.text = "Puan : " + puan;

        if(puan == objeSayisi)
        {
            oyunBittiYazisi.text = "Oyun Bitti";
            oyunBittiYazisi.gameObject.SetActive(true);
        }
    }
}
