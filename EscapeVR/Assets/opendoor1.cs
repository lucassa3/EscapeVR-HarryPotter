using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;


public class opendoor1 : MonoBehaviour {

    List<int> lista = new List<int>();
    public Text pass_txt;

    // Use this for initialization

    public void ButtonPushed(int btn)
    {
        pass_txt.text += "* ";
        lista.Add(btn);
        Check();
    }

    void Check()
    {
        AudioSource[] audio = GetComponents<AudioSource>();
        if (lista.Count == 4)
        {
            if (lista[0] == 5)
            {
                if (lista[1] == 3)
                {
                    if (lista[2] == 8)
                    {
                        if (lista[3] == 2)
                        {
                            GetComponent<CircularDrive>().enabled = true;
                            GetComponentInChildren<Canvas>().enabled = false;
                            audio[1].Play();
                            pass_txt.text = " ";
                        }

                        else
                        {
                            lista.Clear();
                            audio[0].Play();
                            pass_txt.text = " ";
                        }

                    }
                    else
                    {
                       lista.Clear();
                       audio[0].Play();
                       pass_txt.text = " ";
                    }
                }
                else
                {
                    lista.Clear();
                    audio[0].Play();
                    pass_txt.text = " ";
                }
            }
            else
            {
                lista.Clear();
                audio[0].Play();
                pass_txt.text = " ";
            }
        }
    }
}
