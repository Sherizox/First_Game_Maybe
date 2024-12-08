using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    public GameObject EnterText;
    public GameObject EnterButton;

    public GameObject exitbutton;
    public GameObject exittext;

    
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
              
               EnterText.SetActive(true);
                EnterButton.SetActive(true);
                CarEnterExit.outsideCar = true;
              

            }
            else
            {
                EnterText.SetActive(false);
                EnterButton.SetActive(false);
                CarEnterExit.outsideCar = false;
            }

        }
        private void OnTriggerExit(Collider other)
        {
             
            if (other.gameObject.CompareTag("Player"))
            {
                exitbutton.SetActive(true);
                exittext.SetActive(true);
                CarEnterExit.outsideCar = false;
                EnterText.SetActive(false);
                EnterButton.SetActive(false);
                CarEnterExit.outsideCar = false;

            }
        
        }

    


}
