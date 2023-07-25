using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worker : MonoBehaviour
{
    public bool active;
    public Button wb;
    public Sprite on;
    public Sprite off;
    private Image wi;

    public Button work;
    public Button TF;
    public Button simp;
    //private List<Button> specs = new List<Button>();
    // Start is called before the first frame update
    void Start()
    {
        //specs.Add(work);
        //specs.Add(TF);
        //specs.Add(simp);
        wi = wb.image;
        active = false;
        wb.onClick.AddListener(TaskOnClick);
        if (wb.name == "simp")
            TaskOnClick();
    }

    // Update is called once per frame
    void Update()
    {
        if (wb.name != Main.spec && active)
            to_default(); 
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button "+wb.name);        
        if (!active)
        {
            Main.spec = wb.name;
            wi.sprite = on;
            active = true;
        }
        else
        {
            Main.spec = "none";
            wi.sprite = off;
            active = false;
        }
    }
    bool pressed()
    {
        if (active)
            return true;
        return false;
    }
    void to_default()
    {        
        wi.sprite = off;
        active = false;
    }
    void to_active()
    {
        wi.sprite = on;
        active = true;
    }
    void act(bool temp)
    {
        active = temp;
    }
    void check()
    {
        if (active)
        {
            wi.sprite = on;
        }
        else
        {
            wi.sprite = off;
        }
    }
    



}
