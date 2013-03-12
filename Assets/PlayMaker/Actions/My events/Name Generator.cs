using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;

[ActionCategory("My events")]
public class Name_Generator : FsmStateAction {
	
	
	[CompoundArray("First Name", "Spanish", "English")]
	public FsmString[] firstNameEs = { "Rojo","Amarillo","Rosa","Verde","Violeta","Naranja","Azul","Negro","Blanco","Gris","Dorado","Oro","Plata","Bronce","Luz","Oscuro","Enorme","Grande","Promedio","Ordinario","Pequeno","Aburrido","Alegre","Amable","Anciano","Antipático","Apropiado","Aterrador Barato","Bendito","Bonito","Bruto","Bueno","Caliente","Chocante","Confundido","Comico"};
	public FsmString[] firstNameEn = {"Red","Yellow","Pink","Green","Purple","Orange","Blue","Black","White","Gray","Golden","Gold","Silver","Bronze","Light","Dark","Huge","Large","Average","Ordinary","Small","Boring","Happy","Friendly","Elderly","Mean","Appropriate","Appalling Cheap","Blessed","Pretty","Brute","Good","Hot","Shocking","Confused","Comical"};
	
	[CompoundArrayAttribute("Surname", "Spanish", "English")]
	public FsmString[] surnameEs = { "Burro", "Vibora", "Cobarde" };
	public FsmString[] surnameEn = { "Donkey", "Adder", "Coward" };	
		
	public FsmString name = "";
	public FsmString nameEn = "";
	
	public override void OnEnter() {
		int fn = Random.Range(0, firstNameEs.Length);
		int sn = Random.Range(0, surnameEs.Length);
		name.Value = (firstNameEs[fn] + " " + surnameEs[sn]);
		nameEn.Value = (firstNameEn[fn] + " " + surnameEn[sn]);
	}
	
	public override void OnUpdate() {
	}
	
}

/*

name (with translations)

Strength
Charisma
Agility
Toughness
Health

Level Stuff

 */