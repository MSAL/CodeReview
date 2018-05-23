/*
* The given code respect the CamelCase and the logic is correct 
* But the choice of IF Statement it's not the best in this case 
* A better choice is to use SWITCH statement in place of IF Statement
* Because the idea in the code is to pick ONE case from 3. SO to make 
* the code more clearer we have to change the IF statement with SWITCH 
*/
switch(message.GetType.ToString()){
	
  case "MessageA": 
		var messageA = message as MessageA ; 
		messageA?.MyCustomMethodOnA();
  break;
  
  case "MessageB": 
		var messageB = message as MessageB ; 
		messageB?.MyCustomMethodOnB();
		messageB?.SomeAdditionalMethodOnB();
		break;
		
  case "MessageC":
		var messageC = message as MessageC ;
		messageC?.MyCustomMethodOnC();
		break;
}