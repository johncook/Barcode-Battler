using UnityEngine;
using HutongGames.PlayMaker;

[ActionCategory("My events")]
public class level_time : FsmStateAction
{
	
	public FsmBool updateNow = true;
	public FsmString now = "";
	public FsmString time = "";
	public FsmInt duration = 0;
	
	public override void OnUpdate() {
		if (updateNow.Value)
			now.Value = System.DateTime.UtcNow.ToString(System.Globalization.CultureInfo.InvariantCulture);
	}
	
	public override void OnEnter() {
		if (time.Value.Equals("")) time.Value = System.DateTime.UtcNow.ToString(System.Globalization.CultureInfo.InvariantCulture);
		System.DateTime date = System.DateTime.
			Parse(time.Value, System.Globalization.CultureInfo.InvariantCulture);
		date = date.AddSeconds(duration.Value);
		time.Value = date.ToString(System.Globalization.CultureInfo.InvariantCulture);
	}
	
}
