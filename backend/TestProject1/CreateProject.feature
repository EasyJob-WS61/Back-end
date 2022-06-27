Feature: CreateProject
		As an applicant 
		I want like to add projects to my profile.
	Background:
		 Given the Endpoint https://localhost:5001/api/v1/Projects is available
		 And a postualnt is already stored
		 | Id | Name      | LastName | Description       | Email        | Password | GithubUser | Photo     |
		 | 1  | sebastian | roque    | flutter developer | rn@gmail.com | 123123   | symphony   | image.png |
		 
@post-project
Scenario: Add project
	When a project request is sent
	| Title | Description | Url | Photo | PostulantsId |
	| my project | is my project btw | sdfsf | sdfsdf | 1            |
	Then a Response with status 200 is received