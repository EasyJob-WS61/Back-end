Feature: CreateAnnouncements
	As a Applicant I want to create announcements
	I want to create announcements
	Background: 
		Given to Endpoint https://localhost:5001/api/v1/Announcement
		And a Applicant is already stored
		  | Id | Name | Ruc    | Website       | Email              | Password | Photo      |
		  | 1  | luis | 032645 |   youtube.com |   luis@hotmail.com |   123456 |  image.jpg |
    
@post-announcement
Scenario: Add announcement
	When a announcement request is send
		| Title  | Description | Salary | Date   | Visible | Photo  | ApplicantId | Place  | Ability | Period |
		| string | string      | 45.2   | string | 0       | string | 1           | string | string  | string |
  	Then a some Response with status 200 is Received