using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class skin : MonoBehaviour
{
    public Button sb;
    public SpriteRenderer Body, Head, Ears;
    Color32 activeColor;

    public static Dictionary<int, Color32> SkinColor = ()
    {
        { 0, new Color32(255, 240, 194, 255) },
        { 1,  new Color32(255, 216, 163, 255) },
        { 2, new Color32(255, 208, 165, 255) },
        { 3, new Color32(250, 184, 148, 255) },
        { 4, new Color32(209, 163, 119, 255) },
        { 5, new Color32(188, 135, 83, 255) },
        { 6, new Color32(154, 110, 74, 255) },
        { 7, new Color32(84, 60, 39, 255) }
    };

    // Start is called before the first frame update
    void Start()
    {
        activeColor = SkinColor[0];

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
        var sbname = sb.name;
        var colorNum = Convert.ToInt32(String.Join("", sbname.Where(char.IsDigit)));
        activeColor = SkinColor[colorNum];        
        Body.color = activeColor;
        Head.color = activeColor;
        Ears.color = activeColor;
    }
    public void get_rnd()
    {
        int rnd = Random.Range(0, 8);
        activeColor = SkinColor[rnd];
        Body.color = activeColor;
        Head.color = activeColor;
        Ears.color = activeColor;
    }
}
