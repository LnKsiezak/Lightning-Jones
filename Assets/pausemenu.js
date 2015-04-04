#pragma strict
var pauseCanvas : Canvas;

function Start () {
    Screen.lockCursor = true;
    Screen.showCursor = false;
    Time.timeScale = 1;
}

function Update () {
    if(Input.GetKeyDown(KeyCode.P))
    {      
        
        pauseCanvas.enabled = true;
        Time.timeScale = 0;
        Screen.lockCursor = false;
        Screen.showCursor = true;
    }
}
function ResumeGame (){    
    
   pauseCanvas.enabled = false;
    Time.timeScale = 1;
    Screen.lockCursor = true;
    Screen.showCursor = false;
} 

function ExitGame () {
Application.Quit ();
}

function ExitMenu(){
Application.LoadLevel("main-menu");
pauseCanvas.enabled = false;
Time.timeScale = 1;
}