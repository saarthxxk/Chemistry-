using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableordisable : MonoBehaviour
{
    public GameObject pic;
    public void Trigger()
    {
        if(pic.activeInHierarchy==true){
            pic.SetActive(false);
        }
        else{
            pic.SetActive(true);
        }
    }
}
