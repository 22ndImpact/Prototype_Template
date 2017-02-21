using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_GameDirector : MonoBehaviour
{
    #region Variables
    public string DefaultScene;
    #endregion

    #region Objects
    public static Scr_GameDirector inst;
    [HideInInspector]
    public Scr_Manager_Scene Manager_Scene;
    #endregion

    #region Functions
    void Awake()
    {
        inst = this;

        //Adds a scene manager to the GameDirectors components and sets up a public link to it
        Manager_Scene = gameObject.AddComponent<Scr_Manager_Scene>();
    }

    void Start()
    {
        Manager_Scene.LoadAdditiveScene(DefaultScene);
    }


    #endregion
}
