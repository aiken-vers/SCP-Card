﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class levels : MonoBehaviour
{
    public bool active;
    public Button lb;
    public Sprite on;
    public Sprite off;
    private Image li;
    string lvl_spec;
    public SpriteRenderer Card;
    public Button lb0, lb1, lb2, lb3, lb4, lb5;
    public Sprite Hornet;
    public static List<Sprite> Buttons = new List<Sprite>();
    // Start is called before the first frame update
    void Start()
    {
        Buttons = Resources.LoadAll<Sprite>("Buttons/bottoms").ToList(); ;
        //li = lb.image;
        li = GetComponent<Image>();
        //active = false;
        lb.onClick.AddListener(TaskOnClick);
        Alldisable();
        Debug.Log("Name: " + lb.name + "Sprite: " + lb.image.sprite.name);
    }

    // Update is called once per frame
    void Update()
    {
        if(lb.name!=Main.lvl & active)
        {
            to_default();
        }

        if (lvl_spec != Main.spec)
        {
            to_default();
            respec();
        }
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button " + lb.name);
        if (!active)
        {
            li.sprite = on;
            active = true;
            Main.lvl = lb.name;
        }
        else
        {
            li.sprite = off;
            active = false;
        }

        if (lb.name.EndsWith("0"))
        {
            // L0_green_front
            //Card.sprite = Resources.Load<Sprite>("L0_green_front");
            Card.sprite = Resources.Load<Sprite>("Cards/L0_green_front");
            
        }
        else if (lb.name.EndsWith("1"))
        {
            if (lvl_spec == "worker")
            {
                // L1_green_front
                Card.sprite = Resources.Load<Sprite>("Cards/L1_green_front");
            }
            else if (lvl_spec == "simp")
            {
                // L1_yellow_front
                Card.sprite = Resources.Load<Sprite>("Cards/L1_yellow_front");
            }
        }
        else if (lb.name.EndsWith("2"))
        {            
            if (lvl_spec == "TF")
            {
                // L2_cyan_front
                Card.sprite = Resources.Load<Sprite>("Cards/L2_cyan_front");
            }
            else if (lvl_spec == "simp")
            {
                // L2_gold_front
                Card.sprite = Resources.Load<Sprite>("Cards/L2_gold_front");
                
            }
        }
        else if (lb.name.EndsWith("3"))
        {            
            if (lvl_spec == "TF")
            {
                // L3_blue_front
                Card.sprite = Resources.Load<Sprite>("Cards/L3_blue_front");
            }
            else if (lvl_spec == "simp")
            {
                // L3_orange_front
                Card.sprite = Resources.Load<Sprite>("Cards/L3_orange_front");
            }
        }
        else if (lb.name.EndsWith("4"))
        {            
            if (lvl_spec == "TF")
            {
                // L4_violet_front
                Card.sprite = Resources.Load<Sprite>("Cards/L4_violet_front");
            }
            else if (lvl_spec == "simp")
            {
                // L4_pumpkin_front
                Card.sprite = Resources.Load<Sprite>("Cards/L4_pumpkin_front");
            }
        }
        else if (lb.name.EndsWith("5"))
        {
            // L5_black_front
            Card.sprite = Resources.Load<Sprite>("Cards/L5_black_front");
        }
    }
    void to_default()
    {
        li.sprite = off;
        active = false;
    }

    public void Alldisable()
    {
        lb0.interactable = false;
        lb1.interactable = false;
        lb2.interactable = false;
        lb3.interactable = false;
        lb4.interactable = false;
        lb5.interactable = false;
    }
    public void Allenable()
    {
        lb0.interactable = true;
        lb1.interactable = true;
        lb2.interactable = true;
        lb3.interactable = true;
        lb4.interactable = true;
        lb5.interactable = true;
    }
    public void enable_lvl(Button b)
    {
        b.interactable = true;
    }
    public void respec()
    {
        Alldisable();
        string spec = Main.spec;
        lvl_spec = spec;
        SpriteState st;
        st.disabledSprite = Hornet;

        if (spec == "worker")
        {
            enable_lvl(lb0);
            enable_lvl(lb1);
            if (lb.name.EndsWith("1"))
            {                
                off = Buttons[36];
                st.highlightedSprite = Buttons[39];
                st.pressedSprite = Buttons[38];                
                on = Buttons[37];
                
                li.sprite = Buttons[36];
                lb.spriteState = st;                   
            }
            if (lb.name.EndsWith("0"))
            {
                TaskOnClick();
            }
        }
        else if(spec == "TF")
        {
            enable_lvl(lb2);
            enable_lvl(lb3);
            enable_lvl(lb4);

            if (lb.name.EndsWith("2"))
            {
                off = Buttons[20];
                st.highlightedSprite = Buttons[23];
                st.pressedSprite = Buttons[22];
                on = Buttons[21];

                li.sprite = Buttons[20];
                lb.spriteState = st;
                TaskOnClick();
            }
            else if (lb.name.EndsWith("3"))
            {
                off = Buttons[24];
                st.highlightedSprite = Buttons[27];
                st.pressedSprite = Buttons[26];
                on = Buttons[25];

                li.sprite = Buttons[24];
                lb.spriteState = st;
            }
            else if (lb.name.EndsWith("4"))
            {
                off = Buttons[28];
                st.highlightedSprite = Buttons[31];
                st.pressedSprite = Buttons[30];
                on = Buttons[29];

                li.sprite = Buttons[28];
                lb.spriteState = st;
            }
        }
        else if(spec == "simp")
        {
            enable_lvl(lb1);
            enable_lvl(lb2);
            enable_lvl(lb3);
            enable_lvl(lb4);
            enable_lvl(lb5);

            if (lb.name.EndsWith("1"))
            {
                off = Buttons[0];
                st.highlightedSprite = Buttons[3];
                st.pressedSprite = Buttons[2];
                on = Buttons[1];

                li.sprite = Buttons[0];
                lb.spriteState = st;

                TaskOnClick();
            }
            else if (lb.name.EndsWith("2"))
            {
                off = Buttons[4];
                st.highlightedSprite = Buttons[7];
                st.pressedSprite = Buttons[6];
                on = Buttons[5];

                li.sprite = Buttons[4];
                lb.spriteState = st;
            }
            else if (lb.name.EndsWith("3"))
            {
                off = Buttons[8];
                st.highlightedSprite = Buttons[11];
                st.pressedSprite = Buttons[10];
                on = Buttons[9];

                li.sprite = Buttons[8];
                lb.spriteState = st;
            }
            else if (lb.name.EndsWith("4"))
            {
                off = Buttons[12];
                st.highlightedSprite = Buttons[15];
                st.pressedSprite = Buttons[14];
                on = Buttons[13];

                li.sprite = Buttons[12];
                lb.spriteState = st;
            }
        }
    }
}
