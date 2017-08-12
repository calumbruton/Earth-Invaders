	#pragma strict

	var moveUp : KeyCode;
	var moveDown : KeyCode;
	var moveLeft : KeyCode;
	var moveRight : KeyCode;

	var speed : float = 3;


	function Update () {
		 if (Input.GetKey(moveUp))
		 {
		  	GetComponent.<Rigidbody2D>().velocity.y = speed;
		 }
		 else if (Input.GetKey(moveDown))
		 {
		 	 GetComponent.<Rigidbody2D>().velocity.y = -speed;

		 }
		 else if (Input.GetKey(moveLeft))
		 {
		 	GetComponent.<Rigidbody2D>().velocity.x = -5;
		 }

		 else if (Input.GetKey(moveRight))
		 {
		 	GetComponent.<Rigidbody2D>().velocity.x = 5;
		 }
		}



