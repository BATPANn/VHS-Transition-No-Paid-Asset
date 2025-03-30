using System.Collections;
using UnityEngine;

public class VHSTransitionNoPlugin : MonoBehaviour
{



    public GameObject VHSTransitionPPGO;

    bool ChangedState = false;

    public GameObject PlayerCam1;
    public GameObject PlayerCam2;

    public AudioSource Source;

    public AudioClip Clip;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKeyDown(KeyCode.T) && ChangedState == false)
        {


            ChangedState = true;

            StartCoroutine(VHSTransitionPPCO());




        }



        
    }




    IEnumerator VHSTransitionPPCO()
    {



        Source.PlayOneShot(Clip);


        VHSTransitionPPGO.SetActive(true);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(false);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(true);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(false);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(true);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(false);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(true);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(false);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(true);

        yield return new WaitForSeconds(0.05f);

        VHSTransitionPPGO.SetActive(false);

        

        // change camera


        PlayerCam1.SetActive(false);
        PlayerCam2.SetActive(true);


        // change camera









    }




}
