using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Inst{get; private set;}
    void Awake() => Inst = this;

    [SerializeField] NotificationPanel notificationPanel;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR
        InputCheatKey();
        #endif
    }

    void InputCheatKey()
    {
               
            if (Input.GetKeyDown(KeyCode.Alpha0)) 
                TurnManager.OnAddCard?.Invoke(true);

            if (Input.GetKeyDown(KeyCode.Alpha1)) 
                TurnManager.OnAddCard?.Invoke(false);
            if (Input.GetKeyDown(KeyCode.Alpha2))
                TurnManager.Inst.EndTurn();
        
    }
    public void StartGame()
    {
        StartCoroutine(TurnManager.Inst.StartGameCo());
    }

    public void Notification(string message)
    {
        notificationPanel.Show(message);
    }
}
