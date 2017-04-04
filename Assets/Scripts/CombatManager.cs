using UnityEngine;
using System.Collections;

public enum Turn
{
    PLAYERSTURN = 0,
    MONSTERSTURN,
};

public class CombatManager : MonoBehaviour {

    public static CombatManager instance = null;

    [HideInInspector]
    public Turn thisTurn = Turn.PLAYERSTURN;
    [HideInInspector]
    public Turn nextTurn = Turn.MONSTERSTURN;

    public Creature Player;
    public Creature Monster;
    
	void Awake () {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
