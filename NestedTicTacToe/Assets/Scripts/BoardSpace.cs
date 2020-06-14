using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardSpace : MonoBehaviour
{
    private GameController gameController;
    public Button[] buttonlist;
    

    public void SetGameControllerReferance(GameController controller)
    {
        gameController = controller;
    }
}
