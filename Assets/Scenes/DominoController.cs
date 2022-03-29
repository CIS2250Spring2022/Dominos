using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

// Update is called once per frame    
  void Update() {  
    if (Input.GetMouseButtonDown(0)) 
    {
        Debug.Log("clicked");  
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
        RaycastHit hit;  
        if (Physics.Raycast(ray, out hit)) 
        {  
            //Select stage    
            if (hit.transform.gameObject.tag=="Domino") 
            {  
                hit.transform.Rotate(0,0,15);
            }  
        }  
    }  
  }  
}
