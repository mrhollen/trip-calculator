[![Build Status](https://travis-ci.com/mrhollen/trip-calculator.svg?branch=master)](https://travis-ci.com/mrhollen/trip-calculator)

# Trip Calculator
Solution to a trip calculator problem

### What I Used
For the front end of this project I used Angular to build a SPA (Single Page Application) and for the backend I used C# .Net Core to build a REST API. Realistically this project could have been done without a backend, but I added one anyway. I also used docker and docker compose to make running the project much easier.

### How to Run
To run the project, simply navigate to the project root and run the command 

`docker-compose up`. 

If you're running on linux you may need to use sudo.

After the frontend and backend are up and running, open a web browser and go to:

`http://localhost:4200/`

### Some Notes
The current configuration of the project is not ready for production. The angular frontend runs in development mode and connects to the browser over a websocket. If it were to be pushed into production you'd need to build a compiled version of the angular app and serve it in it's compiled form. This could be done with static hosting or as part of a .Net Core backend.

A loading indicator when loading information from the backend would be helpful as right now it's hard to tell if the app actually did what you wanted it to. The reason this was omitted was simply due to time constraints. 
