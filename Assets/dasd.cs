
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dasd : MonoBehaviour
{


    public GameObject cub;
    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = cub.GetComponent<Transform>();
    }

  void Update()
    {
        tr.position =new Vector2(2,0);
    }

  
         }