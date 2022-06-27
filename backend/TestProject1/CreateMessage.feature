Feature: CreateMessage
	as aplicant an postulant
	i want to send messages.
	Background: 
		Given to Endpoint https://localhost:5001/api/v1/Messages
		And a postualnt is already stored
		| Id | Name      | LastName | Description       | Email        | Password | GithubUser | Photo     |
		| 1  | sebastian | roque    | flutter developer | rn@gmail.com | 123123   | symphony   | image.png |
        And applicant is already stored
	    | Id | Name | Ruc    | Website | Email | Password | Photo |
	    | 1  | luis | 032645 |   youtube.com      |   luis@hotmail.com    |   123456       |  image.jpg     |
	
	
@post-message
Scenario: Add message
	When a message request is send
	    | fromApplicant | Postulant_Id    | Applicant_Id | Date       | Text                |
	    |     sebastian |    1            |       1      |  20-10-21  |  hola como estas    |
	Then a Response with status 200 is received
    
