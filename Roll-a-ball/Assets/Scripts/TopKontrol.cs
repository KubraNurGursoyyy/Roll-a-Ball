using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public int hiz;
    public Rigidbody fizik;
    public int puan;
    public int objeSayisi;
    public Text puanText;
    public Text oyunBittiText;

    // Start is called before the first frame update
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Debug.Log("Esc");
        //}

        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vector * hiz);

    }

    //bir çarpışma olduğu anda bu fonksiyon tetiklenir
    void OnTriggerEnter(Collider other)//collider çarpışma demek
    {
        //buradaki other çarpışma yaşanan şey oluyor
        //Destroy(other.gameObject);//bu other game object diyoruz bu şekilde
        other.gameObject.SetActive(false);
        puan++;

        puanText.text = "Puan : " + puan;

        if(puan == objeSayisi)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
    
    }

}
