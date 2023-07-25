using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject Menu1, Menu2, Menu3;
    // Start is called before the first frame update
    void Start()
    {
        Menu1.SetActive(true);
        Menu2.SetActive(false);
        Menu3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
