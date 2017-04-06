using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIHandManager : MonoBehaviour {

    private CombatManager combatManager;
    private Player player;

    public GameObject UIcard;

    private List<GameObject> hand;

	// Use this for initialization
	void Start () {
        combatManager = CombatManager.instance;
        if (combatManager == null)
            combatManager = new CombatManager();
        player = combatManager.player as Player;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
