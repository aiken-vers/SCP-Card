using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class avatar : MonoBehaviour
{
    public SpriteRenderer Head, Body, Eye, Ear, Nose, Mug;
    private enum PointDirection { Left, Right }
    public bool right, left;
    public Button ab;
    List<Sprite> Heads = new List<Sprite>();
    List<Sprite> Eyes= new List<Sprite>();
    List<Sprite> Ears = new List<Sprite>();
    List<Sprite> Noses = new List<Sprite>();
    List<Sprite> Bodies = new List<Sprite>();
    List<Sprite> Mugs = new List<Sprite>();
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
        var clickDirection = ab.name.EndsWith("right")? PointDirection.Right : PointDirection.Left;
        if (ab.name.Contains("body"))
        {
            Main.cbody = MoveSpritePointer(Main.cbody, Bodies.Count, clickDirection);            
            Body.sprite = Bodies[Main.cbody];
        }
        else if (ab.name.Contains("head"))
        {
            Main.chead = MoveSpritePointer(Main.chead, Heads.Count, clickDirection);
            Head.sprite = Heads[Main.chead];
        }
        else if (ab.name.Contains("ear"))
        {
            Main.cear = MoveSpritePointer(Main.cear, Ears.Count, clickDirection);
            Ear.sprite = Ears[Main.cear];
        }
        else if (ab.name.Contains("eye"))
        {
            Main.ceye = MoveSpritePointer(Main.ceye, Eyes.Count, clickDirection);            
            Eye.sprite = Eyes[Main.ceye];
        }
        else if (ab.name.Contains("nose"))
        {
            Main.cnose = MoveSpritePointer(Main.cnose, Noses.Count, clickDirection);            
            Nose.sprite = Noses[Main.cnose];
        }
        else if (ab.name.Contains("mug"))
        {
            Main.cmug = MoveSpritePointer(Main.cmug, Mugs.Count, clickDirection);            
            Mug.sprite = Mugs[Main.cmug];
        }
    }

    private int MoveSpritePointer(int pointer, int spritesCount, PointDirection direction)
    {
        if (direction == PointDirection.Right)
            pointer = pointer < spritesCount - 1 ? ++pointer : 0;
        if (direction == PointDirection.Left)
            pointer = pointer > 0 ? --pointer : spritesCount - 1;
        return pointer;
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
