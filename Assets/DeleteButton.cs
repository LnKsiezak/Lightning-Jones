using UnityEngine;
using System.Collections;

public class DeleteButton : MonoBehaviour
{

    bool enable = true;
    Rect button1 = new Rect(250, 150, 150, 70);


    void OnGUI()
    {
               
        if (enable)
        {
            Time.timeScale = 0;
            if (GUI.Button(button1, "Play Game"))
            {
                Time.timeScale = 1;
                enable = false;
                
            }
        }
    }
}
  

 
