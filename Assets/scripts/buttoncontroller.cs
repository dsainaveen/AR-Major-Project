using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class buttoncontroller : MonoBehaviour {
	//public ArrayList pages = {""};
	public int pageno=0;
	public int maxpages = 5;
	public Renderer rend;
	void Start() {
		rend = GetComponent<Renderer> ();
		Material material = (Material)Resources.Load ("con0") as Material;
		rend.material = material;
		//rend.material = con + pageno;
	}

	public void GotoNextPage()
	{   
		if(pageno <= maxpages){
		Debug.Log ("con" + pageno);
		Material material = (Material)Resources.Load ("con" + pageno) as Material;
		/*foreach(Material matt in GetComponent<Renderer>.material)
		{
			if(matt.name == "con"+pageno)
				//do something
				Debug.Log("found materil"+pageno);
			}
			*/
		rend.material = material;
		pageno = pageno+1;
		//Debug.Log("You have clicked next page!");
		//rend.material = Resources.FindObjectsOfTypeAll (typeof(Material))[pageno];
		}else{
			
		}
	}

	public void GotoPreviousPage()
	{ 
		if (pageno >= 0) {
			Material material = (Material)Resources.Load ("con" + pageno) as Material;
			rend.material = material;
			pageno--;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
