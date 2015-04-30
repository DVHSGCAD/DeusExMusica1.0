#pragma strict


function Start () {
	
}

function Update () {
		if(Input.GetAxis("Vertical")){
			

		this.transform.position.y += Input.GetAxis("Vertical")/8;
		
		}
	if(Input.GetAxis("Horizontal")){
	this.transform.position.x += Input.GetAxis("Horizontal")/8;
	}
	
}