using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mods
{
    public string category{ get; set; }
    public string preview_path{ get; set; }
    public string file_path { get; set; }
    public string title{ get; set; }

    public string description { get; set; }
    //public string[] categories;
}

public class ModsList
{
    public List<Mods> mods{ get; set; }
    public List<string> categories{ get; set; }
}