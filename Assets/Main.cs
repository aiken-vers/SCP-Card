using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static string spec;
    public static string lvl;
    public static int chead, cbody, ceye, cear, cnose, cmug;
    public static int rnd_skin = Random.Range(0, 8);
    public static bool rnd_avatar = false;
    //public static Button worker;
    //public static Button TF;
    //public static Button scientist;
    //public static Button L0;
    //public static Button L1;
    //public static Button L2;
    //public static Button L3;
    //public static Button L4;
    //public static Button L5;


    // Start is called before the first frame update
    void Start()
    {
        //rnd_skin = Random.Range(6, 8);
        spec = "simp";
        lvl = "none";
        chead = cbody = ceye = cear = cnose = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
