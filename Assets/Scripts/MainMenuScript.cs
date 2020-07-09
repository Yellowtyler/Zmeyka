using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class MainMenuScript : MonoBehaviour {
    string path = @"progress.txt";
    public void play()
    {
        using (StreamWriter f = new StreamWriter(path, false))
        { f.WriteLine("1"); }
        Application.LoadLevel(1);
    }
    public void Quit()
    {
        Application.Quit();
    } 
    public void Continue()
    {
        string s;
        int lvl;
        
        using(StreamReader f = File.OpenText(path))
            {
            s = f.ReadLine();
        }
        lvl = Int32.Parse(s);
        Application.LoadLevel(lvl);
    }
}
