using UnityEngine;
using HutongGames.PlayMaker;

[ActionCategory("My events")]
public class finisher : FsmStateAction
{
	
	public string[] Prefix = { "Carlos", "Daniel", "Luis", "Jose", "Javier", "Jesus", "Rodrigo", "Cesar", "Eduardo", "David"};
	public string[] Suffix = { "Garcia", "Martinez", "Rodriguez", "Lopez", "Hernandez",
		"Gonzales", "Perez", "Sanchez", "Rivera", "Ramirez" };
	public string[] Noun = { "Garcia", "Martinez", "Rodriguez", "Lopez", "Hernandez",
		"Gonzales", "Perez", "Sanchez", "Rivera", "Ramirez" };
	public FsmString name = "";
	
	
	// Code that runs on entering the state.
	public override void OnEnter()
	{
		name.Value = (Prefix[Random.Range(0, Prefix.Length)] + Suffix[Random.Range(0, Suffix.Length)] + " " + Noun[Random.Range(0, Noun.Length)]);
		
	}

	// Code that runs every frame.
	public override void OnUpdate()
	{
		
	}


}
