using UnityEngine;
using HutongGames.PlayMaker;

[ActionCategory("My events")]
public class StatisticsLoad : FsmStateAction
{
	
	public FsmGameObject obj;
		
	public override void OnEnter() {
		Statistics stats = (Statistics)obj.Value.GetComponent("Statistics");
		
		stats.strength = PlayerPrefs.GetInt("Strength");
		stats.toughness = PlayerPrefs.GetInt("Toughness");
		stats.agility = PlayerPrefs.GetInt("Agility");
		stats.charisma = PlayerPrefs.GetInt("Charisma");
		stats.health = PlayerPrefs.GetInt("Health");
		stats.fans = PlayerPrefs.GetInt("Fans");
		stats.finisher = PlayerPrefs.GetInt("Finisher");
		stats.signature = PlayerPrefs.GetInt("Signature");
		
		stats.strength = stats.strength < 1 ? 1 : stats.strength;
		stats.toughness = stats.toughness < 1 ? 1: stats.toughness;
		stats.agility = stats.agility < 1 ? 1 : stats.agility;
		stats.charisma = stats.charisma < 1 ? 1 : stats.charisma;
		stats.health = stats.health < 1 ? 1 : stats.health;
		stats.fans = stats.fans < 0 ? 0 : stats.fans;
		stats.finisher = stats.finisher < 1 ? 1 : stats.finisher;
		stats.signature = stats.signature < 1 ? 1 : stats.signature;
		
	}
	
}
