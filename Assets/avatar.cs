using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class avatar : MonoBehaviour
{
    public SpriteRenderer Head, Body, Eye, Ear, Nose, Mug;
    public bool right, left;
    public Button ab;
    List<Sprite> Heads = new List<Sprite>();
    List<Sprite> Eyes= new List<Sprite>();
    List<Sprite> Ears = new List<Sprite>();
    List<Sprite> Noses = new List<Sprite>();
    List<Sprite> Bodies = new List<Sprite>();
    List<Sprite> Mugs = new List<Sprite>();
    //int chead, cbody, ceye, cear, cnose; 
    // Start is called before the first frame update
    void Start()
    {
        LoadLists();
        ab.onClick.AddListener(TaskOnClick);

        if (!Main.rnd_avatar)
        {
            Main.rnd_avatar = true;
            get_rnd();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
        if (ab.name.Contains("body"))
        {
            if (ab.name.EndsWith("right"))
            {
                if (Main.cbody < Bodies.Count - 1)
                    Main.cbody++;
                else
                    Main.cbody = 0;
            }
            else if (ab.name.EndsWith("left"))
            {
                if (Main.cbody > 0)
                    Main.cbody--;
                else
                    Main.cbody = Bodies.Count - 1;
            }
            Body.sprite = Bodies[Main.cbody];
        }
        else if (ab.name.Contains("head"))
        {
            if (ab.name.EndsWith("right"))
            {
                if (Main.chead < Heads.Count - 1)
                    Main.chead++;
                else
                    Main.chead = 0;
            }
            else if (ab.name.EndsWith("left"))
            {
                if (Main.chead > 0)
                    Main.chead--;
                else
                    Main.chead = Heads.Count - 1;
            }
            Head.sprite = Heads[Main.chead];
        }
        else if (ab.name.Contains("ear"))
        {
            if (ab.name.EndsWith("right"))
            {
                if (Main.cear < Ears.Count - 1)
                    Main.cear++;
                else
                    Main.cear = 0;
            }
            else if (ab.name.EndsWith("left"))
            {
                if (Main.cear > 0)
                    Main.cear--;
                else
                    Main.cear = Ears.Count - 1;
            }
            Ear.sprite = Ears[Main.cear];
        }
        else if (ab.name.Contains("eye"))
        {
            if (ab.name.EndsWith("right"))
            {
                if (Main.ceye < Eyes.Count - 1)
                    Main.ceye++;
                else
                    Main.ceye = 0;
            }
            else if (ab.name.EndsWith("left"))
            {
                if (Main.ceye > 0)
                    Main.ceye--;
                else
                    Main.ceye = Eyes.Count - 1;
            }
            Eye.sprite = Eyes[Main.ceye];
        }
        else if (ab.name.Contains("nose"))
        {
            if (ab.name.EndsWith("right"))
            {
                if (Main.cnose < Noses.Count - 1)
                    Main.cnose++;
                else
                    Main.cnose = 0;
            }
            else if (ab.name.EndsWith("left"))
            {
                if (Main.cnose > 0)
                    Main.cnose--;
                else
                    Main.cnose = Noses.Count - 1;
            }
            Nose.sprite = Noses[Main.cnose];
        }
        else if (ab.name.Contains("mug"))
        {
            if (ab.name.EndsWith("right"))
            {
                if (Main.cmug < Mugs.Count - 1)
                    Main.cmug++;
                else
                    Main.cmug = 0;
            }
            else if (ab.name.EndsWith("left"))
            {
                if (Main.cmug > 0)
                    Main.cmug--;
                else
                    Main.cmug = Mugs.Count - 1;
            }
            Mug.sprite = Mugs[Main.cmug];
        }
    }

    void LoadLists()
    {
        Heads = Resources.LoadAll<Sprite>("Avatar/head").ToList();
        Ears = Resources.LoadAll<Sprite>("Avatar/ears").ToList();
        Bodies = Resources.LoadAll<Sprite>("Avatar/body").ToList();
        Eyes = load_list("eyes", 20);
        Noses = load_list("nose", 20);
        Mugs = load_list("throat", 20);
    }

    List<Sprite> load_list(string lname, int count)
    {
        List<Sprite> temp = new List<Sprite>();
        for(int i = 1; i <= count; i++)
        {            
            temp.Add(Resources.Load<Sprite>($"Avatar/{lname}/{lname+i}"));
        }
        return temp;
    } 
    
    public void get_rnd()
    {
        Main.cbody = Random.Range(0, Bodies.Count - 1);
        Main.chead = Random.Range(0, Heads.Count - 1);
        Main.cear = Random.Range(0, Ears.Count - 1);
        Main.ceye = Random.Range(0, Eyes.Count - 1);
        Main.cnose = Random.Range(0, Noses.Count - 1);
        Main.cmug = Random.Range(0, Mugs.Count - 1);

        Body.sprite = Bodies[Main.cbody];
        Head.sprite = Heads[Main.chead];
        Ear.sprite = Ears[Main.cear];
        Eye.sprite = Eyes[Main.ceye];
        Nose.sprite = Noses[Main.cnose];
        Mug.sprite = Mugs[Main.cmug];
    }

}
