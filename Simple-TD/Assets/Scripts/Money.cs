using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    public Text moneyCount;

	void Update ()
    {
        moneyCount.text = "€" + PlayerStats.Money.ToString();
	}
}
