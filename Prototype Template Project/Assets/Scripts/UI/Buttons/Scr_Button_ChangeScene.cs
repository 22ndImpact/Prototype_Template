using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Button_ChangeScene : MonoBehaviour
{
    #region Functions
    /// <summary>
    /// Uses the global GameDirector to load a full new scene while unloading all other scene
    /// </summary>
    /// <param name="_Scene">The scene to load</param>
    public void ChangeSceneFull(string _Scene)
    {
        //Unloads all other scenes before loading the new one
        Scr_GameDirector.inst.Manager_Scene.UnloadAllScenes();

        //Loads the new scene
        Scr_GameDirector.inst.Manager_Scene.LoadAdditiveScene(_Scene);
    }
    #endregion
}
