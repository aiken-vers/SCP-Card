using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class skin : MonoBehaviour
{
    public Button sb;
    public SpriteRenderer Body, Head, Ears;
    Color32 bump;

    // Start is called before the first frame update
    void Start()
    {
        bump = new Color32(255, 240, 194, 255);

        sb.onClick.AddListener(TaskOnClick);
        int rnd = Main.rnd_skin;
        if (sb.name.EndsWith(rnd.ToString()))
            TaskOnClick();        
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        if (sb.name == "color0")
        {
            bump = new Color32(255, 240, 194, 255);
        }
        else if (sb.name == "color1")
        {
            bump = new Color32(255, 216, 163, 255);
        }
        else if(sb.name == "color2")
        {
            bump = new Color32(255, 208, 165, 255);
        }
        else if (sb.name == "color3")
        {
            bump = new Color32(250, 184, 148, 255);
        }
        else if (sb.name == "color4")
        {
            bump = new Color32(209, 163, 119, 255);
        }
        else if (sb.name == "color5")
        {
            bump = new Color32(188, 135, 83, 255);
        }
        else if (sb.name == "color6")
        {
            bump = new Color32(154, 110, 74, 255);
        }
        else if (sb.name == "color7")
        {
            bump = new Color32(84, 60, 39, 255);
        }
        Body.color = bump;
        Head.color = bump;
        Ears.color = bump;
    }
    public void get_rnd()
    {
        int rnd = Random.Range(0, 8);

        if (rnd== 0)
        {
            bump = new Color32(255, 240, 194, 255);
        }
        else if (rnd == 1)
        {
            bump = new Color32(255, 216, 163, 255);
        }
        else if (rnd == 2)
        {
            bump = new Color32(255, 208, 165, 255);
        }
        else if (rnd == 3)
        {
            bump = new Color32(250, 184, 148, 255);
        }
        else if (rnd == 4)
        {
            bump = new Color32(209, 163, 119, 255);
        }
        else if (rnd == 5)
        {
            bump = new Color32(188, 135, 83, 255);
        }
        else if (rnd == 6)
        {
            bump = new Color32(154, 110, 74, 255);
        }
        else if (rnd == 7)
        {
            bump = new Color32(84, 60, 39, 255);
        }

        Body.color = bump;
        Head.color = bump;
        Ears.color = bump;
    }


}
