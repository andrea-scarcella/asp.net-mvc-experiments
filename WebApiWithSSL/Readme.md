
The requirements below cover CRUD management of a todo list
    Scenario: Retrieving todo list items
      Given existing todo list items
        When a GET request is made for all todo list items
          Then all todo list items are returned
      Given an existing todo list item
        When a GET request is made for it
          Then it is returned
          Then it should have an id
          Then it should have a text
          Then it should have a completed flag
      Given a todo list item that does not exist
        When a GET request is made for it
          Then a '404 Not Found' status is returned
      
    Scenario: Creating a todo list item
      Given a newly created todo list item
        When a valid POST request is made
        Then an todo list item resource should be created
        Then it should be returned
        Then a '201 Created' status is returned
        Then the location header will be set on the reponse to the resource location
        
    Scenario: Deleting todo list item
      Give an existing todo list item
        When a DELETE request is made for it
        Then it should be deleted
        Then a '200 OK' status is returned
      Given a todo list item does not exist
        When a DELETE request is made for it
        Then a '404 Not Found' status is returned
        
    Scenario: Updating a todo list item
      Given an existing todo list item
        When a PATCH request is made for it
        Then the todo list item resource is updated
        Then a '200 OK' is returned
      Given an todo list item does not exist
       When a PATCH request is made for it
        Then a '404 Not Found' status is returned
        
 