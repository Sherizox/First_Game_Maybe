using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarEnterExit : MonoBehaviour
{
    public GameObject EnterText;
    public GameObject ExitText;
    public GameObject EnterButton;
    public GameObject ExitButton;

    public GameObject CarCamera;
    public GameObject playerCamera;
    public GameObject TriggerObject;
    public GameObject playerMain;

    public Transform carTransform;
    public GameObject carcanvas;
    public GameObject playercanvas;

    public Transform EnterPlayerPosition;
    public Transform ExitPlayerPosition;

    public static bool insideCar = false;
    public static bool outsideCar = false;

    void Start()
    {

    }

    // Update is called once per frame
   
    void Update()
    {

        //Enter Car
        if (Input.GetKeyDown(KeyCode.F) && outsideCar == true)
        {
            EnterButton.SetActive(false);
            EnterText.SetActive(false);
            ExitButton.SetActive(true);
            ExitText.SetActive(true);
            playerCamera.SetActive(false);
            playerMain.transform.SetParent(carTransform);
            playerMain.SetActive(false);
       
            playercanvas.SetActive(false);
            carcanvas.SetActive(true);

            this.gameObject.GetComponent<RCC_CarControllerV3>().enabled = true;
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
          
            insideCar = true;

            StartCoroutine(PauseForCamera());



    

        }

         //Exit Car
        if (Input.GetKeyDown(KeyCode.G) && insideCar == true)
        {

          
           ExitButton.SetActive(false);
           ExitText.SetActive(false);

           playerCamera.SetActive(true);
           CarCamera.SetActive(false);
           playercanvas.SetActive(true);
           carcanvas.SetActive(false);

          this.gameObject.GetComponent<RCC_CarControllerV3>().enabled = false;
          
             
                
               insideCar = false;


           StartCoroutine(ExitCourotine());
        }


    }



        IEnumerator PauseForCamera()
        {
            yield return new WaitForSeconds(0);
            CarCamera.SetActive(true);

            
        }

        IEnumerator ExitCourotine()
        {
            yield return new WaitForSeconds(0);
         
            playerMain.transform.SetParent(carTransform, true);
            playerCamera.SetActive(true);
            playerMain.SetActive(true);
            CarCamera.SetActive(false);



        }



        //For Buttons
        public void EnterCarFunction()
        {
     
            EnterButton.SetActive(false);
            EnterText.SetActive(false);
            ExitButton.SetActive(true);
            ExitText.SetActive(true);
            playerCamera.SetActive(false);
             playercanvas.SetActive(false);
          carcanvas.SetActive(true);
          playerMain.transform.SetParent(carTransform);
            playerMain.SetActive(false);
          

            this.gameObject.GetComponent<RCC_CarControllerV3>().enabled = true;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
 


        CarCamera.SetActive(false);
          
            StartCoroutine(PauseForCamera());
        }

        public void ExitCarFunction()
        {
    
      
           ExitButton.SetActive(false);
            ExitText.SetActive(false);


           playercanvas.SetActive(true);
          carcanvas.SetActive(false);
   
     
          this.gameObject.GetComponent<RCC_CarControllerV3>().enabled = false;
  
        

            insideCar = false;

          
            StartCoroutine(ExitCourotine());
        }
                     
    
        
    
} 
