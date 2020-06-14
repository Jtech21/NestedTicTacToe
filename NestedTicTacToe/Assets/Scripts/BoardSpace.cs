using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSpace : MonoBehaviour
{
    private GameController gameController;

    public void SetGameControllerReferance(GameController controller)
    {
        gameController = controller;
    }
}
