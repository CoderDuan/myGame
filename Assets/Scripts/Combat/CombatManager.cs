using UnityEngine;
using System.Collections;

public enum Turn
{
    PLAYERSTURN = 0,
    MONSTERSTURN,
    NONBATTLE,
};

public class CombatManager : MonoBehaviour {
    
    public static GameObject instance = null;
    public static string instanceName = "CombatManager";

    [HideInInspector]
    public Turn thisTurn = Turn.PLAYERSTURN;
    [HideInInspector]
    public Turn nextTurn = Turn.MONSTERSTURN;

    public Creature player;
    public Creature monster;
    
	void Awake()
    {
        Debug.Log("CombatManager.Awake()");
        DontDestroyOnLoad(instance);
        getInstance();
	}

    public static GameObject getInstance()
    {
        if (instance == null)
        {
            instance = new GameObject();
            instance.name = instanceName;
            instance.AddComponent(typeof(CombatManager));
        }
        return instance;
    }

    void Start()
    {
        player = new Player(20, 2, 2, 3);
        monster = new Monster("Orc", 20, 0, 2, 3);

        initCombat();
    }

    void initCombat()
    {
        for (int i = 0; i < 10; i++)
        {
            player.AddDeck("Attack1");
            monster.AddDeck("Attack1");
        }
    }

    public void TakeTurn()
    {

    }

    public void EndTurn(Creature whoends)
    {
        whoends.DrawHand();
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

        player.CreateDeckTemp();
        monster.CreateDeckTemp();
        player.DrawHand();
        monster.DrawHand();
    }

    public void BattleEnd()
    {
        thisTurn = Turn.NONBATTLE;
        nextTurn = Turn.NONBATTLE;
    }
}
