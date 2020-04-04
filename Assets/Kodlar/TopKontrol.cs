using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz = 20;
    public int sayac = 0;
    public int toplanilacakObjeSayisi = 11;

    public Text Score;
    public Text OyunBitti;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        

        Vector3 vec = new Vector3(yatay, 0,dikey);

        fizik.AddForce(hiz*vec);
         
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "silinecek")
        {
            other.gameObject.SetActive(false);
            sayac++;
            Score.text = "Score:" + sayac;
            
        }
        if (sayac == toplanilacakObjeSayisi)
        {
            OyunBitti.text = "OYUN BİTTİ";
        }

         
    }
}
