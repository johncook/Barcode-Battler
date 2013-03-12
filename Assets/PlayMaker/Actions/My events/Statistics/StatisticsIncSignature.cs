using UnityEngine;
using HutongGames.PlayMaker;

[ActionCategory("My events")]
public class StatisticsIncSignature : FsmStateAction
{
	
	public FsmGameObject obj;
		
	public override void OnEnter() {
		Statistics stats = (Statistics)obj.Value.GetComponent("Statistics");
		
		stats.signature++;
		
	}
	
}
