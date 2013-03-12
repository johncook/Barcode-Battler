using UnityEngine;
using HutongGames.PlayMaker;

[ActionCategory("My events")]
public class Signature : FsmStateAction
{
	
	public string[] Varient = { "Carlos", "Daniel", "Luis", "Jose", "Javier", "Jesus", "Rodrigo", "Cesar", "Eduardo", "David"};
	public string[] Base_Move = { "Garcia", "Martinez", "Rodriguez", "Lopez", "Hernandez",
		"Gonzales", "Perez", "Sanchez", "Rivera", "Ramirez" };
	public FsmString name = "";
	
	
	// Code that runs on entering the state.
	public override void OnEnter()
	{
		name.Value = (Varient[Random.Range(0, Varient.Length)] + " " + Base_Move[Random.Range(0, Base_Move.Length)]);
		
	}

	// Code that runs every frame.
	public override void OnUpdate()
	{
		
	}


}
