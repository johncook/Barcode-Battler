using UnityEngine;
using HutongGames.PlayMaker;

[ActionCategory("My events")]
public class StatisticsSave : FsmStateAction
{
	
	public FsmGameObject obj;
		
	public override void OnEnter() {
		Statistics stats = (Statistics)obj.Value.GetComponent("Statistics");
		
		PlayerPrefs.SetInt("Strength", stats.strength);
		PlayerPrefs.SetInt("Toughness", stats.toughness);
		PlayerPrefs.SetInt("Agility", stats.agility);
		PlayerPrefs.SetInt("Charisma", stats.charisma);
		PlayerPrefs.SetInt("Health", stats.health);
		PlayerPrefs.SetInt("Fans", stats.fans);
		PlayerPrefs.SetInt("Finisher", stats.finisher);
		PlayerPrefs.SetInt("Signature", stats.signature);
	}
	
}
