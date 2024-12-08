using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinselection : MonoBehaviour
{

    public GameObject OffCoinsEffect;
    public Text mytext;
    private int scorenumber;
    public void effect()
    {
        OffCoinsEffect.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        scorenumber = 0;
        mytext.text = "Score : " + scorenumber;
    }
   
    // Update is called once per frame
   
    private async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            //effevct
            OffCoinsEffect.SetActive(true);
           Invoke("effect", 1f);
            //removecoin
            Destroy(other.gameObject);
            //scoreupdate
            scorenumber += 1;
            mytext .text= "Score : " + scorenumber;
           

        }

    }
}