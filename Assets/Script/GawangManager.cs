using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GawangManager : MonoBehaviour
{
    public GameObject Gawang1,Gawang2,Gawang3,Gawang4;

    bool P1 = true, P2 = true, P3 = true, P4 = true;

    public int playerCounter;

    private void Update() {
        if (playerCounter == 3)
        {
            if (P1)
            {
                Debug.Log("P1 Win");
                StaticVarWinner.Winner = "P1 WIN !!";
                SceneManager.LoadScene(3);
            }
            if (P2)
            {
                Debug.Log("P2 Win");
                StaticVarWinner.Winner = "P2 WIN !!";
                SceneManager.LoadScene(3);
            }
            if (P3)
            {
                Debug.Log("P3 Win");
                StaticVarWinner.Winner = "P3 WIN !!";
                SceneManager.LoadScene(3);
            }
            if (P4)
            {
                Debug.Log("P4 Win");
                StaticVarWinner.Winner = "P4 WIN !!";
                SceneManager.LoadScene(3);
            }
        }
    }

    public void gawangActive1(){
        Gawang1.GetComponent<MeshRenderer>().enabled = true;
        Gawang1.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P1 = false;
    }

    public void gawangActive2(){
        Gawang2.GetComponent<MeshRenderer>().enabled = true;
        Gawang2.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P2 = false;
    }

    public void gawangActive3(){
        Gawang3.GetComponent<MeshRenderer>().enabled = true;
        Gawang3.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P3 = false;
    }

    public void gawangActive4(){
        Gawang4.GetComponent<MeshRenderer>().enabled = true;
        Gawang4.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P4 = false;
    }
}
