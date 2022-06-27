Feature: CreateMessage
	as aplicant an postulant
	i want to send messages.
	Background: 
		Given to Endpoint https://localhost:5001/api/v1/Messages
		And a postulant is already stored
		| Id | Name      | LastName | Description       | Email        | Password | GithubUser | Photo     |
		| 1  | sebastian | roque    | flutter developer | rn@gmail.com | 123123   | symphony   | image.png |
  

        And applicant is already stored
	    | Id | Name | Ruc    | Website | Email | Password | Photo |
	    | 1  | luis | 032645 |   youtube.com      |   luis@hotmail.com    |   123456       |  image.jpg     |
	
	
@post-message
Scenario: Add message
	When a message request is send
	    | Description | fromApplicant | Postulant_Id | Applicant_Id | Date | Text     |
	    | string      |  1            | 1            | 1    | unafecha | hola como estas |
	Then a Response with status 200 is Received
    
