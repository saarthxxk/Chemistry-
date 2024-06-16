using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class onclick : MonoBehaviour
{
    private Animator anime;

    void Start(){
        anime = GetComponent<Animator>();
    }
    void OnMouseDown(){
        Debug.Log("Trigger");
        anime.Play("sscsplit");



            
        
    }
}
