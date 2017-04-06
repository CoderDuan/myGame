using UnityEngine;
using System.Collections;

public enum Turn
{
    PLAYERSTURN = 0,
    MONSTERSTURN,
    NONBATTLE,
};

public class CombatManager : MonoBehaviour {

    public static CombatManager instance = null;

    [HideInInspector]
    public Turn thisTurn = Turn.PLAYERSTURN;
    [HideInInspector]
    public Turn nextTurn = Turn.MONSTERSTURN;

    public Creature player;
    public Creature monster;
    
	void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
	}

    void Start()
    {
        player = new Player(20, 2, 2);
        monster = new Monster("Orc", 20, 0, 2);
    }

    public void TakeTurn()
    {

    }

    public void EndTurn(Creature whoends)
    {
        if (nextTurn == Turn.PLAYERSTURN)
        {
            thisTurn = Turn.PLAYERSTURN;
            nextTurn = Turn.MONSTERSTURN;
        } else
        {
            thisTurn = Turn.MONSTERSTURN;
            nextTurn = Turn.PLAYERSTURN;
        }
    }

    public void BattleStart()
    {
        thisTurn = Turn.PLAYERSTURN;
        nextTurn = Turn.MONSTERSTURN;
    }

    public void BattleEnd()
    {
        thisTurn = Turn.NONBATTLE;
        nextTurn = Turn.NONBATTLE;
    }
}
